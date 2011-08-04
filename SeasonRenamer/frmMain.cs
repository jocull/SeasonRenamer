using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

public partial class frmMain : Form
{
    string LastClipboard = "";

    private int LocationLeft;
    private int LocationRight;
    private int WorkableWidth;


    public frmMain()
    {
        InitializeComponent();

        frmMain_Resize(null, null);
    }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }

    private void frmMain_Resize(object sender, EventArgs e)
    {
        LocationLeft = btnMoveUpLeft.Bounds.X + btnMoveUpLeft.Width + 3;
        WorkableWidth = (btnMoveUpRight.Bounds.X - 6) - LocationLeft;
        LocationRight = (WorkableWidth / 2) + LocationLeft + 1;

        //Widths and Xs
        lvwSelectedFiles.Location = new System.Drawing.Point(LocationLeft, lvwSelectedFiles.Bounds.Y);
        lvwSelectedFiles.Width = (WorkableWidth / 2) - 1;
        //lvwNewNames.Location.X = SizeRight;
        lvwNewNames.Location = new System.Drawing.Point(LocationRight, lvwNewNames.Bounds.Y);
        lvwNewNames.Width = (WorkableWidth / 2) + 1;

        //Heights
        lvwSelectedFiles.Height = (btnAdd.Bounds.Y - 6) - lvwSelectedFiles.Bounds.Y;
        lvwNewNames.Height = (btnAdd.Bounds.Y - 6) - lvwNewNames.Bounds.Y;

        lblEpisodeTitles.Location = new System.Drawing.Point(LocationRight, lblEpisodeTitles.Bounds.Y);

        lvwSelectedFiles.Columns[0].Width = lvwSelectedFiles.Width-4;
        lvwNewNames.Columns[0].Width = lvwNewNames.Width-4;
    }

    private void btnFindFolder_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        if (txtFolderPath.Text != "")
            fbd.SelectedPath = txtFolderPath.Text;
        fbd.ShowDialog();
        string path = fbd.SelectedPath;
        txtFolderPath.Text = path;

        if (path == "" || path == null)
        {
            return;
        }

        lvwSelectedFiles.Items.Clear();

        string [] fileEntries = Directory.GetFiles(path);
        foreach (string fileName in fileEntries)
        {
            if (txtExtentionMask.Text.Trim().Length > 0)
            {
                if (Path.GetExtension(fileName) == txtExtentionMask.Text.Trim())
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(fileName));
                    lvwSelectedFiles.Items.Add(item);
                }
            }
            else //get all
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(fileName));
                lvwSelectedFiles.Items.Add(item);
            }
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnGetTitles_Click(object sender, EventArgs e)
    {
        if (lvwNewNames.Items.Count > 0)
        {
            if (!Program.showQuestionBox("Are you sure you want to clear the already existing list of titles?"))
            {
                return;
            }
        }
        lvwNewNames.Items.Clear();
        ListViewItem newItem = null;
        string newName = null;
        int frontCount = 0;
        int backCount = 0;

        if (int.TryParse(txtFrontChar.Text, out frontCount) == false ||
                int.TryParse(txtBackChar.Text, out backCount) == false)
        {
            Program.showMessageBox("Character Counts must be a non-negative whole numbers.");
            return;
        }
        if (frontCount < 0 || backCount < 0)
        {
            Program.showMessageBox("Character Counts must be a non-negative whole numbers.");
            return;
        }

        foreach (ListViewItem item in lvwSelectedFiles.Items)
        {
            try
            {
                newName = Path.GetFileNameWithoutExtension(Path.Combine(txtFolderPath.Text, item.Text));
                newName = newName.Substring(frontCount, newName.Length-frontCount-backCount).Trim();
                newName = Program.RemoveSpecialChars(newName);
                newItem = new ListViewItem(newName);

                lvwNewNames.Items.Add(newItem);
            }
            catch
            {
                Program.showMessageBox("Error! Title name was shorter than the character count.");
                lvwNewNames.Items.Clear();
                break;
            }
        }
    }

    private void btnRename_Click(object sender, EventArgs e)
    {
        string fullFileName = "";
        string newFileName = "";
        string episodeNumber = "";
        int count = 1;

        if (lvwSelectedFiles.Items.Count == 0 || 
                lvwNewNames.Items.Count == 0 ||
                lvwSelectedFiles.Items.Count != lvwNewNames.Items.Count)
        {
            Program.showMessageBox("Error! You must have a matching number of titles and files.");
            return;
        }

        string episodeList = "";
        string[] oldFileList = new string[lvwSelectedFiles.Items.Count];
        string[] newFileList = new string[lvwSelectedFiles.Items.Count];

        foreach (ListViewItem item in lvwSelectedFiles.Items)
        {
            fullFileName = Path.Combine(txtFolderPath.Text, item.Text);

            episodeNumber = txtNumberMask.Text;
            episodeNumber = episodeNumber.Replace("##", String.Format("{0:0#}", count));

            newFileName = Path.Combine(txtFolderPath.Text, episodeNumber 
                    + lvwNewNames.Items[count - 1].Text
                    + Path.GetExtension(fullFileName));

            oldFileList[count - 1] = fullFileName;
            newFileList[count - 1] = newFileName;

            episodeList += newFileName + "\n";

            count++;
        }

        bool answer = false;
        answer = Program.showQuestionBox("Here are your new file names:\n\n" + episodeList + "\n\nAre these file names acceptable?");

        if (answer)
        {
            count = 0;
            try
            {
                foreach (string fileName in oldFileList)
                {
                    File.Move(oldFileList[count], newFileList[count]);
                    count++;
                }
            }
            catch (Exception ex)
            {
                Program.showMessageBox("Error while renaming files! Is one of your files currently being accessed?\n\n" + ex.Message);
                return;
            }

            Program.showMessageBox("File rename operation was successful!");
        }
    }

    private void btnMoveUp_Click(object sender, EventArgs e)
    {
        //Stolen from:
        //http://www.knowdotnet.com/articles/listviewmoveitem.html
        string cache;
        int selIdx;
        try
        {
            selIdx = lvwNewNames.SelectedItems[0].Index;

            // ignore moveup of row(0)
            if (selIdx == 0)
                return;

            // move the subitems for the previous row
            // to cache to make room for the selected row
            for (int i = 0; i < lvwNewNames.Items[selIdx].SubItems.Count; i++)
            {
                cache = lvwNewNames.Items[selIdx - 1].SubItems[i].Text;
                lvwNewNames.Items[selIdx - 1].SubItems[i].Text =
                lvwNewNames.Items[selIdx].SubItems[i].Text;
                lvwNewNames.Items[selIdx].SubItems[i].Text = cache;
            }
            lvwNewNames.Items[selIdx - 1].Selected = true;
            lvwNewNames.Refresh();
            lvwNewNames.Focus();
        }
        catch{
            //Do nothing
        }
    }

    private void btnMoveDown_Click(object sender, EventArgs e)
    {
        //Stolen from:
        //http://www.knowdotnet.com/articles/listviewmoveitem.html
        string cache;
        int selIdx;

        try
        {
            selIdx = lvwNewNames.SelectedItems[0].Index;
            // ignore movedown of last item
            if (selIdx == lvwNewNames.Items.Count - 1)
                return;
            // move the subitems for the next row
            // to cache so we can move the selected row down
            for (int i = 0; i < lvwNewNames.Items[selIdx].SubItems.Count; i++)
            {
                cache = lvwNewNames.Items[selIdx + 1].SubItems[i].Text;
                lvwNewNames.Items[selIdx + 1].SubItems[i].Text =
                lvwNewNames.Items[selIdx].SubItems[i].Text;
                lvwNewNames.Items[selIdx].SubItems[i].Text = cache;
            }
            lvwNewNames.Items[selIdx+1].Selected=true;
            lvwNewNames.Refresh();
            lvwNewNames.Focus();
        }
        catch
        {

        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtNewTitle.Text.Trim().Length == 0)
        {
            Program.showMessageBox("Error! New titles can't be blank.");
            return;
        }
        if(Program.ValidateSpecialChars(txtNewTitle.Text)){
            return;
        }

        ListViewItem item = new ListViewItem(txtNewTitle.Text.Trim());
        lvwNewNames.Items.Add(item);
    }

    private void txtCharCount_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            //showMessageBox("Enter pressed!");
            btnGetTitles_Click(null, null);
        }
    }

    private void txtNewTitle_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            btnAdd_Click(null, null);
            txtNewTitle.Text = "";
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            int index = lvwNewNames.SelectedIndices[0];
            if (Program.showQuestionBox("Are you sure you want to remove the title \"" + lvwNewNames.Items[index].Text + "\"?"))
            {
                lvwNewNames.Items.Remove(lvwNewNames.Items[index]);
            }
        }
        catch
        {
            //Do nothing.
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        if (lvwNewNames.Items.Count > 0)
        {
            if (!Program.showQuestionBox("Are you sure you want to clear the already existing list of titles?"))
            {
                return;
            }
        }
        lvwNewNames.Items.Clear();
    }

    private void btnMoveUpLeft_Click(object sender, EventArgs e)
    {
        //Stolen from:
        //http://www.knowdotnet.com/articles/listviewmoveitem.html
        string cache;
        int selIdx;
        try
        {
            selIdx = lvwSelectedFiles.SelectedItems[0].Index;

            // ignore moveup of row(0)
            if (selIdx == 0)
                return;

            // move the subitems for the previous row
            // to cache to make room for the selected row
            for (int i = 0; i < lvwSelectedFiles.Items[selIdx].SubItems.Count; i++)
            {
                cache = lvwSelectedFiles.Items[selIdx - 1].SubItems[i].Text;
                lvwSelectedFiles.Items[selIdx - 1].SubItems[i].Text =
                lvwSelectedFiles.Items[selIdx].SubItems[i].Text;
                lvwSelectedFiles.Items[selIdx].SubItems[i].Text = cache;
            }
            lvwSelectedFiles.Items[selIdx - 1].Selected = true;
            lvwSelectedFiles.Refresh();
            lvwSelectedFiles.Focus();
        }
        catch
        {
            //Do nothing
        }
    }

    private void btnMoveDownLeft_Click(object sender, EventArgs e)
    {
        //Stolen from:
        //http://www.knowdotnet.com/articles/listviewmoveitem.html
        string cache;
        int selIdx;

        try
        {
            selIdx = lvwSelectedFiles.SelectedItems[0].Index;
            // ignore movedown of last item
            if (selIdx == lvwSelectedFiles.Items.Count - 1)
                return;
            // move the subitems for the next row
            // to cache so we can move the selected row down
            for (int i = 0; i < lvwSelectedFiles.Items[selIdx].SubItems.Count; i++)
            {
                cache = lvwSelectedFiles.Items[selIdx + 1].SubItems[i].Text;
                lvwSelectedFiles.Items[selIdx + 1].SubItems[i].Text =
                lvwSelectedFiles.Items[selIdx].SubItems[i].Text;
                lvwSelectedFiles.Items[selIdx].SubItems[i].Text = cache;
            }
            lvwSelectedFiles.Items[selIdx + 1].Selected = true;
            lvwSelectedFiles.Refresh();
            lvwSelectedFiles.Focus();
        }
        catch
        {

        }
    }

    private void btnRemoveLeft_Click(object sender, EventArgs e)
    {
        try
        {
            int index = lvwSelectedFiles.SelectedIndices[0];
            if (Program.showQuestionBox("Are you sure you want to remove the file \"" + lvwSelectedFiles.Items[index].Text + "\" from the list?"))
            {
                lvwSelectedFiles.Items.Remove(lvwSelectedFiles.Items[index]);
            }
        }
        catch
        {
            //Do nothing.
        }
    }

    private void btnClipboardToggle_Click(object sender, EventArgs e)
    {
        //Toggle on/off
        tmrClipboardTimer.Enabled = !tmrClipboardTimer.Enabled;
        LastClipboard = Clipboard.GetText();
        if (tmrClipboardTimer.Enabled)
            btnClipboardToggle.Text = "ON";
        else
            btnClipboardToggle.Text = "OFF";
    }

    private void tmrClipboardTimer_Tick(object sender, EventArgs e)
    {
        if (LastClipboard != Clipboard.GetText())
        {
            string newClip = Clipboard.GetText();
            if (newClip != "" && newClip != null)
            {
                //Clean it up.
                newClip = newClip.Replace("\t", "");
                newClip = newClip.Replace("\n", "");
                newClip = newClip.Replace("\r", "");
                newClip = newClip.Replace("\"", "");
                newClip = newClip.Trim();

                ListViewItem item = new ListViewItem(newClip);
                lvwNewNames.Items.Add(item);
            }
            LastClipboard = Clipboard.GetText();
        }
    }

    private void btnEditTitle_Click(object sender, EventArgs e)
    {
        try
        {
            string editTitle = lvwNewNames.SelectedItems[0].Text;
            frmEdit editForm = new frmEdit(editTitle);
            editForm.ShowDialog();
            editTitle = editForm.EditingTitle;

            lvwNewNames.SelectedItems[0].Text = editTitle;
            editForm.Close();
        }
        catch
        {

        }
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
        if (txtReplace1.Text.Length == 0)
        {
            Program.showMessageBox("Error! You cannot replace a blank string.");
            return;
        }
        if (!Program.showQuestionBox("This will replace \"" + txtReplace1.Text +
                "\" with \"" + txtReplace2.Text + "\" in ALL new titles. Proceed?"))
        {
            return;
        }
        foreach (ListViewItem item in lvwNewNames.Items)
        {
            item.Text = item.Text.Replace(txtReplace1.Text, txtReplace2.Text);
        }

        txtReplace1.Text = "";
        txtReplace2.Text = "";
    }

    private void txtReplace1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            btnReplace_Click(null, null);
        }
    }

    private void txtReplace2_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            btnReplace_Click(null, null);
        }
    }
}