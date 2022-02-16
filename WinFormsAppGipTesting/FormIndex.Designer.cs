
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
            this.btnHardware = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.pictbxHardware = new System.Windows.Forms.PictureBox();
            this.pictbxSoftware = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            this.btnSecret = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxHardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSoftware)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHardware
            // 
            this.btnHardware.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHardware.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHardware.FlatAppearance.BorderSize = 0;
            this.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardware.Location = new System.Drawing.Point(173, 290);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(200, 50);
            this.btnHardware.TabIndex = 1;
            this.btnHardware.Text = "Hardware";
            this.btnHardware.UseVisualStyleBackColor = false;
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
            // 
            // btnSoftware
            // 
            this.btnSoftware.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSoftware.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSoftware.FlatAppearance.BorderSize = 0;
            this.btnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftware.Location = new System.Drawing.Point(394, 290);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(200, 50);
            this.btnSoftware.TabIndex = 2;
            this.btnSoftware.Text = "Software";
            this.btnSoftware.UseVisualStyleBackColor = false;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // pictbxHardware
            // 
            this.pictbxHardware.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictbxHardware.Image = global::WinFormsAppGipTesting.Properties.Resources.iconsHard;
            this.pictbxHardware.Location = new System.Drawing.Point(173, 54);
            this.pictbxHardware.Name = "pictbxHardware";
            this.pictbxHardware.Size = new System.Drawing.Size(200, 200);
            this.pictbxHardware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxHardware.TabIndex = 3;
            this.pictbxHardware.TabStop = false;
            // 
            // pictbxSoftware
            // 
            this.pictbxSoftware.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictbxSoftware.Image = global::WinFormsAppGipTesting.Properties.Resources.iconsSoft;
            this.pictbxSoftware.Location = new System.Drawing.Point(394, 54);
            this.pictbxSoftware.Name = "pictbxSoftware";
            this.pictbxSoftware.Size = new System.Drawing.Size(200, 200);
            this.pictbxSoftware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxSoftware.TabIndex = 4;
            this.pictbxSoftware.TabStop = false;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 32;
            // 
            // btnSecret
            // 
            this.btnSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSecret.BackColor = System.Drawing.Color.White;
            this.btnSecret.FlatAppearance.BorderSize = 0;
            this.btnSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecret.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecret.Location = new System.Drawing.Point(12, 527);
            this.btnSecret.Name = "btnSecret";
            this.btnSecret.Size = new System.Drawing.Size(95, 22);
            this.btnSecret.TabIndex = 6;
            this.btnSecret.Text = "Secret Button";
            this.btnSecret.UseVisualStyleBackColor = false;
            this.btnSecret.Click += new System.EventHandler(this.btnSecret_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnAdminPanel);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 50);
            this.panel2.TabIndex = 31;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminPanel.BackColor = System.Drawing.Color.White;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Location = new System.Drawing.Point(789, 12);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(83, 25);
            this.btnAdminPanel.TabIndex = 7;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1476, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(2160, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 25);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(15, 17);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictbxSoftware);
            this.panel1.Controls.Add(this.pictbxHardware);
            this.panel1.Controls.Add(this.btnSoftware);
            this.panel1.Controls.Add(this.btnHardware);
            this.panel1.Location = new System.Drawing.Point(50, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 400);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(685, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "By Ilias and Loïc";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(337, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "TroubleFinder";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(777, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 22);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Exit Application";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormIndex
            // 
            this.AccessibleName = "test";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSecret);
            this.Controls.Add(this.button);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TroubleFinder™";
            ((System.ComponentModel.ISupportInitialize)(this.pictbxHardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSoftware)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.PictureBox pictbxHardware;
        private System.Windows.Forms.PictureBox pictbxSoftware;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btnSecret;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}

