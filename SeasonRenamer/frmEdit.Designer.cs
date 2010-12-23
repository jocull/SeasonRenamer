partial class frmEdit
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.txtNewTitle = new System.Windows.Forms.TextBox();
        this.btnEdit = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Location = new System.Drawing.Point(9, 9);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(101, 13);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Enter a new title for ";
        // 
        // txtNewTitle
        // 
        this.txtNewTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtNewTitle.Location = new System.Drawing.Point(12, 25);
        this.txtNewTitle.Name = "txtNewTitle";
        this.txtNewTitle.Size = new System.Drawing.Size(255, 20);
        this.txtNewTitle.TabIndex = 22;
        // 
        // btnEdit
        // 
        this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnEdit.Location = new System.Drawing.Point(273, 23);
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.Size = new System.Drawing.Size(88, 23);
        this.btnEdit.TabIndex = 21;
        this.btnEdit.Text = "Edit Title";
        this.btnEdit.UseVisualStyleBackColor = true;
        this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
        // 
        // frmEdit
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(368, 54);
        this.Controls.Add(this.txtNewTitle);
        this.Controls.Add(this.btnEdit);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmEdit";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Edit Title";
        this.Load += new System.EventHandler(this.frmEdit_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtNewTitle;
    private System.Windows.Forms.Button btnEdit;
}