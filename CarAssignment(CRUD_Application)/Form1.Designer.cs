namespace CarAssignment
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
            this.grdCar = new System.Windows.Forms.DataGridView();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.grpboxCarD = new System.Windows.Forms.GroupBox();
            this.btnSubUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbYear = new System.Windows.Forms.TextBox();
            this.txtbModel = new System.Windows.Forms.TextBox();
            this.txtbMake = new System.Windows.Forms.TextBox();
            this.txtbVIN = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdCar)).BeginInit();
            this.grpboxCarD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCar
            // 
            this.grdCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCar.Location = new System.Drawing.Point(33, 71);
            this.grdCar.Name = "grdCar";
            this.grdCar.RowHeadersWidth = 51;
            this.grdCar.RowTemplate.Height = 24;
            this.grdCar.Size = new System.Drawing.Size(849, 211);
            this.grdCar.TabIndex = 0;
            this.grdCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCar_CellContentClick);
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.BackColor = System.Drawing.Color.Red;
            this.lblVIN.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.Location = new System.Drawing.Point(38, 45);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(54, 31);
            this.lblVIN.TabIndex = 1;
            this.lblVIN.Text = "VIN";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Red;
            this.lblMake.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(63, 141);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(71, 31);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Red;
            this.lblModel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(143, 265);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(81, 31);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            // 
            // grpboxCarD
            // 
            this.grpboxCarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpboxCarD.BackgroundImage")));
            this.grpboxCarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpboxCarD.Controls.Add(this.btnSubUpdate);
            this.grpboxCarD.Controls.Add(this.btnSubmit);
            this.grpboxCarD.Controls.Add(this.txtbPrice);
            this.grpboxCarD.Controls.Add(this.txtbYear);
            this.grpboxCarD.Controls.Add(this.txtbModel);
            this.grpboxCarD.Controls.Add(this.txtbMake);
            this.grpboxCarD.Controls.Add(this.txtbVIN);
            this.grpboxCarD.Controls.Add(this.lblPrice);
            this.grpboxCarD.Controls.Add(this.lblYear);
            this.grpboxCarD.Controls.Add(this.lblVIN);
            this.grpboxCarD.Controls.Add(this.lblModel);
            this.grpboxCarD.Controls.Add(this.lblMake);
            this.grpboxCarD.Location = new System.Drawing.Point(12, 312);
            this.grpboxCarD.Name = "grpboxCarD";
            this.grpboxCarD.Size = new System.Drawing.Size(694, 431);
            this.grpboxCarD.TabIndex = 4;
            this.grpboxCarD.TabStop = false;
            this.grpboxCarD.Text = "Car Detail";
            // 
            // btnSubUpdate
            // 
            this.btnSubUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnSubUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubUpdate.Location = new System.Drawing.Point(326, 178);
            this.btnSubUpdate.Name = "btnSubUpdate";
            this.btnSubUpdate.Size = new System.Drawing.Size(168, 47);
            this.btnSubUpdate.TabIndex = 10;
            this.btnSubUpdate.Text = "Submit Update";
            this.btnSubUpdate.UseVisualStyleBackColor = false;
            this.btnSubUpdate.Click += new System.EventHandler(this.btnSubUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(326, 105);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(168, 47);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit Car";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.lblSubmit_Click);
            // 
            // txtbPrice
            // 
            this.txtbPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrice.Location = new System.Drawing.Point(400, 330);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(94, 30);
            this.txtbPrice.TabIndex = 9;
            // 
            // txtbYear
            // 
            this.txtbYear.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbYear.Location = new System.Drawing.Point(272, 383);
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.Size = new System.Drawing.Size(94, 30);
            this.txtbYear.TabIndex = 8;
            // 
            // txtbModel
            // 
            this.txtbModel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbModel.Location = new System.Drawing.Point(149, 314);
            this.txtbModel.Name = "txtbModel";
            this.txtbModel.Size = new System.Drawing.Size(94, 30);
            this.txtbModel.TabIndex = 8;
            // 
            // txtbMake
            // 
            this.txtbMake.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMake.Location = new System.Drawing.Point(97, 187);
            this.txtbMake.Name = "txtbMake";
            this.txtbMake.Size = new System.Drawing.Size(94, 30);
            this.txtbMake.TabIndex = 7;
            // 
            // txtbVIN
            // 
            this.txtbVIN.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVIN.Location = new System.Drawing.Point(21, 92);
            this.txtbVIN.Name = "txtbVIN";
            this.txtbVIN.Size = new System.Drawing.Size(94, 30);
            this.txtbVIN.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Red;
            this.lblPrice.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(419, 275);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 31);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Red;
            this.lblYear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(246, 349);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 31);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(731, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(972, 463);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 47);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Car";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Blue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(936, 60);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 47);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Red;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(306, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 42);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Drag Race Entry";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateCar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Location = new System.Drawing.Point(936, 145);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(168, 66);
            this.btnUpdateCar.TabIndex = 9;
            this.btnUpdateCar.Text = "Update Registered Car";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 31);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitMenu
            // 
            this.exitMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(54, 27);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 755);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpboxCarD);
            this.Controls.Add(this.grdCar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Car Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCar)).EndInit();
            this.grpboxCarD.ResumeLayout(false);
            this.grpboxCarD.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCar;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox grpboxCarD;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbYear;
        private System.Windows.Forms.TextBox txtbModel;
        private System.Windows.Forms.TextBox txtbMake;
        private System.Windows.Forms.TextBox txtbVIN;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnSubUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
    }
}

