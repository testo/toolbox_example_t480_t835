namespace T480ToolboxSample
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.comboBoxDrives = new System.Windows.Forms.ComboBox();
         this.BtnConnectDevice480 = new System.Windows.Forms.Button();
         this.BtnDisconnect480 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
         this.BtnGetChannels = new System.Windows.Forms.Button();
         this.BtnStartMeasurement = new System.Windows.Forms.Button();
         this.BtnStopMeasurement = new System.Windows.Forms.Button();
         this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
         this.label2 = new System.Windows.Forms.Label();
         this.comboBox835 = new System.Windows.Forms.ComboBox();
         this.BtnConnect835 = new System.Windows.Forms.Button();
         this.BtnDisconnect835 = new System.Windows.Forms.Button();
         this.tableLayoutPanel1.SuspendLayout();
         this.flowLayoutPanel1.SuspendLayout();
         this.flowLayoutPanel2.SuspendLayout();
         this.flowLayoutPanel3.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 597);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Controls.Add(this.label1);
         this.flowLayoutPanel1.Controls.Add(this.comboBoxDrives);
         this.flowLayoutPanel1.Controls.Add(this.BtnConnectDevice480);
         this.flowLayoutPanel1.Controls.Add(this.BtnDisconnect480);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(922, 34);
         this.flowLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 7);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(89, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Directory of T480";
         // 
         // comboBoxDrives
         // 
         this.comboBoxDrives.FormattingEnabled = true;
         this.comboBoxDrives.Location = new System.Drawing.Point(98, 3);
         this.comboBoxDrives.Name = "comboBoxDrives";
         this.comboBoxDrives.Size = new System.Drawing.Size(121, 21);
         this.comboBoxDrives.TabIndex = 4;
         // 
         // BtnConnectDevice480
         // 
         this.BtnConnectDevice480.Location = new System.Drawing.Point(225, 3);
         this.BtnConnectDevice480.Name = "BtnConnectDevice480";
         this.BtnConnectDevice480.Size = new System.Drawing.Size(80, 23);
         this.BtnConnectDevice480.TabIndex = 3;
         this.BtnConnectDevice480.Text = "Connect";
         this.BtnConnectDevice480.UseVisualStyleBackColor = true;
         this.BtnConnectDevice480.Click += new System.EventHandler(this.BtnConnectDevice_Click);
         // 
         // BtnDisconnect480
         // 
         this.BtnDisconnect480.Location = new System.Drawing.Point(311, 3);
         this.BtnDisconnect480.Name = "BtnDisconnect480";
         this.BtnDisconnect480.Size = new System.Drawing.Size(80, 23);
         this.BtnDisconnect480.TabIndex = 6;
         this.BtnDisconnect480.Text = "Disconnect";
         this.BtnDisconnect480.UseVisualStyleBackColor = true;
         this.BtnDisconnect480.Click += new System.EventHandler(this.BtnDisconnect_Click);
         // 
         // textBox1
         // 
         this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox1.Enabled = false;
         this.textBox1.Location = new System.Drawing.Point(3, 123);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox1.Size = new System.Drawing.Size(922, 471);
         this.textBox1.TabIndex = 1;
         // 
         // flowLayoutPanel2
         // 
         this.flowLayoutPanel2.Controls.Add(this.BtnGetChannels);
         this.flowLayoutPanel2.Controls.Add(this.BtnStartMeasurement);
         this.flowLayoutPanel2.Controls.Add(this.BtnStopMeasurement);
         this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 83);
         this.flowLayoutPanel2.Name = "flowLayoutPanel2";
         this.flowLayoutPanel2.Size = new System.Drawing.Size(922, 34);
         this.flowLayoutPanel2.TabIndex = 2;
         // 
         // BtnGetChannels
         // 
         this.BtnGetChannels.Dock = System.Windows.Forms.DockStyle.Top;
         this.BtnGetChannels.Location = new System.Drawing.Point(3, 3);
         this.BtnGetChannels.Name = "BtnGetChannels";
         this.BtnGetChannels.Size = new System.Drawing.Size(120, 23);
         this.BtnGetChannels.TabIndex = 1;
         this.BtnGetChannels.Text = "Get online channels";
         this.BtnGetChannels.UseVisualStyleBackColor = true;
         this.BtnGetChannels.Click += new System.EventHandler(this.BtnGetChannels_Click);
         // 
         // BtnStartMeasurement
         // 
         this.BtnStartMeasurement.Location = new System.Drawing.Point(129, 3);
         this.BtnStartMeasurement.Name = "BtnStartMeasurement";
         this.BtnStartMeasurement.Size = new System.Drawing.Size(120, 23);
         this.BtnStartMeasurement.TabIndex = 2;
         this.BtnStartMeasurement.Text = "Start measurement";
         this.BtnStartMeasurement.UseVisualStyleBackColor = true;
         this.BtnStartMeasurement.Click += new System.EventHandler(this.BtnStartMeasurement_Click);
         // 
         // BtnStopMeasurement
         // 
         this.BtnStopMeasurement.Location = new System.Drawing.Point(255, 3);
         this.BtnStopMeasurement.Name = "BtnStopMeasurement";
         this.BtnStopMeasurement.Size = new System.Drawing.Size(120, 23);
         this.BtnStopMeasurement.TabIndex = 3;
         this.BtnStopMeasurement.Text = "Stop measurement";
         this.BtnStopMeasurement.UseVisualStyleBackColor = true;
         this.BtnStopMeasurement.Click += new System.EventHandler(this.BtnStopMeasurement_Click);
         // 
         // flowLayoutPanel3
         // 
         this.flowLayoutPanel3.Controls.Add(this.label2);
         this.flowLayoutPanel3.Controls.Add(this.comboBox835);
         this.flowLayoutPanel3.Controls.Add(this.BtnConnect835);
         this.flowLayoutPanel3.Controls.Add(this.BtnDisconnect835);
         this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 43);
         this.flowLayoutPanel3.Name = "flowLayoutPanel3";
         this.flowLayoutPanel3.Size = new System.Drawing.Size(922, 34);
         this.flowLayoutPanel3.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 7);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(107, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "T 835 Serial numbers";
         // 
         // comboBox835
         // 
         this.comboBox835.FormattingEnabled = true;
         this.comboBox835.Location = new System.Drawing.Point(116, 3);
         this.comboBox835.Name = "comboBox835";
         this.comboBox835.Size = new System.Drawing.Size(121, 21);
         this.comboBox835.TabIndex = 3;
         // 
         // BtnConnect835
         // 
         this.BtnConnect835.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnConnect835.Location = new System.Drawing.Point(243, 3);
         this.BtnConnect835.Name = "BtnConnect835";
         this.BtnConnect835.Size = new System.Drawing.Size(75, 21);
         this.BtnConnect835.TabIndex = 0;
         this.BtnConnect835.Text = "Connect ";
         this.BtnConnect835.UseVisualStyleBackColor = true;
         this.BtnConnect835.Click += new System.EventHandler(this.BtnConnect835_Click);
         // 
         // BtnDisconnect835
         // 
         this.BtnDisconnect835.Location = new System.Drawing.Point(324, 3);
         this.BtnDisconnect835.Name = "BtnDisconnect835";
         this.BtnDisconnect835.Size = new System.Drawing.Size(89, 20);
         this.BtnDisconnect835.TabIndex = 1;
         this.BtnDisconnect835.Text = "Disconnect";
         this.BtnDisconnect835.UseVisualStyleBackColor = true;
         this.BtnDisconnect835.Click += new System.EventHandler(this.BtnDisconnect835_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(928, 597);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "Form1";
         this.Text = "Testo IOnline Demo";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         this.flowLayoutPanel2.ResumeLayout(false);
         this.flowLayoutPanel3.ResumeLayout(false);
         this.flowLayoutPanel3.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox comboBoxDrives;
      private System.Windows.Forms.Button BtnConnectDevice480;
      private System.Windows.Forms.Button BtnDisconnect480;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
      private System.Windows.Forms.Button BtnGetChannels;
      private System.Windows.Forms.Button BtnStartMeasurement;
      private System.Windows.Forms.Button BtnStopMeasurement;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button BtnConnect835;
      private System.Windows.Forms.Button BtnDisconnect835;
      private System.Windows.Forms.ComboBox comboBox835;
   }
}

