
namespace notepad_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ausschneidenCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.hexadezimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zuHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDecAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binärToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inBinAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDecAnzeigenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oktalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOktAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDecAnzeigenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FindToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.RegexFindToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(0, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 399);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripDropDownButton1.Text = "Datei";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen...";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.speichernToolStripMenuItem.Text = "Speichern (Ctrl + S)";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter...";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausschneidenCtrlXToolStripMenuItem,
            this.kopierenCtrlCToolStripMenuItem,
            this.einfügenCtrlVToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(76, 22);
            this.toolStripDropDownButton2.Text = "Bearbeiten";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // ausschneidenCtrlXToolStripMenuItem
            // 
            this.ausschneidenCtrlXToolStripMenuItem.Name = "ausschneidenCtrlXToolStripMenuItem";
            this.ausschneidenCtrlXToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ausschneidenCtrlXToolStripMenuItem.Text = "Ausschneiden (Ctrl + X)";
            this.ausschneidenCtrlXToolStripMenuItem.Click += new System.EventHandler(this.ausschneidenCtrlXToolStripMenuItem_Click);
            // 
            // kopierenCtrlCToolStripMenuItem
            // 
            this.kopierenCtrlCToolStripMenuItem.Name = "kopierenCtrlCToolStripMenuItem";
            this.kopierenCtrlCToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.kopierenCtrlCToolStripMenuItem.Text = "Kopieren (Ctrl + C)";
            this.kopierenCtrlCToolStripMenuItem.Click += new System.EventHandler(this.kopierenCtrlCToolStripMenuItem_Click);
            // 
            // einfügenCtrlVToolStripMenuItem
            // 
            this.einfügenCtrlVToolStripMenuItem.Name = "einfügenCtrlVToolStripMenuItem";
            this.einfügenCtrlVToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.einfügenCtrlVToolStripMenuItem.Text = "Einfügen (Ctrl + V)";
            this.einfügenCtrlVToolStripMenuItem.Click += new System.EventHandler(this.einfügenCtrlVToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexadezimalToolStripMenuItem,
            this.binärToolStripMenuItem,
            this.oktalToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(99, 22);
            this.toolStripDropDownButton3.Text = "Zahlensysteme";
            this.toolStripDropDownButton3.ToolTipText = "Zahlensysteme";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // hexadezimalToolStripMenuItem
            // 
            this.hexadezimalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zuHexToolStripMenuItem,
            this.inDecAnzeigenToolStripMenuItem});
            this.hexadezimalToolStripMenuItem.Name = "hexadezimalToolStripMenuItem";
            this.hexadezimalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hexadezimalToolStripMenuItem.Text = "Hexadezimal...";
            // 
            // zuHexToolStripMenuItem
            // 
            this.zuHexToolStripMenuItem.Name = "zuHexToolStripMenuItem";
            this.zuHexToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.zuHexToolStripMenuItem.Text = "In Hex anzeigen";
            this.zuHexToolStripMenuItem.Click += new System.EventHandler(this.zuHexToolStripMenuItem_Click);
            // 
            // inDecAnzeigenToolStripMenuItem
            // 
            this.inDecAnzeigenToolStripMenuItem.Name = "inDecAnzeigenToolStripMenuItem";
            this.inDecAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.inDecAnzeigenToolStripMenuItem.Text = "In Dec anzeigen";
            this.inDecAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.inDecAnzeigenToolStripMenuItem_Click);
            // 
            // binärToolStripMenuItem
            // 
            this.binärToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inBinAnzeigenToolStripMenuItem,
            this.inDecAnzeigenToolStripMenuItem1});
            this.binärToolStripMenuItem.Name = "binärToolStripMenuItem";
            this.binärToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.binärToolStripMenuItem.Text = "Binär...";
            // 
            // inBinAnzeigenToolStripMenuItem
            // 
            this.inBinAnzeigenToolStripMenuItem.Name = "inBinAnzeigenToolStripMenuItem";
            this.inBinAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.inBinAnzeigenToolStripMenuItem.Text = "In Bin anzeigen";
            this.inBinAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.inBinAnzeigenToolStripMenuItem_Click);
            // 
            // inDecAnzeigenToolStripMenuItem1
            // 
            this.inDecAnzeigenToolStripMenuItem1.Name = "inDecAnzeigenToolStripMenuItem1";
            this.inDecAnzeigenToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.inDecAnzeigenToolStripMenuItem1.Text = "In Dec anzeigen";
            this.inDecAnzeigenToolStripMenuItem1.Click += new System.EventHandler(this.inDecAnzeigenToolStripMenuItem1_Click);
            // 
            // oktalToolStripMenuItem
            // 
            this.oktalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inOktAnzeigenToolStripMenuItem,
            this.inDecAnzeigenToolStripMenuItem2});
            this.oktalToolStripMenuItem.Name = "oktalToolStripMenuItem";
            this.oktalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.oktalToolStripMenuItem.Text = "Oktal";
            // 
            // inOktAnzeigenToolStripMenuItem
            // 
            this.inOktAnzeigenToolStripMenuItem.Name = "inOktAnzeigenToolStripMenuItem";
            this.inOktAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.inOktAnzeigenToolStripMenuItem.Text = "In Okt anzeigen";
            this.inOktAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.inOktAnzeigenToolStripMenuItem_Click);
            // 
            // inDecAnzeigenToolStripMenuItem2
            // 
            this.inDecAnzeigenToolStripMenuItem2.Name = "inDecAnzeigenToolStripMenuItem2";
            this.inDecAnzeigenToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.inDecAnzeigenToolStripMenuItem2.Text = "In Dec anzeigen";
            this.inDecAnzeigenToolStripMenuItem2.Click += new System.EventHandler(this.inDecAnzeigenToolStripMenuItem2_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceCodeToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton4.Text = "Hilfe";
            this.toolStripDropDownButton4.ToolTipText = "Hilfe";
            this.toolStripDropDownButton4.Click += new System.EventHandler(this.toolStripDropDownButton4_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.FindToolStripButton,
            this.RegexFindToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FindToolStripButton
            // 
            this.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FindToolStripButton.Image")));
            this.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindToolStripButton.Name = "FindToolStripButton";
            this.FindToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FindToolStripButton.Text = "Search";
            this.FindToolStripButton.Click += new System.EventHandler(this.FindToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RegexFindToolStripButton
            // 
            this.RegexFindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RegexFindToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RegexFindToolStripButton.Image")));
            this.RegexFindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegexFindToolStripButton.Name = "RegexFindToolStripButton";
            this.RegexFindToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RegexFindToolStripButton.Text = "Regex Search";
            this.RegexFindToolStripButton.Click += new System.EventHandler(this.RegexFindToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "notepad²";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem kopierenCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfügenCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton FindToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem hexadezimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zuHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDecAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binärToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inBinAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDecAnzeigenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oktalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOktAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDecAnzeigenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton RegexFindToolStripButton;
    }
}

