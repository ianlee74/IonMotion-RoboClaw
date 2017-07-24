namespace RoboClawTest01
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonGoForward = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelModelTitle = new System.Windows.Forms.Label();
            this.labelRoboClawModel = new System.Windows.Forms.Label();
            this.labelTicks = new System.Windows.Forms.Label();
            this.lblM1EncoderTicksCount = new System.Windows.Forms.Label();
            this.buttonGoReverse = new System.Windows.Forms.Button();
            this.buttonGoToZero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblM2EncoderTicksCount = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblM1Current = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblM2Current = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMainVoltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogicVoltage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(12, 149);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonGoForward
            // 
            this.buttonGoForward.Enabled = false;
            this.buttonGoForward.Location = new System.Drawing.Point(13, 43);
            this.buttonGoForward.Name = "buttonGoForward";
            this.buttonGoForward.Size = new System.Drawing.Size(75, 23);
            this.buttonGoForward.TabIndex = 2;
            this.buttonGoForward.Text = "Go Forward";
            this.buttonGoForward.UseVisualStyleBackColor = true;
            this.buttonGoForward.Click += new System.EventHandler(this.buttonGoForward_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 178);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelModelTitle
            // 
            this.labelModelTitle.AutoSize = true;
            this.labelModelTitle.Location = new System.Drawing.Point(96, 18);
            this.labelModelTitle.Name = "labelModelTitle";
            this.labelModelTitle.Size = new System.Drawing.Size(39, 13);
            this.labelModelTitle.TabIndex = 4;
            this.labelModelTitle.Text = "Model:";
            // 
            // labelRoboClawModel
            // 
            this.labelRoboClawModel.AutoSize = true;
            this.labelRoboClawModel.Location = new System.Drawing.Point(141, 18);
            this.labelRoboClawModel.Name = "labelRoboClawModel";
            this.labelRoboClawModel.Size = new System.Drawing.Size(10, 13);
            this.labelRoboClawModel.TabIndex = 5;
            this.labelRoboClawModel.Text = " ";
            // 
            // labelTicks
            // 
            this.labelTicks.AutoSize = true;
            this.labelTicks.Location = new System.Drawing.Point(96, 83);
            this.labelTicks.Name = "labelTicks";
            this.labelTicks.Size = new System.Drawing.Size(97, 13);
            this.labelTicks.TabIndex = 6;
            this.labelTicks.Text = "M1 Encoder Ticks:";
            // 
            // lblM1EncoderTicksCount
            // 
            this.lblM1EncoderTicksCount.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM1EncoderTicksCount.Location = new System.Drawing.Point(199, 83);
            this.lblM1EncoderTicksCount.Name = "lblM1EncoderTicksCount";
            this.lblM1EncoderTicksCount.Size = new System.Drawing.Size(100, 14);
            this.lblM1EncoderTicksCount.TabIndex = 7;
            this.lblM1EncoderTicksCount.Text = "     0";
            this.lblM1EncoderTicksCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonGoReverse
            // 
            this.buttonGoReverse.Enabled = false;
            this.buttonGoReverse.Location = new System.Drawing.Point(13, 73);
            this.buttonGoReverse.Name = "buttonGoReverse";
            this.buttonGoReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonGoReverse.TabIndex = 8;
            this.buttonGoReverse.Text = "Go Reverse";
            this.buttonGoReverse.UseVisualStyleBackColor = true;
            this.buttonGoReverse.Click += new System.EventHandler(this.buttonGoReverse_Click);
            // 
            // buttonGoToZero
            // 
            this.buttonGoToZero.Enabled = false;
            this.buttonGoToZero.Location = new System.Drawing.Point(13, 103);
            this.buttonGoToZero.Name = "buttonGoToZero";
            this.buttonGoToZero.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToZero.TabIndex = 9;
            this.buttonGoToZero.Text = "Go To Zero";
            this.buttonGoToZero.UseVisualStyleBackColor = true;
            this.buttonGoToZero.Click += new System.EventHandler(this.buttonGoToZero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "M2 Encoder Ticks:";
            // 
            // lblM2EncoderTicksCount
            // 
            this.lblM2EncoderTicksCount.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM2EncoderTicksCount.Location = new System.Drawing.Point(199, 143);
            this.lblM2EncoderTicksCount.Name = "lblM2EncoderTicksCount";
            this.lblM2EncoderTicksCount.Size = new System.Drawing.Size(100, 14);
            this.lblM2EncoderTicksCount.TabIndex = 11;
            this.lblM2EncoderTicksCount.Text = "     0";
            this.lblM2EncoderTicksCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(96, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "M1 Current:";
            // 
            // lblM1Current
            // 
            this.lblM1Current.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM1Current.Location = new System.Drawing.Point(199, 96);
            this.lblM1Current.Name = "lblM1Current";
            this.lblM1Current.Size = new System.Drawing.Size(100, 14);
            this.lblM1Current.TabIndex = 13;
            this.lblM1Current.Text = "     0";
            this.lblM1Current.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "M2 Current:";
            // 
            // lblM2Current
            // 
            this.lblM2Current.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM2Current.Location = new System.Drawing.Point(199, 157);
            this.lblM2Current.Name = "lblM2Current";
            this.lblM2Current.Size = new System.Drawing.Size(100, 14);
            this.lblM2Current.TabIndex = 15;
            this.lblM2Current.Text = "     0";
            this.lblM2Current.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(199, 31);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(100, 14);
            this.lblTemperature.TabIndex = 17;
            this.lblTemperature.Text = "     0";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Temperature:";
            // 
            // lblMainVoltage
            // 
            this.lblMainVoltage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainVoltage.Location = new System.Drawing.Point(199, 44);
            this.lblMainVoltage.Name = "lblMainVoltage";
            this.lblMainVoltage.Size = new System.Drawing.Size(100, 14);
            this.lblMainVoltage.TabIndex = 19;
            this.lblMainVoltage.Text = "     0";
            this.lblMainVoltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Main Voltage:";
            // 
            // lblLogicVoltage
            // 
            this.lblLogicVoltage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogicVoltage.Location = new System.Drawing.Point(199, 57);
            this.lblLogicVoltage.Name = "lblLogicVoltage";
            this.lblLogicVoltage.Size = new System.Drawing.Size(100, 14);
            this.lblLogicVoltage.TabIndex = 21;
            this.lblLogicVoltage.Text = "     0";
            this.lblLogicVoltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Logic Voltage:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 213);
            this.Controls.Add(this.lblLogicVoltage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMainVoltage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblM2Current);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblM1Current);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblM2EncoderTicksCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGoToZero);
            this.Controls.Add(this.buttonGoReverse);
            this.Controls.Add(this.lblM1EncoderTicksCount);
            this.Controls.Add(this.labelTicks);
            this.Controls.Add(this.labelRoboClawModel);
            this.Controls.Add(this.labelModelTitle);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonGoForward);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "RoboClawTest01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGoForward;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelModelTitle;
        private System.Windows.Forms.Label labelRoboClawModel;
        private System.Windows.Forms.Label labelTicks;
        private System.Windows.Forms.Label lblM1EncoderTicksCount;
        private System.Windows.Forms.Button buttonGoReverse;
        private System.Windows.Forms.Button buttonGoToZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblM2EncoderTicksCount;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lblM1Current;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblM2Current;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMainVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLogicVoltage;
        private System.Windows.Forms.Label label8;
    }
}

