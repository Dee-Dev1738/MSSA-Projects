namespace ModDemo4
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
            this.label1 = new System.Windows.Forms.Label();
            this.anmGrid = new System.Windows.Forms.DataGridView();
            this.grpAnm = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbladmin = new System.Windows.Forms.Label();
            this.txtbAdd = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbLN = new System.Windows.Forms.TextBox();
            this.txtbFN = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.LBLDep = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblEid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anmGrid)).BeginInit();
            this.grpAnm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anime Characters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // anmGrid
            // 
            this.anmGrid.BackgroundColor = System.Drawing.Color.Yellow;
            this.anmGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anmGrid.Location = new System.Drawing.Point(620, 66);
            this.anmGrid.Name = "anmGrid";
            this.anmGrid.RowHeadersWidth = 51;
            this.anmGrid.RowTemplate.Height = 24;
            this.anmGrid.Size = new System.Drawing.Size(564, 229);
            this.anmGrid.TabIndex = 1;
            this.anmGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.anmGrid_CellContentClick);
            // 
            // grpAnm
            // 
            this.grpAnm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpAnm.Controls.Add(this.comboBox2);
            this.grpAnm.Controls.Add(this.lbladmin);
            this.grpAnm.Controls.Add(this.txtbAdd);
            this.grpAnm.Controls.Add(this.lblAdd);
            this.grpAnm.Controls.Add(this.comboBox1);
            this.grpAnm.Controls.Add(this.txtbLN);
            this.grpAnm.Controls.Add(this.txtbFN);
            this.grpAnm.Controls.Add(this.txbID);
            this.grpAnm.Controls.Add(this.lblLN);
            this.grpAnm.Controls.Add(this.LBLDep);
            this.grpAnm.Controls.Add(this.lblFN);
            this.grpAnm.Controls.Add(this.lblEid);
            this.grpAnm.Location = new System.Drawing.Point(275, 301);
            this.grpAnm.Name = "grpAnm";
            this.grpAnm.Size = new System.Drawing.Size(646, 448);
            this.grpAnm.TabIndex = 2;
            this.grpAnm.TabStop = false;
            this.grpAnm.Text = "Anime Details";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 293);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 24);
            this.comboBox2.TabIndex = 11;
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.Location = new System.Drawing.Point(28, 304);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(179, 23);
            this.lbladmin.TabIndex = 10;
            this.lbladmin.Text = "Date Admitted";
            // 
            // txtbAdd
            // 
            this.txtbAdd.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAdd.Location = new System.Drawing.Point(226, 240);
            this.txtbAdd.Name = "txtbAdd";
            this.txtbAdd.Size = new System.Drawing.Size(197, 35);
            this.txtbAdd.TabIndex = 8;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(15, 240);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(205, 23);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Anime Show Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 353);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 31);
            this.comboBox1.TabIndex = 6;
            // 
            // txtbLN
            // 
            this.txtbLN.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLN.Location = new System.Drawing.Point(213, 166);
            this.txtbLN.Name = "txtbLN";
            this.txtbLN.Size = new System.Drawing.Size(197, 35);
            this.txtbLN.TabIndex = 5;
            // 
            // txtbFN
            // 
            this.txtbFN.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFN.Location = new System.Drawing.Point(213, 108);
            this.txtbFN.Name = "txtbFN";
            this.txtbFN.Size = new System.Drawing.Size(200, 35);
            this.txtbFN.TabIndex = 4;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(213, 29);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(197, 35);
            this.txbID.TabIndex = 3;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(28, 172);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(127, 23);
            this.lblLN.TabIndex = 3;
            this.lblLN.Text = "Last Name";
            // 
            // LBLDep
            // 
            this.LBLDep.AutoSize = true;
            this.LBLDep.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDep.Location = new System.Drawing.Point(28, 361);
            this.LBLDep.Name = "LBLDep";
            this.LBLDep.Size = new System.Drawing.Size(75, 23);
            this.LBLDep.TabIndex = 2;
            this.LBLDep.Text = "Grade";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(28, 111);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(140, 23);
            this.lblFN.TabIndex = 1;
            this.lblFN.Text = "First Name";
            // 
            // lblEid
            // 
            this.lblEid.AutoSize = true;
            this.lblEid.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEid.Location = new System.Drawing.Point(28, 35);
            this.lblEid.Name = "lblEid";
            this.lblEid.Size = new System.Drawing.Size(114, 23);
            this.lblEid.TabIndex = 0;
            this.lblEid.Text = "Anime ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1093, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(277, 88);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Character";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1112, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(258, 110);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Character";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1448, 689);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpAnm);
            this.Controls.Add(this.anmGrid);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(50, 47);
            this.Name = "Form1";
            this.Text = "Anime Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anmGrid)).EndInit();
            this.grpAnm.ResumeLayout(false);
            this.grpAnm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView anmGrid;
        private System.Windows.Forms.GroupBox grpAnm;
        private System.Windows.Forms.Label lblEid;
        private System.Windows.Forms.TextBox txtbLN;
        private System.Windows.Forms.TextBox txtbFN;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label LBLDep;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.TextBox txtbAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

