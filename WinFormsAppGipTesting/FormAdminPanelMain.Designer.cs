﻿
namespace WinFormsAppGipTesting
{
    partial class FormAdminPanelMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAdminAccounts = new System.Windows.Forms.DataGridView();
            this.dataGridViewSolutions = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolutions)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin account management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solution management";
            // 
            // dataGridViewAdminAccounts
            // 
            this.dataGridViewAdminAccounts.AllowUserToAddRows = false;
            this.dataGridViewAdminAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAdminAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminAccounts.Location = new System.Drawing.Point(10, 84);
            this.dataGridViewAdminAccounts.Name = "dataGridViewAdminAccounts";
            this.dataGridViewAdminAccounts.ReadOnly = true;
            this.dataGridViewAdminAccounts.RowTemplate.Height = 25;
            this.dataGridViewAdminAccounts.Size = new System.Drawing.Size(493, 140);
            this.dataGridViewAdminAccounts.TabIndex = 4;
            this.dataGridViewAdminAccounts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAdminAccounts_CellFormatting);
            // 
            // dataGridViewSolutions
            // 
            this.dataGridViewSolutions.AllowUserToAddRows = false;
            this.dataGridViewSolutions.AllowUserToDeleteRows = false;
            this.dataGridViewSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolutions.Location = new System.Drawing.Point(10, 250);
            this.dataGridViewSolutions.Name = "dataGridViewSolutions";
            this.dataGridViewSolutions.ReadOnly = true;
            this.dataGridViewSolutions.RowTemplate.Height = 25;
            this.dataGridViewSolutions.Size = new System.Drawing.Size(493, 140);
            this.dataGridViewSolutions.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create new and edit existing solutions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAdminPanelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewSolutions);
            this.Controls.Add(this.dataGridViewAdminAccounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminPanelMain";
            this.Text = "FormAdminPanelMain";
            this.Load += new System.EventHandler(this.FormAdminPanelMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAdminAccounts;
        private System.Windows.Forms.DataGridView dataGridViewSolutions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}