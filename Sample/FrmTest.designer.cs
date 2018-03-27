namespace SurfaceBlurTest
{
    unsafe partial class FrmTest
    {
        /// <summary>
        /// Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources that are in use.
        /// </summary>
        /// <param name="disposing">True if the managed resource should be released; otherwise false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form designer generated code

        /// <summary>
        /// The designer supports the required method - do not use the code editor to modify the content of this method.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.CmdOpen = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.PicSrc = new System.Windows.Forms.PictureBox();
            this.CmdProcess = new System.Windows.Forms.Button();
            this.LblRadiusT = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.HScrollBar();
            this.LblRadius = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblThresholdT = new System.Windows.Forms.Label();
            this.Threshold = new System.Windows.Forms.HScrollBar();
            this.LblThreshold = new System.Windows.Forms.Label();
            this.PicDest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDest)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(4, 7);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(75, 31);
            this.CmdOpen.TabIndex = 21;
            this.CmdOpen.Text = "Open image";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(85, 7);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 31);
            this.CmdSave.TabIndex = 35;
            this.CmdSave.Text = "Save image";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // PicSrc
            // 
            this.PicSrc.Image = ((System.Drawing.Image)(resources.GetObject("PicSrc.Image")));
            this.PicSrc.Location = new System.Drawing.Point(4, 47);
            this.PicSrc.Name = "PicSrc";
            this.PicSrc.Size = new System.Drawing.Size(640, 693);
            this.PicSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSrc.TabIndex = 33;
            this.PicSrc.TabStop = false;
            // 
            // CmdProcess
            // 
            this.CmdProcess.Location = new System.Drawing.Point(166, 7);
            this.CmdProcess.Name = "CmdProcess";
            this.CmdProcess.Size = new System.Drawing.Size(75, 31);
            this.CmdProcess.TabIndex = 37;
            this.CmdProcess.Text = "Process";
            this.CmdProcess.UseVisualStyleBackColor = true;
            this.CmdProcess.Click += new System.EventHandler(this.CmdProcess_Click);
            // 
            // LblRadiusT
            // 
            this.LblRadiusT.AutoSize = true;
            this.LblRadiusT.Location = new System.Drawing.Point(263, 15);
            this.LblRadiusT.Name = "LblRadiusT";
            this.LblRadiusT.Size = new System.Drawing.Size(43, 13);
            this.LblRadiusT.TabIndex = 38;
            this.LblRadiusT.Text = "Radius:";
            // 
            // Radius
            // 
            this.Radius.LargeChange = 1;
            this.Radius.Location = new System.Drawing.Point(319, 15);
            this.Radius.Minimum = 1;
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(237, 17);
            this.Radius.TabIndex = 39;
            this.Radius.Value = 20;
            this.Radius.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Radius_Scroll);
            // 
            // LblRadius
            // 
            this.LblRadius.AutoSize = true;
            this.LblRadius.Location = new System.Drawing.Point(559, 20);
            this.LblRadius.Name = "LblRadius";
            this.LblRadius.Size = new System.Drawing.Size(19, 13);
            this.LblRadius.TabIndex = 40;
            this.LblRadius.Text = "20";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(1252, 17);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(0, 13);
            this.LblInfo.TabIndex = 301;
            // 
            // LblThresholdT
            // 
            this.LblThresholdT.AccessibleDescription = "";
            this.LblThresholdT.AutoSize = true;
            this.LblThresholdT.Location = new System.Drawing.Point(594, 17);
            this.LblThresholdT.Name = "LblThresholdT";
            this.LblThresholdT.Size = new System.Drawing.Size(57, 13);
            this.LblThresholdT.TabIndex = 302;
            this.LblThresholdT.Text = "Threshold:";
            // 
            // Threshold
            // 
            this.Threshold.LargeChange = 2;
            this.Threshold.Location = new System.Drawing.Point(656, 15);
            this.Threshold.Maximum = 255;
            this.Threshold.Minimum = 2;
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(379, 18);
            this.Threshold.SmallChange = 2;
            this.Threshold.TabIndex = 303;
            this.Threshold.Value = 20;
            this.Threshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Threshold_Scroll);
            // 
            // LblThreshold
            // 
            this.LblThreshold.AutoSize = true;
            this.LblThreshold.Location = new System.Drawing.Point(1046, 20);
            this.LblThreshold.Name = "LblThreshold";
            this.LblThreshold.Size = new System.Drawing.Size(19, 13);
            this.LblThreshold.TabIndex = 304;
            this.LblThreshold.Text = "20";
            // 
            // PicDest
            // 
            this.PicDest.Image = ((System.Drawing.Image)(resources.GetObject("PicDest.Image")));
            this.PicDest.Location = new System.Drawing.Point(680, 47);
            this.PicDest.Name = "PicDest";
            this.PicDest.Size = new System.Drawing.Size(640, 693);
            this.PicDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDest.TabIndex = 305;
            this.PicDest.TabStop = false;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 750);
            this.Controls.Add(this.PicDest);
            this.Controls.Add(this.LblThreshold);
            this.Controls.Add(this.Threshold);
            this.Controls.Add(this.LblThresholdT);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblRadius);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.LblRadiusT);
            this.Controls.Add(this.CmdProcess);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.PicSrc);
            this.Controls.Add(this.CmdOpen);
            this.MaximizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surface Blur Test";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.PictureBox PicSrc;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdProcess;
        private System.Windows.Forms.Label LblRadiusT;
        private System.Windows.Forms.HScrollBar Radius;
        private System.Windows.Forms.Label LblRadius;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblThresholdT;
        private System.Windows.Forms.HScrollBar Threshold;
        private System.Windows.Forms.Label LblThreshold;
        private System.Windows.Forms.PictureBox PicDest;

    }
}

