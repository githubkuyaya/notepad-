using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace notepad_
{
    // ###################################
    // ##           notepad²            ##
    // ##       von Alois Marti         ##
    // ###################################

    // https://stackoverflow.com/a/9576320
    // https://stackoverflow.com/a/5613328
    // https://stackoverflow.com/a/13943010
    // http://www.open-std.org/jtc1/sc22/wg21/docs/papers/2015/p0085r0.html
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "notepad² - Unbenannt";
        }
        static bool saved;
        static string name;
        static bool IsHex;
        static bool IsOct;
        static bool IsBin;
        static bool IsDec = true;

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == true)
            {
                richTextBox1.Text = "";
                this.Text = "notepad² - " + "Unbenannt";
                openFileDialog1.FileName = "";
                saved = false;
            }
            else if (saved != true)
            {
                if (openFileDialog1.SafeFileName == "")
                {
                    name = "Unbenannt";
                }
                DialogResult dialog = MessageBox.Show("Wollen Sie Ihre Änderungen zu \"" + name + "\" speichern?", "Öffnen", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (saveFileDialog1.FileName != "")
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        richTextBox1.Text = "";
                        this.Text = "notepad² - " + name;
                        openFileDialog1.FileName = "";
                        saved = false;
                    }
                }

                else if (dialog == DialogResult.No)
                {
                    richTextBox1.Text = "";
                    this.Text = "notepad² - " + name;
                    saved = false;
                }

                else if (dialog == DialogResult.Cancel)
                {
                    saved = false;
                }
            }
        }


        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == true)
            {
                openFileDialog1.ShowDialog();
                string text = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = text;
                this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                saved = true;
            }
            else if (saved != true)
            {
                if (openFileDialog1.SafeFileName == "")
                {
                    name = "Unbenannt";
                }
                DialogResult dialog = MessageBox.Show("Wollen Sie Ihre Änderungen zu \"" + name + "\" speichern?", "Öffnen", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (saveFileDialog1.FileName != "")
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        openFileDialog1.ShowDialog();
                        string text = File.ReadAllText(openFileDialog1.FileName);
                        richTextBox1.Text = text;
                        this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                        saved = true;
                    }
                }

                else if (dialog == DialogResult.No)
                {
                    saved = false;
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (openFileDialog1.FileName != "")
                    {
                        string text = File.ReadAllText(openFileDialog1.FileName);
                        richTextBox1.Text = text;
                        this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                        saved = true;
                    }
                }

                else if (dialog == DialogResult.Cancel)
                {
                    saved = false;
                }
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
                label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                saved = true;
            }
            else if (openFileDialog1.FileName == "")
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == "")
                {
                    saved = false;
                }
                else if (saveFileDialog1.FileName != "")
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                    this.Text = "notepad² - " + Path.GetFileName(saveFileDialog1.ToString());
                    openFileDialog1.FileName = saveFileDialog1.FileName;
                    saved = true;
                }
            }
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // wenn schon ein File geöffnet wurde, sollte es im Dialog nicht angezeigt werden.
            saveFileDialog1.FileName = null;
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                this.Text = "notepad² - " + Path.GetFileName(saveFileDialog1.ToString());
                openFileDialog1.FileName = saveFileDialog1.FileName;
                saved = true;
            }
            else if (saveFileDialog1.FileName == "")
            {
                saved = false;
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            saved = false;
            if (e.Control && e.KeyCode.ToString() == "s" || e.Control && e.KeyCode.ToString() == "S")
            {
                if (openFileDialog1.FileName != "")
                {
                    System.IO.File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
                    label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                    this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                    saved = true;
                }
                else if (openFileDialog1.FileName == "")
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (saveFileDialog1.FileName != "")
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                        this.Text = "notepad² - " + Path.GetFileName(saveFileDialog1.ToString());
                        openFileDialog1.FileName = saveFileDialog1.FileName;
                        saved = true;
                    }
                }
            }
            richTextBox1.SelectionColor = Color.Black;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (openFileDialog1.SafeFileName == "")
            {
                name = "Unbenannt";
            }
            if (saved != true)
            {
                DialogResult dialog = MessageBox.Show("Wollen Sie Ihre Änderungen zu \"" + name + "\" vor dem Exit speichern?", "Exit", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                        e.Cancel = true;
                    }
                    else if (saveFileDialog1.FileName != "")
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        Application.ExitThread();
                    }
                }

                else if (dialog == DialogResult.No)
                {
                    Application.ExitThread();
                }

                else if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (saved == true)
            {
                richTextBox1.Text = "";
                this.Text = "notepad² - " + "Unbenannt";
                openFileDialog1.FileName = "";
                saved = false;
            }
            else if (saved != true)
            {
                if (openFileDialog1.SafeFileName == "")
                {
                    name = "Unbenannt";
                }
                DialogResult dialog = MessageBox.Show("Wollen Sie Ihre Änderungen zu \"" + name + "\" speichern?", "Öffnen", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (saveFileDialog1.FileName != "")
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        richTextBox1.Text = "";
                        this.Text = "notepad² - " + name;
                        openFileDialog1.FileName = "";
                        saved = false;
                    }
                }

                else if (dialog == DialogResult.No)
                {
                    richTextBox1.Text = "";
                    this.Text = "notepad² - " + name;
                    saved = false;
                }

                else if (dialog == DialogResult.Cancel)
                {
                    saved = false;
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (saved == true)
            {
                openFileDialog1.ShowDialog();
                string text = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = text;
                this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                saved = true;
            }
            else if (saved != true)
            {
                if (openFileDialog1.SafeFileName == "")
                {
                    name = "Unbenannt";
                }
                DialogResult dialog = MessageBox.Show("Wollen Sie Ihre Änderungen zu \"" + name + "\" speichern?", "Öffnen", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (saveFileDialog1.FileName != "")
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        openFileDialog1.ShowDialog();
                        string text = File.ReadAllText(openFileDialog1.FileName);
                        richTextBox1.Text = text;
                        this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                        saved = true;
                    }
                }

                else if (dialog == DialogResult.No)
                {
                    saved = false;
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName == "")
                    {
                        saved = false;
                    }
                    else if (openFileDialog1.FileName != "")
                    {
                        string text = File.ReadAllText(openFileDialog1.FileName);
                        richTextBox1.Text = text;
                        this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                        saved = true;
                    }
                }

                else if (dialog == DialogResult.Cancel)
                {
                    saved = false;
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
                label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                this.Text = "notepad² - " + openFileDialog1.SafeFileName;
                saved = true;
            }
            else if (openFileDialog1.FileName == "")
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == "")
                {
                    saved = false;
                }
                else if (saveFileDialog1.FileName != "")
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    label1.Text = "Zuletzt gespeichert um: " + DateTime.Now.ToString("HH:mm:ss");
                    this.Text = "notepad² - " + Path.GetFileName(saveFileDialog1.ToString());
                    openFileDialog1.FileName = saveFileDialog1.FileName;
                    saved = true;
                }
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, this.Font, Brushes.Black, 0, 0);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = string.Empty;
        }
        private void ausschneidenCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = string.Empty;
        }
        private void kopierenCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
            catch { MessageBox.Show("Wählen Sie einen Text aus.", "Error"); }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
            catch { MessageBox.Show("Wählen Sie einen Text aus.", "Error");  }
        }

        private void einfügenCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = richTextBox1.SelectionStart;
            string clip = Clipboard.GetText();
            richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, clip);
            i += clip.Length;
            richTextBox1.SelectionStart = i;
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            int i = richTextBox1.SelectionStart;
            string clip = Clipboard.GetText();
            richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, clip);
            i += clip.Length;
            richTextBox1.SelectionStart = i;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("notepad² ist ein freier Texteditor.\nDen Source Code ist auf GitHub erhältlich.\nFolgen Sie dem Link oder klicken Sie auf \"Hilfe -> Source Code\"\nhttps://github.com/githubkuyaya/notepad%C2%B2", "Help");
        }

        private void FindToolStripButton_Click(object sender, EventArgs e)
        {
            string suchen = Interaction.InputBox("String zum Suchen: ", "Suchen", "", 500, 300);
            if (suchen != "")
            {
                Regex search = new Regex(suchen);
                int matches = 0;
                foreach (Match match in search.Matches(richTextBox1.Text))
                {
                    richTextBox1.Select(match.Index, match.Length);
                    richTextBox1.SelectionColor = Color.Red;
                    matches++;
                }
                MessageBox.Show("Es wurden " + matches + " Übereinstimmungen gefunden", "Search");
            }
        }
        private void RegexFindToolStripButton_Click(object sender, EventArgs e)
        {
            string regsuchen = Interaction.InputBox("Regex zum Suchen: ", "Suchen", "", 500, 300);
            if (regsuchen != "")
            {
                Regex regsearch = new Regex(regsuchen);
                int matches = 0;
                foreach (Match match in regsearch.Matches(richTextBox1.Text))
                {
                    richTextBox1.Select(match.Index, match.Length);
                    richTextBox1.SelectionColor = Color.Red;
                    matches++;
                }
                MessageBox.Show("Es wurden " + matches + " Übereinstimmungen gefunden", "Regex Search");
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void zuHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDec)
            {
                char[] convert = richTextBox1.Text.ToCharArray();
                string s = "";
                for (int i = 0; i < convert.Length; i++)
                {
                    //s += "\\x" + Convert.ToByte(convert[i]).ToString("X2").ToLower();
                    s += "\\x" + Convert.ToString(convert[i], 16).PadLeft(2, '0');
                }
                richTextBox1.Text = s;
                IsDec = false;
                IsHex = true;
            }
        }

        private void inDecAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsHex && !IsBin && !IsOct && !IsDec)
            {
                string s = "";
                string[] convert = richTextBox1.Text.Replace("\\x", " ").Split(' ');
                // i = 1 wegen dem \x am Anfang
                for (int i = 1; i < convert.Length; i++)
                {
                    s += Convert.ToChar(Convert.ToUInt64(convert[i], 16));
                }
                richTextBox1.Text = s;
                IsDec = true;
                IsHex = false;
            }
            else { MessageBox.Show("Sie müssen den Text erst zu Hexadezimal umwandeln, um ihn zurückzuwandeln", "Error"); }
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/githubkuyaya/notepad%C2%B2");
        }

        private void inBinAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDec)
            {
                char[] convert = richTextBox1.Text.ToCharArray();
                string s = "";
                for (int i = 0; i < convert.Length; i++)
                {
                    s += "\\b" + Convert.ToString(convert[i], 2).PadLeft(8, '0');
                }
                richTextBox1.Text = s;
                IsDec = false;
                IsBin = true;
            }
        }

        private void inDecAnzeigenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsBin && !IsHex && !IsOct && !IsDec)
            {
                string s = "";
                string[] convert = richTextBox1.Text.Replace("\\b", " ").Split(' ');
                // i = 1 wegen dem \b am Anfang
                for (int i = 1; i < convert.Length; i++)
                {
                    s += Convert.ToChar(Convert.ToUInt64(convert[i], 2));
                }
                richTextBox1.Text = s;
                IsDec = true;
                IsBin = false;
            }
            else { MessageBox.Show("Sie müssen den Text erst zu Binär umwandeln, um ihn zurückzuwandeln", "Error"); }
        }

        private void inOktAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDec)
            {
                char[] convert = richTextBox1.Text.ToCharArray();
                string s = "";
                for (int i = 0; i < convert.Length; i++)
                {
                    s += "\\o" + Convert.ToString(convert[i], 8).PadLeft(3, '0');
                }
                richTextBox1.Text = s;
                IsDec = false;
                IsOct = true;
            }
        }

        private void inDecAnzeigenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (IsOct && !IsHex && !IsBin && !IsDec)
            {
                string s = "";
                string[] convert = richTextBox1.Text.Replace("\\o", " ").Split(' ');
                // i = 1 wegen dem \ am Anfang
                for (int i = 1; i < convert.Length; i++)
                {
                    s += Convert.ToChar(Convert.ToUInt64(convert[i], 8));
                }
                richTextBox1.Text = s;
                IsDec = true;
                IsOct = false;
            }
            else { MessageBox.Show("Sie müssen den Text erst zu Oktal umwandeln, um ihn zurückzuwandeln", "Error"); }
        }
    }
}
