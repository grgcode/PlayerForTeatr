using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerForTeatr
{
    public partial class Form1 : Form
    {
        KeyboardLogger mKeyboardLogger = new KeyboardLogger();

        public Form1()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] args = Environment.GetCommandLineArgs();
                if (args.Length > 1)
                {
                    // try to load files from a folder passed as command line parameter
                    if (Directory.Exists(args[1]))
                    {
                        textBoxFolder.Text = args[1];
                        LoadList();
                    }
                    else 
                    {
                        if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                        textBoxError.Text += "Can't find/access folder: " + args[1];
                    }
                }
                checkBoxFast.Checked = true;
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFolder.Text != string.Empty && Directory.Exists(textBoxFolder.Text))
                {
                    folderBrowserDialog1.SelectedPath = textBoxFolder.Text;
                }
                else
                {
                    folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
                }
                folderBrowserDialog1.Description = "Select Folder to load mp3 files list (play list)";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxFolder.Text = folderBrowserDialog1.SelectedPath;
                    LoadList();
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void LoadList()
        {
            try
            {
                listBoxPlayList.Items.Clear();
                if (textBoxFolder.Text != string.Empty)
                {
                    string[] files = Directory.GetFiles(textBoxFolder.Text, "*.mp3");
                    foreach (string f in files)
                    {
                        listBoxPlayList.Items.Add(new PlayListItem(f));
                    }
                    if (listBoxPlayList.Items.Count > 0)
                    {
                        listBoxPlayList.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void buttonClearError_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxError.Clear();
            }
            catch { }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            selectNext();
        }

        private void selectNext()
        {
            try
            {
                if (listBoxPlayList.Items.Count > 0)
                {
                    if (listBoxPlayList.SelectedIndex == -1)
                    {
                        listBoxPlayList.SelectedIndex = 0;
                    }
                    else if (listBoxPlayList.SelectedIndex == listBoxPlayList.Items.Count - 1)
                    {
                        //listBoxPlayList.SelectedIndex = 0;
                    }
                    else
                    {
                        listBoxPlayList.SelectedIndex = listBoxPlayList.SelectedIndex + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            playSelected();
        }

        private bool playSelectedInProgress = false;
        private void playSelected()
        {
            if (playSelectedInProgress == true)
            {
                Application.DoEvents();
            }
            playSelectedInProgress = true;
            try
            {
                if (listBoxPlayList.Items.Count > 0)
                {
                    if (listBoxPlayList.SelectedIndex == -1)
                    {
                        listBoxPlayList.SelectedIndex = 0;
                    }
                    PlayListItem item = (PlayListItem)listBoxPlayList.SelectedItem;
                    axWindowsMediaPlayer1.URL = item.FullFileName;
                    listBoxPlayList.SetItemChecked(listBoxPlayList.SelectedIndex, true);
                    selectNext();
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
            finally
            {
                playSelectedInProgress = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopPlaying();
        }

        private void stopPlaying()
        {
            try
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void textBoxFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadList();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (checkBoxFast.Checked)
                {
                    //handled by HandleArrowKeys(e) in mKeyboardLogger_KeyDown event
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void HandleArrowKeys(KeyEventArgs e)
        {
                if (checkBoxFast.Checked)
                {
                    if (e.KeyCode == Keys.Down)
                    {//next
                        selectNext();
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Up)
                    {//previous
                        selectPrevious();
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Right)
                    {//play
                        playSelected();
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Left)
                    {//stop
                        stopPlaying();
                        e.Handled = true;
                    }
                }
        }

        void mKeyboardLogger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                HandleArrowKeys(e);
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }


        private void selectPrevious()
        {
            try
            {
                if (listBoxPlayList.Items.Count > 0)
                {
                    if (listBoxPlayList.SelectedIndex == -1)
                    {
                        listBoxPlayList.SelectedIndex = 0;
                    }
                    else if (listBoxPlayList.SelectedIndex == 0)
                    {
                        //listBoxPlayList.SelectedIndex = listBoxPlayList.Items.Count - 1;
                    }
                    else
                    {
                        listBoxPlayList.SelectedIndex = listBoxPlayList.SelectedIndex - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void checkBoxFast_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxFast.Checked)
                {
                    mKeyboardLogger.GregKeyDown += mKeyboardLogger_KeyDown;                   
                    mKeyboardLogger.StartKeyLogger();
                    checkBoxFast.ForeColor = Color.Red;
                    textBoxFolder.ReadOnly = true;
                    if (listBoxPlayList.CanFocus)
                    {
                        listBoxPlayList.Focus();
                    }
                }
                else
                {
                    mKeyboardLogger.StopKeyLogger();
                    checkBoxFast.ForeColor = SystemColors.ControlText;
                    textBoxFolder.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        #region drag&drop

        private string foldername = string.Empty;

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (foldername != string.Empty)
                {
                    textBoxFolder.Text = foldername;
                    foldername = string.Empty;
                    LoadList();
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                foldername = string.Empty;
                //validData = GetFilename(out filename, e);
                if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                {
                    Array data = ((IDataObject)e.Data).GetData(DataFormats.FileDrop) as Array;
                    if (data != null)
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            if (data.GetValue(i) is String)
                            {
                                string fn = ((string[])data)[i];
                                if (Directory.Exists(fn))
                                {
                                    foldername = fn;
                                    break;
                                }
                            }
                        }
                        if (foldername == string.Empty)
                        {
                            for (int i = 0; i < data.Length; i++)
                            {
                                if (data.GetValue(i) is String)
                                {
                                    string fn = ((string[])data)[i];
                                    if (File.Exists(fn))
                                    {
                                        foldername = Path.GetDirectoryName(fn);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (foldername != string.Empty)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        #endregion drag&drop

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            try
            {
                if (axWindowsMediaPlayer1.URL.Length > 0)
                {
                    labelPlay.Text = Path.GetFileNameWithoutExtension(axWindowsMediaPlayer1.URL);
                }
                else
                {
                    labelPlay.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

        private void listBoxPlayList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (e.NewValue != e.CurrentValue)
                {
                    CheckedListBox list = (CheckedListBox)sender;
                    PlayListItem item = (PlayListItem)list.SelectedItem;

                    if (e.NewValue == CheckState.Checked)
                    {
                        item.Played = true;
                    }
                    else
                    {
                        item.Played = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                //Display f as a modeless dialog
                FormHelp f = new FormHelp();
                f.Show();
            }
            catch (Exception ex)
            {
                if (textBoxError.Text != string.Empty) textBoxError.Text += "\n";
                textBoxError.Text += ex.ToString();
            }
        }

    }
}
