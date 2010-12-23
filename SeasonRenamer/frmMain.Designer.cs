partial class frmMain
{
    private System.ComponentModel.IContainer components = null;

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
        this.label1 = new System.Windows.Forms.Label();
        this.txtFolderPath = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtExtentionMask = new System.Windows.Forms.TextBox();
        this.lvwSelectedFiles = new System.Windows.Forms.ListView();
        this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        this.lvwNewNames = new System.Windows.Forms.ListView();
        this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        this.lblSelectedFiles = new System.Windows.Forms.Label();
        this.btnFindFolder = new System.Windows.Forms.Button();
        this.label4 = new System.Windows.Forms.Label();
        this.txtNumberMask = new System.Windows.Forms.TextBox();
        this.lblEpisodeTitles = new System.Windows.Forms.Label();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnRemoveRight = new System.Windows.Forms.Button();
        this.btnRename = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.btnMoveUpRight = new System.Windows.Forms.Button();
        this.btnMoveDownRight = new System.Windows.Forms.Button();
        this.label6 = new System.Windows.Forms.Label();
        this.txtFrontChar = new System.Windows.Forms.TextBox();
        this.btnGetTitles = new System.Windows.Forms.Button();
        this.txtNewTitle = new System.Windows.Forms.TextBox();
        this.btnClear = new System.Windows.Forms.Button();
        this.btnEditTitle = new System.Windows.Forms.Button();
        this.btnMoveDownLeft = new System.Windows.Forms.Button();
        this.btnMoveUpLeft = new System.Windows.Forms.Button();
        this.btnRemoveLeft = new System.Windows.Forms.Button();
        this.tmrClipboardTimer = new System.Windows.Forms.Timer(this.components);
        this.txtBackChar = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.label9 = new System.Windows.Forms.Label();
        this.btnClipboardToggle = new System.Windows.Forms.Button();
        this.btnReplace = new System.Windows.Forms.Button();
        this.txtReplace1 = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtReplace2 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(84, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Selected Folder:";
        // 
        // txtFolderPath
        // 
        this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtFolderPath.Location = new System.Drawing.Point(13, 26);
        this.txtFolderPath.Name = "txtFolderPath";
        this.txtFolderPath.ReadOnly = true;
        this.txtFolderPath.Size = new System.Drawing.Size(489, 20);
        this.txtFolderPath.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(13, 53);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(82, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "Extension Mask";
        // 
        // txtExtentionMask
        // 
        this.txtExtentionMask.Location = new System.Drawing.Point(13, 70);
        this.txtExtentionMask.Name = "txtExtentionMask";
        this.txtExtentionMask.Size = new System.Drawing.Size(83, 20);
        this.txtExtentionMask.TabIndex = 3;
        this.txtExtentionMask.Text = ".avi";
        // 
        // lvwSelectedFiles
        // 
        this.lvwSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
        this.lvwSelectedFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
        this.lvwSelectedFiles.FullRowSelect = true;
        this.lvwSelectedFiles.Location = new System.Drawing.Point(90, 113);
        this.lvwSelectedFiles.MultiSelect = false;
        this.lvwSelectedFiles.Name = "lvwSelectedFiles";
        this.lvwSelectedFiles.Size = new System.Drawing.Size(221, 220);
        this.lvwSelectedFiles.TabIndex = 4;
        this.lvwSelectedFiles.UseCompatibleStateImageBehavior = false;
        this.lvwSelectedFiles.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader1
        // 
        this.columnHeader1.Text = "File Name";
        this.columnHeader1.Width = 500;
        // 
        // lvwNewNames
        // 
        this.lvwNewNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
        this.lvwNewNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
        this.lvwNewNames.FullRowSelect = true;
        this.lvwNewNames.Location = new System.Drawing.Point(314, 113);
        this.lvwNewNames.MultiSelect = false;
        this.lvwNewNames.Name = "lvwNewNames";
        this.lvwNewNames.Size = new System.Drawing.Size(221, 220);
        this.lvwNewNames.TabIndex = 5;
        this.lvwNewNames.UseCompatibleStateImageBehavior = false;
        this.lvwNewNames.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader2
        // 
        this.columnHeader2.Text = "Episode Title";
        this.columnHeader2.Width = 500;
        // 
        // lblSelectedFiles
        // 
        this.lblSelectedFiles.AutoSize = true;
        this.lblSelectedFiles.Location = new System.Drawing.Point(87, 97);
        this.lblSelectedFiles.Name = "lblSelectedFiles";
        this.lblSelectedFiles.Size = new System.Drawing.Size(76, 13);
        this.lblSelectedFiles.TabIndex = 6;
        this.lblSelectedFiles.Text = "Selected Files:";
        // 
        // btnFindFolder
        // 
        this.btnFindFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnFindFolder.Location = new System.Drawing.Point(508, 23);
        this.btnFindFolder.Name = "btnFindFolder";
        this.btnFindFolder.Size = new System.Drawing.Size(106, 23);
        this.btnFindFolder.TabIndex = 7;
        this.btnFindFolder.Text = "Browse for Folder";
        this.btnFindFolder.UseVisualStyleBackColor = true;
        this.btnFindFolder.Click += new System.EventHandler(this.btnFindFolder_Click);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(111, 53);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(87, 13);
        this.label4.TabIndex = 8;
        this.label4.Text = "Numbering Mask";
        // 
        // txtNumberMask
        // 
        this.txtNumberMask.Location = new System.Drawing.Point(114, 70);
        this.txtNumberMask.Name = "txtNumberMask";
        this.txtNumberMask.Size = new System.Drawing.Size(100, 20);
        this.txtNumberMask.TabIndex = 9;
        this.txtNumberMask.Text = "1x##-";
        // 
        // lblEpisodeTitles
        // 
        this.lblEpisodeTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblEpisodeTitles.AutoSize = true;
        this.lblEpisodeTitles.Location = new System.Drawing.Point(311, 97);
        this.lblEpisodeTitles.Name = "lblEpisodeTitles";
        this.lblEpisodeTitles.Size = new System.Drawing.Size(76, 13);
        this.lblEpisodeTitles.TabIndex = 10;
        this.lblEpisodeTitles.Text = "Episode Titles:";
        // 
        // btnAdd
        // 
        this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnAdd.Location = new System.Drawing.Point(314, 339);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(88, 23);
        this.btnAdd.TabIndex = 11;
        this.btnAdd.Text = "Add Title";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // btnRemoveRight
        // 
        this.btnRemoveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnRemoveRight.Location = new System.Drawing.Point(541, 204);
        this.btnRemoveRight.Name = "btnRemoveRight";
        this.btnRemoveRight.Size = new System.Drawing.Size(73, 23);
        this.btnRemoveRight.TabIndex = 12;
        this.btnRemoveRight.Text = "Remove";
        this.btnRemoveRight.UseVisualStyleBackColor = true;
        this.btnRemoveRight.Click += new System.EventHandler(this.btnRemove_Click);
        // 
        // btnRename
        // 
        this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnRename.Location = new System.Drawing.Point(314, 397);
        this.btnRename.Name = "btnRename";
        this.btnRename.Size = new System.Drawing.Size(124, 23);
        this.btnRename.TabIndex = 13;
        this.btnRename.Text = "Perform Rename";
        this.btnRename.UseVisualStyleBackColor = true;
        this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
        // 
        // btnExit
        // 
        this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnExit.Location = new System.Drawing.Point(444, 397);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 14;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // btnMoveUpRight
        // 
        this.btnMoveUpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnMoveUpRight.Location = new System.Drawing.Point(541, 175);
        this.btnMoveUpRight.Name = "btnMoveUpRight";
        this.btnMoveUpRight.Size = new System.Drawing.Size(73, 23);
        this.btnMoveUpRight.TabIndex = 15;
        this.btnMoveUpRight.Text = "Move Up";
        this.btnMoveUpRight.UseVisualStyleBackColor = true;
        this.btnMoveUpRight.Click += new System.EventHandler(this.btnMoveUp_Click);
        // 
        // btnMoveDownRight
        // 
        this.btnMoveDownRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnMoveDownRight.Location = new System.Drawing.Point(541, 233);
        this.btnMoveDownRight.Name = "btnMoveDownRight";
        this.btnMoveDownRight.Size = new System.Drawing.Size(73, 23);
        this.btnMoveDownRight.TabIndex = 16;
        this.btnMoveDownRight.Text = "Move Down";
        this.btnMoveDownRight.UseVisualStyleBackColor = true;
        this.btnMoveDownRight.Click += new System.EventHandler(this.btnMoveDown_Click);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(234, 54);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(60, 13);
        this.label6.TabIndex = 17;
        this.label6.Text = "Crop Titles:";
        // 
        // txtFrontChar
        // 
        this.txtFrontChar.Location = new System.Drawing.Point(281, 70);
        this.txtFrontChar.Name = "txtFrontChar";
        this.txtFrontChar.Size = new System.Drawing.Size(59, 20);
        this.txtFrontChar.TabIndex = 18;
        this.txtFrontChar.Text = "0";
        this.txtFrontChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharCount_KeyPress);
        // 
        // btnGetTitles
        // 
        this.btnGetTitles.Location = new System.Drawing.Point(452, 68);
        this.btnGetTitles.Name = "btnGetTitles";
        this.btnGetTitles.Size = new System.Drawing.Size(74, 23);
        this.btnGetTitles.TabIndex = 19;
        this.btnGetTitles.Text = "Get Titles";
        this.btnGetTitles.UseVisualStyleBackColor = true;
        this.btnGetTitles.Click += new System.EventHandler(this.btnGetTitles_Click);
        // 
        // txtNewTitle
        // 
        this.txtNewTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.txtNewTitle.Location = new System.Drawing.Point(408, 341);
        this.txtNewTitle.Name = "txtNewTitle";
        this.txtNewTitle.Size = new System.Drawing.Size(205, 20);
        this.txtNewTitle.TabIndex = 20;
        this.txtNewTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewTitle_KeyPress);
        // 
        // btnClear
        // 
        this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClear.Location = new System.Drawing.Point(541, 309);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(73, 23);
        this.btnClear.TabIndex = 21;
        this.btnClear.Text = "Clear List";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // btnEditTitle
        // 
        this.btnEditTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnEditTitle.Location = new System.Drawing.Point(541, 280);
        this.btnEditTitle.Name = "btnEditTitle";
        this.btnEditTitle.Size = new System.Drawing.Size(73, 23);
        this.btnEditTitle.TabIndex = 22;
        this.btnEditTitle.Text = "Edit Title";
        this.btnEditTitle.UseVisualStyleBackColor = true;
        this.btnEditTitle.Click += new System.EventHandler(this.btnEditTitle_Click);
        // 
        // btnMoveDownLeft
        // 
        this.btnMoveDownLeft.Location = new System.Drawing.Point(11, 233);
        this.btnMoveDownLeft.Name = "btnMoveDownLeft";
        this.btnMoveDownLeft.Size = new System.Drawing.Size(73, 23);
        this.btnMoveDownLeft.TabIndex = 25;
        this.btnMoveDownLeft.Text = "Move Down";
        this.btnMoveDownLeft.UseVisualStyleBackColor = true;
        this.btnMoveDownLeft.Click += new System.EventHandler(this.btnMoveDownLeft_Click);
        // 
        // btnMoveUpLeft
        // 
        this.btnMoveUpLeft.Location = new System.Drawing.Point(11, 175);
        this.btnMoveUpLeft.Name = "btnMoveUpLeft";
        this.btnMoveUpLeft.Size = new System.Drawing.Size(73, 23);
        this.btnMoveUpLeft.TabIndex = 24;
        this.btnMoveUpLeft.Text = "Move Up";
        this.btnMoveUpLeft.UseVisualStyleBackColor = true;
        this.btnMoveUpLeft.Click += new System.EventHandler(this.btnMoveUpLeft_Click);
        // 
        // btnRemoveLeft
        // 
        this.btnRemoveLeft.Location = new System.Drawing.Point(11, 204);
        this.btnRemoveLeft.Name = "btnRemoveLeft";
        this.btnRemoveLeft.Size = new System.Drawing.Size(73, 23);
        this.btnRemoveLeft.TabIndex = 23;
        this.btnRemoveLeft.Text = "Remove";
        this.btnRemoveLeft.UseVisualStyleBackColor = true;
        this.btnRemoveLeft.Click += new System.EventHandler(this.btnRemoveLeft_Click);
        // 
        // tmrClipboardTimer
        // 
        this.tmrClipboardTimer.Tick += new System.EventHandler(this.tmrClipboardTimer_Tick);
        // 
        // txtBackChar
        // 
        this.txtBackChar.Location = new System.Drawing.Point(394, 70);
        this.txtBackChar.Name = "txtBackChar";
        this.txtBackChar.Size = new System.Drawing.Size(52, 20);
        this.txtBackChar.TabIndex = 26;
        this.txtBackChar.Text = "0";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(234, 73);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(41, 13);
        this.label7.TabIndex = 27;
        this.label7.Text = "Front #";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(346, 73);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(42, 13);
        this.label8.TabIndex = 28;
        this.label8.Text = "Back #";
        // 
        // label9
        // 
        this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.label9.AutoSize = true;
        this.label9.Location = new System.Drawing.Point(198, 344);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(110, 13);
        this.label9.TabIndex = 29;
        this.label9.Text = "Clipboard Capture is...";
        // 
        // btnClipboardToggle
        // 
        this.btnClipboardToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClipboardToggle.Location = new System.Drawing.Point(219, 360);
        this.btnClipboardToggle.Name = "btnClipboardToggle";
        this.btnClipboardToggle.Size = new System.Drawing.Size(75, 23);
        this.btnClipboardToggle.TabIndex = 30;
        this.btnClipboardToggle.Text = "OFF";
        this.btnClipboardToggle.UseVisualStyleBackColor = true;
        this.btnClipboardToggle.Click += new System.EventHandler(this.btnClipboardToggle_Click);
        // 
        // btnReplace
        // 
        this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnReplace.Location = new System.Drawing.Point(315, 368);
        this.btnReplace.Name = "btnReplace";
        this.btnReplace.Size = new System.Drawing.Size(87, 23);
        this.btnReplace.TabIndex = 31;
        this.btnReplace.Text = "Replace";
        this.btnReplace.UseVisualStyleBackColor = true;
        this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
        // 
        // txtReplace1
        // 
        this.txtReplace1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.txtReplace1.Location = new System.Drawing.Point(408, 370);
        this.txtReplace1.Name = "txtReplace1";
        this.txtReplace1.Size = new System.Drawing.Size(67, 20);
        this.txtReplace1.TabIndex = 32;
        this.txtReplace1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReplace1_KeyPress);
        // 
        // label3
        // 
        this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(491, 373);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(35, 13);
        this.label3.TabIndex = 33;
        this.label3.Text = "with...";
        // 
        // txtReplace2
        // 
        this.txtReplace2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.txtReplace2.Location = new System.Drawing.Point(546, 370);
        this.txtReplace2.Name = "txtReplace2";
        this.txtReplace2.Size = new System.Drawing.Size(67, 20);
        this.txtReplace2.TabIndex = 34;
        this.txtReplace2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReplace2_KeyPress);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(625, 429);
        this.Controls.Add(this.txtReplace2);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.txtReplace1);
        this.Controls.Add(this.btnReplace);
        this.Controls.Add(this.btnClipboardToggle);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.txtBackChar);
        this.Controls.Add(this.btnMoveDownLeft);
        this.Controls.Add(this.btnMoveUpLeft);
        this.Controls.Add(this.btnRemoveLeft);
        this.Controls.Add(this.btnEditTitle);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.txtNewTitle);
        this.Controls.Add(this.btnGetTitles);
        this.Controls.Add(this.txtFrontChar);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.btnMoveDownRight);
        this.Controls.Add(this.btnMoveUpRight);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnRename);
        this.Controls.Add(this.btnRemoveRight);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.lblEpisodeTitles);
        this.Controls.Add(this.txtNumberMask);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.btnFindFolder);
        this.Controls.Add(this.lblSelectedFiles);
        this.Controls.Add(this.lvwNewNames);
        this.Controls.Add(this.lvwSelectedFiles);
        this.Controls.Add(this.txtExtentionMask);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtFolderPath);
        this.Controls.Add(this.label1);
        this.MinimumSize = new System.Drawing.Size(633, 463);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "jocull\'s Season Renamer - v1.0";
        this.Load += new System.EventHandler(this.frmMain_Load);
        this.Resize += new System.EventHandler(this.frmMain_Resize);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFolderPath;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtExtentionMask;
    private System.Windows.Forms.ListView lvwSelectedFiles;
    private System.Windows.Forms.ListView lvwNewNames;
    private System.Windows.Forms.Label lblSelectedFiles;
    private System.Windows.Forms.Button btnFindFolder;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtNumberMask;
    private System.Windows.Forms.Label lblEpisodeTitles;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemoveRight;
    private System.Windows.Forms.Button btnRename;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnMoveUpRight;
    private System.Windows.Forms.Button btnMoveDownRight;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtFrontChar;
    private System.Windows.Forms.Button btnGetTitles;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TextBox txtNewTitle;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnEditTitle;
    private System.Windows.Forms.Button btnMoveDownLeft;
    private System.Windows.Forms.Button btnMoveUpLeft;
    private System.Windows.Forms.Button btnRemoveLeft;
    private System.Windows.Forms.Timer tmrClipboardTimer;
    private System.Windows.Forms.TextBox txtBackChar;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btnClipboardToggle;
    private System.Windows.Forms.Button btnReplace;
    private System.Windows.Forms.TextBox txtReplace1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtReplace2;
}