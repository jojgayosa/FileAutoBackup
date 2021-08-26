namespace AutoBackupFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LoadingAnimation = new System.Windows.Forms.PictureBox();
            this.SetPanel = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProcessInfo = new System.Windows.Forms.Label();
            this.StartBackup = new System.Windows.Forms.Label();
            this.HeaderInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BackupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Auto = new System.Windows.Forms.RadioButton();
            this.Manual = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BackupSaveDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryList = new System.Windows.Forms.DataGridView();
            this.Directories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingsDetail = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ErrorInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingAnimation)).BeginInit();
            this.SetPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryList)).BeginInit();
            this.SettingsDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingAnimation
            // 
            this.LoadingAnimation.Enabled = false;
            this.LoadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("LoadingAnimation.Image")));
            this.LoadingAnimation.Location = new System.Drawing.Point(-38, -6);
            this.LoadingAnimation.Name = "LoadingAnimation";
            this.LoadingAnimation.Size = new System.Drawing.Size(209, 166);
            this.LoadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingAnimation.TabIndex = 0;
            this.LoadingAnimation.TabStop = false;
            // 
            // SetPanel
            // 
            this.SetPanel.BackColor = System.Drawing.Color.Black;
            this.SetPanel.Controls.Add(this.ErrorInfo);
            this.SetPanel.Controls.Add(this.Settings);
            this.SetPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetPanel.Location = new System.Drawing.Point(0, 134);
            this.SetPanel.Name = "SetPanel";
            this.SetPanel.Size = new System.Drawing.Size(459, 46);
            this.SetPanel.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Settings.Location = new System.Drawing.Point(394, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(59, 15);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings>>";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.ProcessInfo);
            this.panel2.Controls.Add(this.StartBackup);
            this.panel2.Controls.Add(this.HeaderInfo);
            this.panel2.Controls.Add(this.LoadingAnimation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 138);
            this.panel2.TabIndex = 0;
            // 
            // ProcessInfo
            // 
            this.ProcessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessInfo.ForeColor = System.Drawing.Color.White;
            this.ProcessInfo.Location = new System.Drawing.Point(141, 86);
            this.ProcessInfo.Name = "ProcessInfo";
            this.ProcessInfo.Size = new System.Drawing.Size(305, 43);
            this.ProcessInfo.TabIndex = 4;
            this.ProcessInfo.Visible = false;
            // 
            // StartBackup
            // 
            this.StartBackup.AutoSize = true;
            this.StartBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBackup.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StartBackup.Location = new System.Drawing.Point(140, 86);
            this.StartBackup.Name = "StartBackup";
            this.StartBackup.Size = new System.Drawing.Size(84, 16);
            this.StartBackup.TabIndex = 2;
            this.StartBackup.Text = "Start Backup";
            this.StartBackup.Click += new System.EventHandler(this.StartBackup_Click);
            // 
            // HeaderInfo
            // 
            this.HeaderInfo.AutoSize = true;
            this.HeaderInfo.ForeColor = System.Drawing.Color.White;
            this.HeaderInfo.Location = new System.Drawing.Point(139, 53);
            this.HeaderInfo.Name = "HeaderInfo";
            this.HeaderInfo.Size = new System.Drawing.Size(183, 20);
            this.HeaderInfo.TabIndex = 1;
            this.HeaderInfo.Text = "No current progress...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BackupName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Auto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Manual, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BackupSaveDir, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 134);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(390, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BackupName
            // 
            this.BackupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.BackupName, 3);
            this.BackupName.Location = new System.Drawing.Point(3, 23);
            this.BackupName.Name = "BackupName";
            this.BackupName.Size = new System.Drawing.Size(433, 20);
            this.BackupName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Backup File Name:";
            // 
            // Auto
            // 
            this.Auto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Auto.AutoSize = true;
            this.Auto.ForeColor = System.Drawing.Color.White;
            this.Auto.Location = new System.Drawing.Point(133, 112);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(72, 17);
            this.Auto.TabIndex = 3;
            this.Auto.Text = "Automatic";
            this.Auto.UseVisualStyleBackColor = true;
            // 
            // Manual
            // 
            this.Manual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Manual.AutoSize = true;
            this.Manual.Checked = true;
            this.Manual.ForeColor = System.Drawing.Color.White;
            this.Manual.Location = new System.Drawing.Point(3, 112);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(60, 17);
            this.Manual.TabIndex = 2;
            this.Manual.TabStop = true;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Type";
            // 
            // BackupSaveDir
            // 
            this.BackupSaveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.BackupSaveDir, 3);
            this.BackupSaveDir.Location = new System.Drawing.Point(3, 67);
            this.BackupSaveDir.Name = "BackupSaveDir";
            this.BackupSaveDir.Size = new System.Drawing.Size(433, 20);
            this.BackupSaveDir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save To:";
            // 
            // DirectoryList
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro;
            this.DirectoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DirectoryList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DirectoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DirectoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Directories,
            this.Status});
            this.DirectoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectoryList.Location = new System.Drawing.Point(10, 147);
            this.DirectoryList.Name = "DirectoryList";
            this.DirectoryList.RowHeadersWidth = 30;
            this.DirectoryList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DirectoryList.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DirectoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DirectoryList.Size = new System.Drawing.Size(439, 0);
            this.DirectoryList.TabIndex = 2;
            this.DirectoryList.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DirectoryList_RowValidated);
            // 
            // Directories
            // 
            this.Directories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Directories.HeaderText = "Directories";
            this.Directories.Name = "Directories";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // SettingsDetail
            // 
            this.SettingsDetail.BackColor = System.Drawing.Color.Black;
            this.SettingsDetail.Controls.Add(this.DirectoryList);
            this.SettingsDetail.Controls.Add(this.tableLayoutPanel1);
            this.SettingsDetail.Controls.Add(this.label5);
            this.SettingsDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsDetail.Location = new System.Drawing.Point(0, 138);
            this.SettingsDetail.Name = "SettingsDetail";
            this.SettingsDetail.Padding = new System.Windows.Forms.Padding(10);
            this.SettingsDetail.Size = new System.Drawing.Size(459, 0);
            this.SettingsDetail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 3);
            this.label5.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ErrorInfo
            // 
            this.ErrorInfo.BackColor = System.Drawing.Color.Black;
            this.ErrorInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorInfo.ForeColor = System.Drawing.Color.Red;
            this.ErrorInfo.Location = new System.Drawing.Point(3, 10);
            this.ErrorInfo.Name = "ErrorInfo";
            this.ErrorInfo.ReadOnly = true;
            this.ErrorInfo.Size = new System.Drawing.Size(385, 33);
            this.ErrorInfo.TabIndex = 5;
            this.ErrorInfo.TabStop = false;
            this.ErrorInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 180);
            this.Controls.Add(this.SettingsDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SetPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BP Solutions Auto Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingAnimation)).EndInit();
            this.SetPanel.ResumeLayout(false);
            this.SetPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryList)).EndInit();
            this.SettingsDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox LoadingAnimation;
        private System.Windows.Forms.Panel SetPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HeaderInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox BackupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Auto;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BackupSaveDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DirectoryList;
        private System.Windows.Forms.Panel SettingsDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StartBackup;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label ProcessInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox ErrorInfo;
    }
}

