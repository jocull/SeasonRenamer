using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public partial class frmEdit : Form
{
    public string EditingTitle = "";

    public frmEdit(string editTitle)
    {
        InitializeComponent();
        EditingTitle = editTitle;
        lblTitle.Text += "\"" + EditingTitle + "\"";
        txtNewTitle.Text = EditingTitle;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (Program.ValidateSpecialChars(txtNewTitle.Text) || txtNewTitle.Text.Trim().Length == 0)
        {
            return;
        }
        EditingTitle = txtNewTitle.Text.Trim();
        this.Hide();
    }

    private void frmEdit_Load(object sender, EventArgs e)
    {
        
    }
}