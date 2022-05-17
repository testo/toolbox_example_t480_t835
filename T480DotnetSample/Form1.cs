using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Testo.BusinessObjects.Measurement.Interfaces;
using Testo.Instrument.Interfaces;
using Testo.Instrument.Testo480;
using Testo.Instrument.Testo835;
using T835UsbSer;

namespace T480ToolboxSample
{
   public partial class Form1 : Form
   {
      private Timer MeasureTimer { get; set; }
      private IDevice ConnectedDevice { get; set; }
      private IOnline OnlineDevice { get; set; }
      private List<IOnlineChannel> OnlineChannels { get; set; }

      public Form1()
      {
         MeasureTimer = new Timer();
         MeasureTimer.Enabled = false;
         InitializeComponent();
         EnableButtons(false);
         List<string> t480drives = Get480Drives();

         foreach (string oneDrive in t480drives)
         {
            comboBoxDrives.Items.Add(oneDrive);
         }

         List<uint> t835SerialNrs = GetT835SerialNumbers();

         foreach (uint serNr in t835SerialNrs)
         {
            comboBox835.Items.Add(serNr);
         }
      }

      private static List<uint> GetT835SerialNumbers()
      {
         List<uint> t835SerialNrs = null;

         t835SerialNrs = new List<uint>();
         int nrOfDevices = T835Driver.GetNumberOfDevices();
         for (int i = 0; i < nrOfDevices; i++)
         {
            try
            {
               uint serialNumber = T835Driver.Get835SerialNumber(i);
               t835SerialNrs.Add(serialNumber);
            }
            catch (Exception)
            {
            }
         }
         return t835SerialNrs;
      }

      private static List<string> Get480Drives()
      {
         List<string> t480drives = null;

         t480drives = new List<string>();
         DriveInfo[] infos = DriveInfo.GetDrives();
         foreach (DriveInfo info in infos)
         {
            if (info.DriveType == DriveType.Removable)
            {
               t480drives.Add(info.RootDirectory.FullName);
            }
         }
         return t480drives;
      }

      /// <summary>
      /// Connects to a T480 device.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void BtnConnectDevice_Click(object sender, EventArgs e)
      {
         if (comboBoxDrives.SelectedItem != null)
         {
            try
            {
               Testo480 device = new Testo480();
               device.DevicePath = comboBoxDrives.Text;
               device.Connect();
               ConnectedDevice = device as IDevice;
               OnlineDevice = device as IOnline;
               textBox1.Text = "Connected!";
               EnableButtons(true);
            }
            catch (Exception ex)
            {
               MessageBox.Show("can't connect to Testo480, ", ex.Message);
            }
         }
      }

      private void EnableButtons(bool enable)
      {
         BtnStartMeasurement.Enabled = enable;
         BtnStopMeasurement.Enabled = enable;
         BtnGetChannels.Enabled = enable;
      }


      /// <summary>
      /// reads the available online channels and print it on screen and puts the header into Excel, if checkbox is checked.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void BtnGetChannels_Click(object sender, EventArgs e)
      {
         if (MeasureTimer == null || MeasureTimer.Enabled)
         {
            MessageBox.Show("deactivate online measurement first!");
            return;
         }
         if (OnlineDevice == null)
         {
            MessageBox.Show("please connect to device first");
            return;
         }
         textBox1.Clear();
         textBox1.Multiline = true;

         OnlineChannels = OnlineDevice.GetOnlineChannels();
         foreach (IOnlineChannel channel in OnlineChannels)
         {
            textBox1.Text += string.Format("Online channel {0}\tprecision {1}\tUnit {2}", channel.Name, channel.Precision, channel.Unit);
            textBox1.Text += Environment.NewLine;
         }
      }

      /// <summary>
      /// Starts the online measurement on the device.
      /// Starts the timer for reading online values.
      /// starts Excel with a new document if the checkbox is checked.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void BtnStartMeasurement_Click(object sender, EventArgs e)
      {
         if (OnlineDevice == null)
         {
            MessageBox.Show("please connect to device first");
         }

         // first get the online channels
         BtnGetChannels_Click(sender, e);
         // then start online measurement
         OnlineDevice.StartOnline();

         MeasureTimer = new Timer();
         MeasureTimer.Interval = 2000;
         MeasureTimer.Tick += new EventHandler(MeasureTimer_Tick);
         MeasureTimer.Enabled = true;
      }

      /// <summary>
      /// timer function to read one row of online values.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      void MeasureTimer_Tick(object sender, EventArgs e)
      {
         if (OnlineDevice != null)
         {
            string values = "";
            int channelIndex = 0;
            foreach (IOnlineValue val in OnlineDevice.GetOnlineValues())
            {
               values += string.Format("{0}_{1}_{2} | ", val.ValueAsFloat, val.MeasValueType, val.MeasError);
               channelIndex++;
            }
            textBox1.Text += values;
            textBox1.Text += Environment.NewLine;
         }
      }

      /// <summary>
      /// stops an online measurement on the device and disables the measure timer.
      /// closes excel connection.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void BtnStopMeasurement_Click(object sender, EventArgs e)
      {
         if (MeasureTimer == null || !MeasureTimer.Enabled)
         {
            MessageBox.Show("start online measurement first!");
            return;
         }
         MeasureTimer.Enabled = false;
         OnlineDevice.StopOnline();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      /// <summary>
      /// Disconnect the device independent of type.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void BtnDisconnect_Click(object sender, EventArgs e)
      {
         if (ConnectedDevice != null)
         {
            ConnectedDevice.Disconnect();
            ConnectedDevice.Dispose();
            OnlineDevice = null;
            ConnectedDevice = null;
         }
      }

      /// <summary>
      /// connects to a T835 device.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void BtnConnect835_Click(object sender, EventArgs e)
      {
         BtnDisconnect_Click(sender, e);
         int deviceCount = T835Driver.GetNumberOfDevices();
         if (deviceCount <= 0)
         {
            MessageBox.Show("Not able to connect to T835, Device count is 0");
         }

         uint serialNumber = T835Driver.Get835SerialNumber(0);

         Testo835 dev = new Testo835();
         dev.SerialNumberToConnect(serialNumber.ToString());
         dev.Connect();
         EnableButtons(true);
         ConnectedDevice = dev as IDevice;
         OnlineDevice = dev as IOnline;
      }

      private void BtnDisconnect835_Click(object sender, EventArgs e)
      {
         BtnDisconnect_Click(sender, e);
      }

      private string GetExcelNumberFormat(IOnlineValue val)
      {
         string retval = string.Empty;

         //if (val.MeasError == MeasError.valid)
         //{
         //   retval = "0.";
         //   for (int i = val.)
         //   {
         //   }
         //}
         return retval;
      }

      private void checkBoxExcel_CheckedChanged(object sender, EventArgs e)
      {
         
      }

   }
}
