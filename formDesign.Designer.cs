namespace HBAssignment2
{
    partial class formDesign
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSaveClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToolbox = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pBoxGreenBox = new System.Windows.Forms.PictureBox();
            this.pBoxRedBox = new System.Windows.Forms.PictureBox();
            this.pBoxGreenDoor = new System.Windows.Forms.PictureBox();
            this.pBoxRedDoor = new System.Windows.Forms.PictureBox();
            this.pBoxWall = new System.Windows.Forms.PictureBox();
            this.pBoxNone = new System.Windows.Forms.PictureBox();
            this.lblNone = new System.Windows.Forms.Label();
            this.lblWall = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreenDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRedDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNone)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSaveClose
            // 
            this.menuSaveClose.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuClose});
            this.menuSaveClose.Name = "menuSaveClose";
            this.menuSaveClose.Size = new System.Drawing.Size(37, 20);
            this.menuSaveClose.Text = "File";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(103, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(103, 22);
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // lblToolbox
            // 
            this.lblToolbox.AutoSize = true;
            this.lblToolbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolbox.Location = new System.Drawing.Point(12, 78);
            this.lblToolbox.Name = "lblToolbox";
            this.lblToolbox.Size = new System.Drawing.Size(80, 24);
            this.lblToolbox.TabIndex = 1;
            this.lblToolbox.Text = "Toolbox";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(11, 29);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 13);
            this.lblRows.TabIndex = 2;
            this.lblRows.Text = "Rows";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(141, 30);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(51, 27);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(68, 20);
            this.txtRows.TabIndex = 3;
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(204, 27);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(76, 20);
            this.txtColumn.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(324, 21);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 30);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pBoxGreenBox
            // 
            this.pBoxGreenBox.BackgroundImage = global::HBAssignment2.Properties.Resources.green_box;
            this.pBoxGreenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxGreenBox.Location = new System.Drawing.Point(17, 395);
            this.pBoxGreenBox.Name = "pBoxGreenBox";
            this.pBoxGreenBox.Size = new System.Drawing.Size(74, 52);
            this.pBoxGreenBox.TabIndex = 6;
            this.pBoxGreenBox.TabStop = false;
            this.pBoxGreenBox.Tag = "greenbox";
            this.pBoxGreenBox.Click += new System.EventHandler(this.pBoxGreenBox_Click);
            // 
            // pBoxRedBox
            // 
            this.pBoxRedBox.BackgroundImage = global::HBAssignment2.Properties.Resources.red_box;
            this.pBoxRedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxRedBox.Location = new System.Drawing.Point(16, 337);
            this.pBoxRedBox.Name = "pBoxRedBox";
            this.pBoxRedBox.Size = new System.Drawing.Size(75, 52);
            this.pBoxRedBox.TabIndex = 5;
            this.pBoxRedBox.TabStop = false;
            this.pBoxRedBox.Tag = "redbox";
            this.pBoxRedBox.Click += new System.EventHandler(this.pBoxRedBox_Click);
            // 
            // pBoxGreenDoor
            // 
            this.pBoxGreenDoor.BackgroundImage = global::HBAssignment2.Properties.Resources.green_door;
            this.pBoxGreenDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxGreenDoor.Location = new System.Drawing.Point(17, 279);
            this.pBoxGreenDoor.Name = "pBoxGreenDoor";
            this.pBoxGreenDoor.Size = new System.Drawing.Size(75, 52);
            this.pBoxGreenDoor.TabIndex = 5;
            this.pBoxGreenDoor.TabStop = false;
            this.pBoxGreenDoor.Tag = "greendoor";
            this.pBoxGreenDoor.Click += new System.EventHandler(this.pBoxGreenDoor_Click);
            // 
            // pBoxRedDoor
            // 
            this.pBoxRedDoor.BackgroundImage = global::HBAssignment2.Properties.Resources.red_door;
            this.pBoxRedDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxRedDoor.Location = new System.Drawing.Point(17, 221);
            this.pBoxRedDoor.Name = "pBoxRedDoor";
            this.pBoxRedDoor.Size = new System.Drawing.Size(75, 52);
            this.pBoxRedDoor.TabIndex = 5;
            this.pBoxRedDoor.TabStop = false;
            this.pBoxRedDoor.Tag = "reddoor";
            this.pBoxRedDoor.Click += new System.EventHandler(this.pBoxRedDoor_Click);
            // 
            // pBoxWall
            // 
            this.pBoxWall.BackgroundImage = global::HBAssignment2.Properties.Resources.wall;
            this.pBoxWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxWall.Location = new System.Drawing.Point(17, 163);
            this.pBoxWall.Name = "pBoxWall";
            this.pBoxWall.Size = new System.Drawing.Size(75, 52);
            this.pBoxWall.TabIndex = 5;
            this.pBoxWall.TabStop = false;
            this.pBoxWall.Tag = "wall";
            this.pBoxWall.Click += new System.EventHandler(this.pBoxWall_Click);
            // 
            // pBoxNone
            // 
            this.pBoxNone.BackgroundImage = global::HBAssignment2.Properties.Resources.grey_square;
            this.pBoxNone.Location = new System.Drawing.Point(17, 105);
            this.pBoxNone.Name = "pBoxNone";
            this.pBoxNone.Size = new System.Drawing.Size(75, 52);
            this.pBoxNone.TabIndex = 5;
            this.pBoxNone.TabStop = false;
            this.pBoxNone.Tag = "none";
            this.pBoxNone.Click += new System.EventHandler(this.pBoxNone_Click);
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Location = new System.Drawing.Point(98, 122);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(33, 13);
            this.lblNone.TabIndex = 7;
            this.lblNone.Text = "None";
            // 
            // lblWall
            // 
            this.lblWall.AutoSize = true;
            this.lblWall.Location = new System.Drawing.Point(98, 185);
            this.lblWall.Name = "lblWall";
            this.lblWall.Size = new System.Drawing.Size(28, 13);
            this.lblWall.TabIndex = 7;
            this.lblWall.Text = "Wall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Red Door";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Green Door";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Red Box";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Green Box";
            // 
            // formDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWall);
            this.Controls.Add(this.lblNone);
            this.Controls.Add(this.pBoxGreenBox);
            this.Controls.Add(this.pBoxRedBox);
            this.Controls.Add(this.pBoxGreenDoor);
            this.Controls.Add(this.pBoxRedDoor);
            this.Controls.Add(this.pBoxWall);
            this.Controls.Add(this.pBoxNone);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblToolbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formDesign";
            this.Text = "Design";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreenDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRedDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveClose;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pBoxNone;
        private System.Windows.Forms.PictureBox pBoxWall;
        private System.Windows.Forms.PictureBox pBoxRedDoor;
        private System.Windows.Forms.PictureBox pBoxGreenDoor;
        private System.Windows.Forms.PictureBox pBoxRedBox;
        private System.Windows.Forms.PictureBox pBoxGreenBox;
        private System.Windows.Forms.Label lblNone;
        private System.Windows.Forms.Label lblWall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}