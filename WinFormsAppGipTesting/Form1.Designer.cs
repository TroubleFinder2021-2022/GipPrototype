
namespace WinFormsAppGipTesting
{
    partial class FormIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHardware = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.pictbxHardware = new System.Windows.Forms.PictureBox();
            this.pictbxSoftware = new System.Windows.Forms.PictureBox();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxHardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSoftware)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trouble Finder©";
            // 
            // btnHardware
            // 
            this.btnHardware.Location = new System.Drawing.Point(176, 323);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(200, 50);
            this.btnHardware.TabIndex = 1;
            this.btnHardware.Text = "Hardware";
            this.btnHardware.UseVisualStyleBackColor = true;
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
            // 
            // btnSoftware
            // 
            this.btnSoftware.Location = new System.Drawing.Point(397, 323);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(200, 50);
            this.btnSoftware.TabIndex = 2;
            this.btnSoftware.Text = "Software";
            this.btnSoftware.UseVisualStyleBackColor = true;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // pictbxHardware
            // 
            this.pictbxHardware.Image = global::WinFormsAppGipTesting.Properties.Resources.iconsHard;
            this.pictbxHardware.Location = new System.Drawing.Point(176, 82);
            this.pictbxHardware.Name = "pictbxHardware";
            this.pictbxHardware.Size = new System.Drawing.Size(200, 200);
            this.pictbxHardware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxHardware.TabIndex = 3;
            this.pictbxHardware.TabStop = false;
            // 
            // pictbxSoftware
            // 
            this.pictbxSoftware.Image = global::WinFormsAppGipTesting.Properties.Resources.iconsSoft;
            this.pictbxSoftware.Location = new System.Drawing.Point(397, 82);
            this.pictbxSoftware.Name = "pictbxSoftware";
            this.pictbxSoftware.Size = new System.Drawing.Size(200, 200);
            this.pictbxSoftware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxSoftware.TabIndex = 4;
            this.pictbxSoftware.TabStop = false;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(688, 9);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(100, 35);
            this.btnAdminPanel.TabIndex = 5;
            this.btnAdminPanel.Text = "Admin panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 415);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "test button";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FormIndex
            // 
            this.AccessibleName = "test";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.pictbxSoftware);
            this.Controls.Add(this.pictbxHardware);
            this.Controls.Add(this.btnSoftware);
            this.Controls.Add(this.btnHardware);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIndex";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictbxHardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSoftware)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.PictureBox pictbxHardware;
        private System.Windows.Forms.PictureBox pictbxSoftware;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnTest;
    }
}

