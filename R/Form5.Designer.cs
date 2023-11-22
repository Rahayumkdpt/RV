namespace R
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel4 = new System.Windows.Forms.Panel();
            this.userControl51 = new R.UserControl5();
            this.userControl21 = new R.UserControl2();
            this.userControl11 = new R.UserControl1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cristal = new System.Windows.Forms.Button();
            this.delmember = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.userControl51);
            this.panel4.Controls.Add(this.userControl21);
            this.panel4.Controls.Add(this.userControl11);
            this.panel4.Location = new System.Drawing.Point(251, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 453);
            this.panel4.TabIndex = 3;
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.Color.MidnightBlue;
            this.userControl51.Location = new System.Drawing.Point(-31, -12);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(619, 484);
            this.userControl51.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.MidnightBlue;
            this.userControl21.Location = new System.Drawing.Point(3, -23);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(574, 753);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.MidnightBlue;
            this.userControl11.Location = new System.Drawing.Point(0, -12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(574, 653);
            this.userControl11.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.cristal);
            this.panel1.Controls.Add(this.delmember);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 491);
            this.panel1.TabIndex = 4;
            // 
            // cristal
            // 
            this.cristal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cristal.Location = new System.Drawing.Point(29, 360);
            this.cristal.Name = "cristal";
            this.cristal.Size = new System.Drawing.Size(166, 40);
            this.cristal.TabIndex = 5;
            this.cristal.Text = "Crystal Report";
            this.cristal.UseVisualStyleBackColor = true;
            this.cristal.Click += new System.EventHandler(this.cristal_Click);
            // 
            // delmember
            // 
            this.delmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delmember.Location = new System.Drawing.Point(30, 314);
            this.delmember.Name = "delmember";
            this.delmember.Size = new System.Drawing.Size(166, 40);
            this.delmember.TabIndex = 4;
            this.delmember.Text = "Delete Member\r\n";
            this.delmember.UseVisualStyleBackColor = true;
            this.delmember.Click += new System.EventHandler(this.delmember_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add/Delete Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "List Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(851, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button delmember;
        private UserControl5 userControl51;
        private System.Windows.Forms.Button cristal;
    }
}