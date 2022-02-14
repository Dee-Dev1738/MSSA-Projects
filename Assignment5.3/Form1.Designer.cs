namespace Assignment5._3
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
            this.btnBS = new System.Windows.Forms.Button();
            this.btnBDs = new System.Windows.Forms.Button();
            this.btnXMLS = new System.Windows.Forms.Button();
            this.btnJSONs = new System.Windows.Forms.Button();
            this.btnXMLDs = new System.Windows.Forms.Button();
            this.btnJOSNDs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbCar = new System.Windows.Forms.GroupBox();
            this.lblCyear = new System.Windows.Forms.Label();
            this.lblmake = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtbCyear = new System.Windows.Forms.TextBox();
            this.txtbCmake = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpbCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBS
            // 
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.Location = new System.Drawing.Point(66, 334);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(190, 76);
            this.btnBS.TabIndex = 0;
            this.btnBS.Text = "Serialize Binary";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnBDs
            // 
            this.btnBDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBDs.Location = new System.Drawing.Point(66, 478);
            this.btnBDs.Name = "btnBDs";
            this.btnBDs.Size = new System.Drawing.Size(190, 76);
            this.btnBDs.TabIndex = 1;
            this.btnBDs.Text = "Deserialize Binary";
            this.btnBDs.UseVisualStyleBackColor = true;
            this.btnBDs.Click += new System.EventHandler(this.btnBDs_Click);
            // 
            // btnXMLS
            // 
            this.btnXMLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLS.Location = new System.Drawing.Point(366, 343);
            this.btnXMLS.Name = "btnXMLS";
            this.btnXMLS.Size = new System.Drawing.Size(190, 76);
            this.btnXMLS.TabIndex = 2;
            this.btnXMLS.Text = "Serialize XML";
            this.btnXMLS.UseVisualStyleBackColor = true;
            this.btnXMLS.Click += new System.EventHandler(this.btnXMLS_Click);
            // 
            // btnJSONs
            // 
            this.btnJSONs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONs.Location = new System.Drawing.Point(676, 343);
            this.btnJSONs.Name = "btnJSONs";
            this.btnJSONs.Size = new System.Drawing.Size(190, 76);
            this.btnJSONs.TabIndex = 3;
            this.btnJSONs.Text = "Serialize JSON";
            this.btnJSONs.UseVisualStyleBackColor = true;
            this.btnJSONs.Click += new System.EventHandler(this.btnJSONs_Click);
            // 
            // btnXMLDs
            // 
            this.btnXMLDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLDs.Location = new System.Drawing.Point(366, 478);
            this.btnXMLDs.Name = "btnXMLDs";
            this.btnXMLDs.Size = new System.Drawing.Size(190, 76);
            this.btnXMLDs.TabIndex = 4;
            this.btnXMLDs.Text = "Dserialize XML";
            this.btnXMLDs.UseVisualStyleBackColor = true;
            this.btnXMLDs.Click += new System.EventHandler(this.btnXMLDs_Click);
            // 
            // btnJOSNDs
            // 
            this.btnJOSNDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJOSNDs.Location = new System.Drawing.Point(676, 478);
            this.btnJOSNDs.Name = "btnJOSNDs";
            this.btnJOSNDs.Size = new System.Drawing.Size(190, 76);
            this.btnJOSNDs.TabIndex = 5;
            this.btnJOSNDs.Text = "Deserialize JSON";
            this.btnJOSNDs.UseVisualStyleBackColor = true;
            this.btnJOSNDs.Click += new System.EventHandler(this.btnJOSNDs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitMenu
            // 
            this.exitMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(49, 24);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // grpbCar
            // 
            this.grpbCar.Controls.Add(this.lblCyear);
            this.grpbCar.Controls.Add(this.lblmake);
            this.grpbCar.Controls.Add(this.lblname);
            this.grpbCar.Controls.Add(this.txtbCyear);
            this.grpbCar.Controls.Add(this.txtbCmake);
            this.grpbCar.Controls.Add(this.txtCname);
            this.grpbCar.Location = new System.Drawing.Point(270, 62);
            this.grpbCar.Name = "grpbCar";
            this.grpbCar.Size = new System.Drawing.Size(340, 221);
            this.grpbCar.TabIndex = 7;
            this.grpbCar.TabStop = false;
            this.grpbCar.Text = "Car Data";
            // 
            // lblCyear
            // 
            this.lblCyear.AutoSize = true;
            this.lblCyear.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyear.Location = new System.Drawing.Point(31, 165);
            this.lblCyear.Name = "lblCyear";
            this.lblCyear.Size = new System.Drawing.Size(89, 34);
            this.lblCyear.TabIndex = 5;
            this.lblCyear.Text = "Car Year";
            this.lblCyear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmake
            // 
            this.lblmake.AutoSize = true;
            this.lblmake.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmake.Location = new System.Drawing.Point(31, 105);
            this.lblmake.Name = "lblmake";
            this.lblmake.Size = new System.Drawing.Size(98, 34);
            this.lblmake.TabIndex = 4;
            this.lblmake.Text = "Car Make";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(31, 49);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(100, 34);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Car Name";
            // 
            // txtbCyear
            // 
            this.txtbCyear.Location = new System.Drawing.Point(193, 171);
            this.txtbCyear.Name = "txtbCyear";
            this.txtbCyear.Size = new System.Drawing.Size(100, 22);
            this.txtbCyear.TabIndex = 2;
            // 
            // txtbCmake
            // 
            this.txtbCmake.Location = new System.Drawing.Point(193, 111);
            this.txtbCmake.Name = "txtbCmake";
            this.txtbCmake.Size = new System.Drawing.Size(100, 22);
            this.txtbCmake.TabIndex = 1;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(193, 55);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 22);
            this.txtCname.TabIndex = 0;
            this.txtCname.TextChanged += new System.EventHandler(this.textCname_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(971, 620);
            this.Controls.Add(this.grpbCar);
            this.Controls.Add(this.btnJOSNDs);
            this.Controls.Add(this.btnXMLDs);
            this.Controls.Add(this.btnJSONs);
            this.Controls.Add(this.btnXMLS);
            this.Controls.Add(this.btnBDs);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbCar.ResumeLayout(false);
            this.grpbCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnBDs;
        private System.Windows.Forms.Button btnXMLS;
        private System.Windows.Forms.Button btnJSONs;
        private System.Windows.Forms.Button btnXMLDs;
        private System.Windows.Forms.Button btnJOSNDs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.GroupBox grpbCar;
        private System.Windows.Forms.Label lblCyear;
        private System.Windows.Forms.Label lblmake;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtbCyear;
        private System.Windows.Forms.TextBox txtbCmake;
        private System.Windows.Forms.TextBox txtCname;
    }
}

