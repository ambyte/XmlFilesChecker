using BrightIdeasSoftware;

namespace XmlFilesChecker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bFolder = new System.Windows.Forms.Button();
            this.tbRootFolder = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chbOnlyBroken = new System.Windows.Forms.CheckBox();
            this.bCopyAll = new System.Windows.Forms.Button();
            this.bCopyBroken = new System.Windows.Forms.Button();
            this.bOpenFolder = new System.Windows.Forms.Button();
            this.listViewFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.listViewFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // bFolder
            // 
            this.bFolder.Location = new System.Drawing.Point(12, 12);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(102, 23);
            this.bFolder.TabIndex = 0;
            this.bFolder.Text = "Select folder";
            this.bFolder.UseVisualStyleBackColor = true;
            this.bFolder.Click += new System.EventHandler(this.bFolder_Click);
            // 
            // tbRootFolder
            // 
            this.tbRootFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootFolder.Location = new System.Drawing.Point(120, 14);
            this.tbRootFolder.Name = "tbRootFolder";
            this.tbRootFolder.Size = new System.Drawing.Size(452, 20);
            this.tbRootFolder.TabIndex = 1;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 41);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(102, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Run check";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(120, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(452, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // chbOnlyBroken
            // 
            this.chbOnlyBroken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbOnlyBroken.AutoSize = true;
            this.chbOnlyBroken.Enabled = false;
            this.chbOnlyBroken.Location = new System.Drawing.Point(12, 327);
            this.chbOnlyBroken.Name = "chbOnlyBroken";
            this.chbOnlyBroken.Size = new System.Drawing.Size(83, 17);
            this.chbOnlyBroken.TabIndex = 5;
            this.chbOnlyBroken.Text = "Only broken";
            this.chbOnlyBroken.UseVisualStyleBackColor = true;
            this.chbOnlyBroken.CheckedChanged += new System.EventHandler(this.chbOnlyBroken_CheckedChanged);
            // 
            // bCopyAll
            // 
            this.bCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCopyAll.Enabled = false;
            this.bCopyAll.Location = new System.Drawing.Point(206, 323);
            this.bCopyAll.Name = "bCopyAll";
            this.bCopyAll.Size = new System.Drawing.Size(99, 23);
            this.bCopyAll.TabIndex = 6;
            this.bCopyAll.Text = "Copy all";
            this.bCopyAll.UseVisualStyleBackColor = true;
            this.bCopyAll.Click += new System.EventHandler(this.bCopyAll_Click);
            // 
            // bCopyBroken
            // 
            this.bCopyBroken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCopyBroken.Enabled = false;
            this.bCopyBroken.Location = new System.Drawing.Point(311, 323);
            this.bCopyBroken.Name = "bCopyBroken";
            this.bCopyBroken.Size = new System.Drawing.Size(99, 23);
            this.bCopyBroken.TabIndex = 7;
            this.bCopyBroken.Text = "Copy only broken";
            this.bCopyBroken.UseVisualStyleBackColor = true;
            this.bCopyBroken.Click += new System.EventHandler(this.bCopyBroken_Click);
            // 
            // bOpenFolder
            // 
            this.bOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bOpenFolder.Enabled = false;
            this.bOpenFolder.Location = new System.Drawing.Point(101, 323);
            this.bOpenFolder.Name = "bOpenFolder";
            this.bOpenFolder.Size = new System.Drawing.Size(99, 23);
            this.bOpenFolder.TabIndex = 8;
            this.bOpenFolder.Text = "Open folder";
            this.bOpenFolder.UseVisualStyleBackColor = true;
            this.bOpenFolder.Click += new System.EventHandler(this.bOpenFolder_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.AllColumns.Add(this.olvColumn1);
            this.listViewFiles.AllColumns.Add(this.olvColumn2);
            this.listViewFiles.AllColumns.Add(this.olvColumn3);
            this.listViewFiles.AllColumns.Add(this.olvColumn4);
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(12, 70);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.ShowGroups = false;
            this.listViewFiles.Size = new System.Drawing.Size(560, 247);
            this.listViewFiles.TabIndex = 9;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.listViewFiles_FormatRow);
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "FileName";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "File name";
            this.olvColumn1.Width = 149;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "CreateDate";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Create date";
            this.olvColumn2.Width = 118;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "ModifyDate";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "Modify date";
            this.olvColumn3.Width = 129;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "FullPath";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "Full path";
            this.olvColumn4.Width = 430;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 356);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.bOpenFolder);
            this.Controls.Add(this.bCopyBroken);
            this.Controls.Add(this.bCopyAll);
            this.Controls.Add(this.chbOnlyBroken);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tbRootFolder);
            this.Controls.Add(this.bFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validating XML files in a directory";
            ((System.ComponentModel.ISupportInitialize)(this.listViewFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFolder;
        private System.Windows.Forms.TextBox tbRootFolder;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chbOnlyBroken;
        private System.Windows.Forms.Button bCopyAll;
        private System.Windows.Forms.Button bCopyBroken;
        private System.Windows.Forms.Button bOpenFolder;
        private ObjectListView listViewFiles;
        private OLVColumn olvColumn1;
        private OLVColumn olvColumn2;
        private OLVColumn olvColumn3;
        private OLVColumn olvColumn4;
    }
}

