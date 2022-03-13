namespace CardDatabaseProject
{
    partial class Cardlib
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cardlib));
            this.gridMonsters = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtbCNM = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtbCMID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtbATK = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtbDEF = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtbPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnspellspage = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnMonsterPage = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnVeiwAllCards = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnaddcd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnsubmit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnupdateCD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtEdition = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnSubupdate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonsters)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMonsters
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMonsters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMonsters.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridMonsters.Location = new System.Drawing.Point(334, 41);
            this.gridMonsters.Name = "gridMonsters";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMonsters.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridMonsters.RowHeadersWidth = 51;
            this.gridMonsters.RowTemplate.Height = 24;
            this.gridMonsters.Size = new System.Drawing.Size(900, 304);
            this.gridMonsters.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1866, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printMenuItem,
            this.closeToolStripMenuItem});
            this.FileMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(52, 27);
            this.FileMenuItem.Text = "File";
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.printMenuItem.Size = new System.Drawing.Size(204, 28);
            this.printMenuItem.Text = "Print";
            this.printMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblwelcome.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(381, 348);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(779, 45);
            this.lblwelcome.TabIndex = 3;
            this.lblwelcome.Text = "Welcome! To Your Personal Card Library!!!";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1193, 557);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 8);
            this.progressBar1.TabIndex = 5;
            // 
            // txtbCNM
            // 
            this.txtbCNM.Animated = true;
            this.txtbCNM.BackColor = System.Drawing.Color.Transparent;
            this.txtbCNM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtbCNM.BorderRadius = 20;
            this.txtbCNM.BorderThickness = 2;
            this.txtbCNM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCNM.DefaultText = "";
            this.txtbCNM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbCNM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbCNM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCNM.DisabledState.Parent = this.txtbCNM;
            this.txtbCNM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCNM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbCNM.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtbCNM.FocusedState.Parent = this.txtbCNM;
            this.txtbCNM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCNM.ForeColor = System.Drawing.Color.White;
            this.txtbCNM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCNM.HoverState.Parent = this.txtbCNM;
            this.txtbCNM.Location = new System.Drawing.Point(347, 528);
            this.txtbCNM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCNM.Name = "txtbCNM";
            this.txtbCNM.PasswordChar = '\0';
            this.txtbCNM.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbCNM.PlaceholderText = "Card Name...";
            this.txtbCNM.SelectedText = "";
            this.txtbCNM.ShadowDecoration.Parent = this.txtbCNM;
            this.txtbCNM.Size = new System.Drawing.Size(231, 48);
            this.txtbCNM.TabIndex = 6;
            // 
            // txtbCMID
            // 
            this.txtbCMID.Animated = true;
            this.txtbCMID.BackColor = System.Drawing.Color.Transparent;
            this.txtbCMID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtbCMID.BorderRadius = 10;
            this.txtbCMID.BorderThickness = 2;
            this.txtbCMID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCMID.DefaultText = "";
            this.txtbCMID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbCMID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbCMID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCMID.DisabledState.Parent = this.txtbCMID;
            this.txtbCMID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCMID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbCMID.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtbCMID.FocusedState.Parent = this.txtbCMID;
            this.txtbCMID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCMID.ForeColor = System.Drawing.Color.White;
            this.txtbCMID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCMID.HoverState.Parent = this.txtbCMID;
            this.txtbCMID.Location = new System.Drawing.Point(347, 454);
            this.txtbCMID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCMID.Name = "txtbCMID";
            this.txtbCMID.PasswordChar = '\0';
            this.txtbCMID.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbCMID.PlaceholderText = "Card ID code..";
            this.txtbCMID.SelectedText = "";
            this.txtbCMID.ShadowDecoration.Parent = this.txtbCMID;
            this.txtbCMID.Size = new System.Drawing.Size(231, 48);
            this.txtbCMID.TabIndex = 7;
            // 
            // txtbATK
            // 
            this.txtbATK.Animated = true;
            this.txtbATK.BackColor = System.Drawing.Color.Transparent;
            this.txtbATK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtbATK.BorderRadius = 20;
            this.txtbATK.BorderThickness = 2;
            this.txtbATK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbATK.DefaultText = "";
            this.txtbATK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbATK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbATK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbATK.DisabledState.Parent = this.txtbATK;
            this.txtbATK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbATK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbATK.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtbATK.FocusedState.Parent = this.txtbATK;
            this.txtbATK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbATK.ForeColor = System.Drawing.Color.White;
            this.txtbATK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbATK.HoverState.Parent = this.txtbATK;
            this.txtbATK.Location = new System.Drawing.Point(675, 454);
            this.txtbATK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbATK.Name = "txtbATK";
            this.txtbATK.PasswordChar = '\0';
            this.txtbATK.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbATK.PlaceholderText = "ATK";
            this.txtbATK.SelectedText = "";
            this.txtbATK.ShadowDecoration.Parent = this.txtbATK;
            this.txtbATK.Size = new System.Drawing.Size(231, 48);
            this.txtbATK.TabIndex = 8;
            // 
            // txtbDEF
            // 
            this.txtbDEF.Animated = true;
            this.txtbDEF.BackColor = System.Drawing.Color.Transparent;
            this.txtbDEF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtbDEF.BorderRadius = 20;
            this.txtbDEF.BorderThickness = 2;
            this.txtbDEF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbDEF.DefaultText = "";
            this.txtbDEF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbDEF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbDEF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbDEF.DisabledState.Parent = this.txtbDEF;
            this.txtbDEF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbDEF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbDEF.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtbDEF.FocusedState.Parent = this.txtbDEF;
            this.txtbDEF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDEF.ForeColor = System.Drawing.Color.White;
            this.txtbDEF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbDEF.HoverState.Parent = this.txtbDEF;
            this.txtbDEF.Location = new System.Drawing.Point(675, 528);
            this.txtbDEF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbDEF.Name = "txtbDEF";
            this.txtbDEF.PasswordChar = '\0';
            this.txtbDEF.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbDEF.PlaceholderText = "DEF";
            this.txtbDEF.SelectedText = "";
            this.txtbDEF.ShadowDecoration.Parent = this.txtbDEF;
            this.txtbDEF.Size = new System.Drawing.Size(231, 48);
            this.txtbDEF.TabIndex = 9;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Animated = true;
            this.txtbPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtbPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtbPrice.BorderRadius = 20;
            this.txtbPrice.BorderThickness = 2;
            this.txtbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbPrice.DefaultText = "";
            this.txtbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPrice.DisabledState.Parent = this.txtbPrice;
            this.txtbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbPrice.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtbPrice.FocusedState.Parent = this.txtbPrice;
            this.txtbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrice.ForeColor = System.Drawing.Color.White;
            this.txtbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPrice.HoverState.Parent = this.txtbPrice;
            this.txtbPrice.Location = new System.Drawing.Point(992, 454);
            this.txtbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.PasswordChar = '\0';
            this.txtbPrice.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbPrice.PlaceholderText = "$Price";
            this.txtbPrice.SelectedText = "";
            this.txtbPrice.ShadowDecoration.Parent = this.txtbPrice;
            this.txtbPrice.Size = new System.Drawing.Size(231, 48);
            this.txtbPrice.TabIndex = 10;
            // 
            // btnspellspage
            // 
            this.btnspellspage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnspellspage.Animated = true;
            this.btnspellspage.BackColor = System.Drawing.Color.Transparent;
            this.btnspellspage.BorderRadius = 20;
            this.btnspellspage.BorderThickness = 3;
            this.btnspellspage.CheckedState.Parent = this.btnspellspage;
            this.btnspellspage.CustomImages.Parent = this.btnspellspage;
            this.btnspellspage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnspellspage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnspellspage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnspellspage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnspellspage.DisabledState.Parent = this.btnspellspage;
            this.btnspellspage.FillColor = System.Drawing.Color.Maroon;
            this.btnspellspage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspellspage.ForeColor = System.Drawing.Color.White;
            this.btnspellspage.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnspellspage.HoverState.Parent = this.btnspellspage;
            this.btnspellspage.Location = new System.Drawing.Point(1328, 217);
            this.btnspellspage.Name = "btnspellspage";
            this.btnspellspage.ShadowDecoration.Parent = this.btnspellspage;
            this.btnspellspage.Size = new System.Drawing.Size(269, 74);
            this.btnspellspage.TabIndex = 14;
            this.btnspellspage.Text = "My Spell Cards";
            this.btnspellspage.Click += new System.EventHandler(this.btnspellspage_Click);
            // 
            // btnMonsterPage
            // 
            this.btnMonsterPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonsterPage.Animated = true;
            this.btnMonsterPage.BackColor = System.Drawing.Color.Transparent;
            this.btnMonsterPage.BorderRadius = 20;
            this.btnMonsterPage.BorderThickness = 3;
            this.btnMonsterPage.CheckedState.Parent = this.btnMonsterPage;
            this.btnMonsterPage.CustomImages.Parent = this.btnMonsterPage;
            this.btnMonsterPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonsterPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonsterPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonsterPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonsterPage.DisabledState.Parent = this.btnMonsterPage;
            this.btnMonsterPage.FillColor = System.Drawing.Color.Maroon;
            this.btnMonsterPage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonsterPage.ForeColor = System.Drawing.Color.White;
            this.btnMonsterPage.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnMonsterPage.HoverState.Parent = this.btnMonsterPage;
            this.btnMonsterPage.Location = new System.Drawing.Point(1328, 347);
            this.btnMonsterPage.Name = "btnMonsterPage";
            this.btnMonsterPage.ShadowDecoration.Parent = this.btnMonsterPage;
            this.btnMonsterPage.Size = new System.Drawing.Size(269, 69);
            this.btnMonsterPage.TabIndex = 15;
            this.btnMonsterPage.Text = "My Monster Cards";
            this.btnMonsterPage.Click += new System.EventHandler(this.btnMonsterPage_Click);
            // 
            // btnVeiwAllCards
            // 
            this.btnVeiwAllCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeiwAllCards.Animated = true;
            this.btnVeiwAllCards.BackColor = System.Drawing.Color.Transparent;
            this.btnVeiwAllCards.BorderRadius = 20;
            this.btnVeiwAllCards.BorderThickness = 3;
            this.btnVeiwAllCards.CheckedState.Parent = this.btnVeiwAllCards;
            this.btnVeiwAllCards.CustomImages.Parent = this.btnVeiwAllCards;
            this.btnVeiwAllCards.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVeiwAllCards.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVeiwAllCards.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVeiwAllCards.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVeiwAllCards.DisabledState.Parent = this.btnVeiwAllCards;
            this.btnVeiwAllCards.FillColor = System.Drawing.Color.Maroon;
            this.btnVeiwAllCards.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiwAllCards.ForeColor = System.Drawing.Color.White;
            this.btnVeiwAllCards.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnVeiwAllCards.HoverState.Parent = this.btnVeiwAllCards;
            this.btnVeiwAllCards.Location = new System.Drawing.Point(1317, 86);
            this.btnVeiwAllCards.Name = "btnVeiwAllCards";
            this.btnVeiwAllCards.ShadowDecoration.Parent = this.btnVeiwAllCards;
            this.btnVeiwAllCards.Size = new System.Drawing.Size(269, 76);
            this.btnVeiwAllCards.TabIndex = 16;
            this.btnVeiwAllCards.Text = "View All My Cards";
            this.btnVeiwAllCards.Click += new System.EventHandler(this.btnVeiwAllCards_Click);
            // 
            // btnaddcd
            // 
            this.btnaddcd.BackColor = System.Drawing.Color.Transparent;
            this.btnaddcd.BorderRadius = 20;
            this.btnaddcd.BorderThickness = 3;
            this.btnaddcd.CheckedState.Parent = this.btnaddcd;
            this.btnaddcd.CustomImages.Parent = this.btnaddcd;
            this.btnaddcd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddcd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddcd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddcd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddcd.DisabledState.Parent = this.btnaddcd;
            this.btnaddcd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddcd.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcd.ForeColor = System.Drawing.Color.White;
            this.btnaddcd.HoverState.Parent = this.btnaddcd;
            this.btnaddcd.Location = new System.Drawing.Point(105, 121);
            this.btnaddcd.Name = "btnaddcd";
            this.btnaddcd.ShadowDecoration.Parent = this.btnaddcd;
            this.btnaddcd.Size = new System.Drawing.Size(158, 69);
            this.btnaddcd.TabIndex = 17;
            this.btnaddcd.Text = "Add new Card";
            this.btnaddcd.Click += new System.EventHandler(this.btnaddcd_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BorderRadius = 20;
            this.btnsubmit.BorderThickness = 3;
            this.btnsubmit.CheckedState.Parent = this.btnsubmit;
            this.btnsubmit.CustomImages.Parent = this.btnsubmit;
            this.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsubmit.DisabledState.Parent = this.btnsubmit;
            this.btnsubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsubmit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.HoverState.Parent = this.btnsubmit;
            this.btnsubmit.Location = new System.Drawing.Point(105, 239);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.ShadowDecoration.Parent = this.btnsubmit;
            this.btnsubmit.Size = new System.Drawing.Size(158, 69);
            this.btnsubmit.TabIndex = 18;
            this.btnsubmit.Text = "Submit Card";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // btnupdateCD
            // 
            this.btnupdateCD.BackColor = System.Drawing.Color.Transparent;
            this.btnupdateCD.BorderRadius = 20;
            this.btnupdateCD.BorderThickness = 3;
            this.btnupdateCD.CheckedState.Parent = this.btnupdateCD;
            this.btnupdateCD.CustomImages.Parent = this.btnupdateCD;
            this.btnupdateCD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdateCD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdateCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdateCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdateCD.DisabledState.Parent = this.btnupdateCD;
            this.btnupdateCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdateCD.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateCD.ForeColor = System.Drawing.Color.White;
            this.btnupdateCD.HoverState.Parent = this.btnupdateCD;
            this.btnupdateCD.Location = new System.Drawing.Point(105, 348);
            this.btnupdateCD.Name = "btnupdateCD";
            this.btnupdateCD.ShadowDecoration.Parent = this.btnupdateCD;
            this.btnupdateCD.Size = new System.Drawing.Size(158, 69);
            this.btnupdateCD.TabIndex = 19;
            this.btnupdateCD.Text = "Update Card";
            this.btnupdateCD.Click += new System.EventHandler(this.btnupdateCD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderThickness = 3;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(105, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(158, 69);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Card";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEdition
            // 
            this.txtEdition.Animated = true;
            this.txtEdition.BackColor = System.Drawing.Color.Transparent;
            this.txtEdition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtEdition.BorderRadius = 20;
            this.txtEdition.BorderThickness = 2;
            this.txtEdition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdition.DefaultText = "";
            this.txtEdition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdition.DisabledState.Parent = this.txtEdition;
            this.txtEdition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEdition.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtEdition.FocusedState.Parent = this.txtEdition;
            this.txtEdition.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.ForeColor = System.Drawing.Color.White;
            this.txtEdition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdition.HoverState.Parent = this.txtEdition;
            this.txtEdition.Location = new System.Drawing.Point(992, 528);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.PasswordChar = '\0';
            this.txtEdition.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdition.PlaceholderText = "Edition";
            this.txtEdition.SelectedText = "";
            this.txtEdition.ShadowDecoration.Parent = this.txtEdition;
            this.txtEdition.Size = new System.Drawing.Size(231, 48);
            this.txtEdition.TabIndex = 21;
            // 
            // btnSubupdate
            // 
            this.btnSubupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSubupdate.BorderRadius = 20;
            this.btnSubupdate.BorderThickness = 3;
            this.btnSubupdate.CheckedState.Parent = this.btnSubupdate;
            this.btnSubupdate.CustomImages.Parent = this.btnSubupdate;
            this.btnSubupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubupdate.DisabledState.Parent = this.btnSubupdate;
            this.btnSubupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubupdate.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubupdate.ForeColor = System.Drawing.Color.White;
            this.btnSubupdate.HoverState.Parent = this.btnSubupdate;
            this.btnSubupdate.Location = new System.Drawing.Point(727, 583);
            this.btnSubupdate.Name = "btnSubupdate";
            this.btnSubupdate.ShadowDecoration.Parent = this.btnSubupdate;
            this.btnSubupdate.Size = new System.Drawing.Size(158, 69);
            this.btnSubupdate.TabIndex = 22;
            this.btnSubupdate.Text = "Submit Update";
            this.btnSubupdate.Click += new System.EventHandler(this.btnSubupdate_Click);
            // 
            // Cardlib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1866, 816);
            this.Controls.Add(this.btnSubupdate);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdateCD);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnaddcd);
            this.Controls.Add(this.btnVeiwAllCards);
            this.Controls.Add(this.btnMonsterPage);
            this.Controls.Add(this.btnspellspage);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbDEF);
            this.Controls.Add(this.txtbATK);
            this.Controls.Add(this.txtbCMID);
            this.Controls.Add(this.txtbCNM);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.gridMonsters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cardlib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Database";
            this.Load += new System.EventHandler(this.Cardlib_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMonsters)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMonsters;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbCNM;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbCMID;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbATK;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbDEF;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtbPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnspellspage;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnMonsterPage;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnVeiwAllCards;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnaddcd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnsubmit;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnupdateCD;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtEdition;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSubupdate;
    }
}

