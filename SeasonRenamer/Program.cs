using System;
using System.Collections.Generic;
using System.Windows.Forms;

static class Program
{
    public static string AppTitle = "HoundEyeX's Season Renamer";
    private static string[] InvalidChars = { "\\", "/", ":", "*", "?", "\"", "<", ">", "|" };

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
    }

    public static bool ValidateSpecialChars(string name)
    {
        foreach (string specialChar in InvalidChars)
        {
            if (name.Contains(specialChar))
            {
                Program.showMessageBox("A file name may not contain any of the following:\n \\ / : * ? \" < > |");
                return true;
            }
        }

        return false;
    }

    public static string RemoveSpecialChars(string name)
    {
        foreach (string specialChar in InvalidChars)
        {
            if (name.Contains(specialChar))
            {
                name.Replace(specialChar, "");
            }
        }

        return name;
    }

    public static void showMessageBox(string msg)
    {
        MessageBox.Show(msg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }

    public static bool showQuestionBox(string msg)
    {
        DialogResult dr = new DialogResult();
        dr = MessageBox.Show(msg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}