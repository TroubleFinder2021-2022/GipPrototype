
namespace WinFormsAppGipTesting
{
    partial class FormProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProblem));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.lstProblems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.btnGetSolution = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.lblCategoryHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(742, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryTitle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCategoryTitle.Location = new System.Drawing.Point(35, 35);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(157, 20);
            this.lblCategoryTitle.TabIndex = 3;
            this.lblCategoryTitle.Text = "{category} Problems:";
            // 
            // lstProblems
            // 
            this.lstProblems.FormattingEnabled = true;
            this.lstProblems.ItemHeight = 15;
            this.lstProblems.Location = new System.Drawing.Point(35, 59);
            this.lstProblems.Name = "lstProblems";
            this.lstProblems.Size = new System.Drawing.Size(300, 64);
            this.lstProblems.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(397, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solution:";
            // 
            // txtSolution
            // 
            this.txtSolution.BackColor = System.Drawing.Color.White;
            this.txtSolution.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSolution.Enabled = false;
            this.txtSolution.Location = new System.Drawing.Point(397, 58);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ReadOnly = true;
            this.txtSolution.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSolution.Size = new System.Drawing.Size(300, 230);
            this.txtSolution.TabIndex = 6;
            // 
            // btnGetSolution
            // 
            this.btnGetSolution.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetSolution.FlatAppearance.BorderSize = 0;
            this.btnGetSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSolution.Location = new System.Drawing.Point(218, 294);
            this.btnGetSolution.Name = "btnGetSolution";
            this.btnGetSolution.Size = new System.Drawing.Size(300, 35);
            this.btnGetSolution.TabIndex = 7;
            this.btnGetSolution.Text = "View solution for selected problem";
            this.btnGetSolution.UseVisualStyleBackColor = false;
            this.btnGetSolution.Click += new System.EventHandler(this.btnGetSolution_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnAdminPanel);
            this.panel2.Controls.Add(this.lblCategoryHeader);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 50);
            this.panel2.TabIndex = 32;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminPanel.BackColor = System.Drawing.Color.White;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Location = new System.Drawing.Point(1423, 12);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(83, 25);
            this.btnAdminPanel.TabIndex = 7;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            // 
            // lblCategoryHeader
            // 
            this.lblCategoryHeader.AutoSize = true;
            this.lblCategoryHeader.Location = new System.Drawing.Point(15, 17);
            this.lblCategoryHeader.Name = "lblCategoryHeader";
            this.lblCategoryHeader.Size = new System.Drawing.Size(113, 15);
            this.lblCategoryHeader.TabIndex = 1;
            this.lblCategoryHeader.Text = "{category} Solutions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.lstProblems);
            this.panel1.Controls.Add(this.btnGetSolution);
            this.panel1.Controls.Add(this.lblCategoryTitle);
            this.panel1.Controls.Add(this.txtSolution);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(50, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 350);
            this.panel1.TabIndex = 33;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 137);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(300, 150);
            this.dataGridView.TabIndex = 8;
            // 
            // FormProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TroubleFinder™";
            this.Load += new System.EventHandler(this.FormHardwareIndex_Load);
            this.Shown += new System.EventHandler(this.FormProblem_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.ListBox lstProblems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Button btnGetSolution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Label lblCategoryHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}