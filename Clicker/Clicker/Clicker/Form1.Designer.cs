
namespace Clicker
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
            this.label_Gold = new System.Windows.Forms.Label();
            this.textBox_Gold = new System.Windows.Forms.TextBox();
            this.button1_Click1 = new System.Windows.Forms.Button();
            this.button2_Click2 = new System.Windows.Forms.Button();
            this.button3_start = new System.Windows.Forms.Button();
            this.button4_quit = new System.Windows.Forms.Button();
            this.button_Upgrade = new System.Windows.Forms.Button();
            this.button_DealDMG = new System.Windows.Forms.Button();
            this.textBox_MonstersHP = new System.Windows.Forms.TextBox();
            this.label_MonstersHP = new System.Windows.Forms.Label();
            this.textBoxCurrentDMG = new System.Windows.Forms.TextBox();
            this.label_YourDMG = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Gold
            // 
            this.label_Gold.AutoSize = true;
            this.label_Gold.BackColor = System.Drawing.Color.Gold;
            this.label_Gold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Gold.Location = new System.Drawing.Point(12, 9);
            this.label_Gold.Name = "label_Gold";
            this.label_Gold.Size = new System.Drawing.Size(29, 13);
            this.label_Gold.TabIndex = 0;
            this.label_Gold.Text = "Gold";
            this.label_Gold.Click += new System.EventHandler(this.label_NofClicks_Click);
            // 
            // textBox_Gold
            // 
            this.textBox_Gold.Enabled = false;
            this.textBox_Gold.Location = new System.Drawing.Point(12, 41);
            this.textBox_Gold.Name = "textBox_Gold";
            this.textBox_Gold.ReadOnly = true;
            this.textBox_Gold.Size = new System.Drawing.Size(159, 20);
            this.textBox_Gold.TabIndex = 1;
            this.textBox_Gold.TextChanged += new System.EventHandler(this.textBox_Gold_TextChanged);
            // 
            // button1_Click1
            // 
            this.button1_Click1.BackColor = System.Drawing.Color.Gold;
            this.button1_Click1.Enabled = false;
            this.button1_Click1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Click1.Location = new System.Drawing.Point(40, 778);
            this.button1_Click1.Name = "button1_Click1";
            this.button1_Click1.Size = new System.Drawing.Size(131, 63);
            this.button1_Click1.TabIndex = 2;
            this.button1_Click1.Text = "Click for gold";
            this.button1_Click1.UseVisualStyleBackColor = false;
            this.button1_Click1.Click += new System.EventHandler(this.button1_Click1_Click);
            // 
            // button2_Click2
            // 
            this.button2_Click2.BackColor = System.Drawing.Color.Gold;
            this.button2_Click2.Enabled = false;
            this.button2_Click2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Click2.Location = new System.Drawing.Point(216, 778);
            this.button2_Click2.Name = "button2_Click2";
            this.button2_Click2.Size = new System.Drawing.Size(134, 63);
            this.button2_Click2.TabIndex = 3;
            this.button2_Click2.Text = "Click for gold too";
            this.button2_Click2.UseVisualStyleBackColor = false;
            this.button2_Click2.Click += new System.EventHandler(this.button2_Click2_Click);
            // 
            // button3_start
            // 
            this.button3_start.BackColor = System.Drawing.Color.YellowGreen;
            this.button3_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_start.Location = new System.Drawing.Point(1780, 908);
            this.button3_start.Name = "button3_start";
            this.button3_start.Size = new System.Drawing.Size(112, 43);
            this.button3_start.TabIndex = 4;
            this.button3_start.Text = "START!";
            this.button3_start.UseVisualStyleBackColor = false;
            this.button3_start.Click += new System.EventHandler(this.button3_start_Click);
            // 
            // button4_quit
            // 
            this.button4_quit.BackColor = System.Drawing.Color.DarkRed;
            this.button4_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_quit.Location = new System.Drawing.Point(1780, 990);
            this.button4_quit.Name = "button4_quit";
            this.button4_quit.Size = new System.Drawing.Size(112, 39);
            this.button4_quit.TabIndex = 5;
            this.button4_quit.Text = "RAGE QUIT";
            this.button4_quit.UseVisualStyleBackColor = false;
            this.button4_quit.Click += new System.EventHandler(this.button4_quit_Click);
            // 
            // button_Upgrade
            // 
            this.button_Upgrade.BackColor = System.Drawing.Color.LawnGreen;
            this.button_Upgrade.Enabled = false;
            this.button_Upgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Upgrade.Location = new System.Drawing.Point(12, 76);
            this.button_Upgrade.Name = "button_Upgrade";
            this.button_Upgrade.Size = new System.Drawing.Size(182, 61);
            this.button_Upgrade.TabIndex = 6;
            this.button_Upgrade.Text = "1000 gold DMG+1";
            this.button_Upgrade.UseVisualStyleBackColor = false;
            this.button_Upgrade.Click += new System.EventHandler(this.button_Upgrade_Click);
            // 
            // button_DealDMG
            // 
            this.button_DealDMG.BackColor = System.Drawing.Color.Crimson;
            this.button_DealDMG.Enabled = false;
            this.button_DealDMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DealDMG.Location = new System.Drawing.Point(978, 846);
            this.button_DealDMG.Name = "button_DealDMG";
            this.button_DealDMG.Size = new System.Drawing.Size(129, 66);
            this.button_DealDMG.TabIndex = 7;
            this.button_DealDMG.Text = "Attack";
            this.button_DealDMG.UseVisualStyleBackColor = false;
            this.button_DealDMG.Click += new System.EventHandler(this.button_DealDMG_Click);
            // 
            // textBox_MonstersHP
            // 
            this.textBox_MonstersHP.Enabled = false;
            this.textBox_MonstersHP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_MonstersHP.Location = new System.Drawing.Point(1092, 274);
            this.textBox_MonstersHP.Name = "textBox_MonstersHP";
            this.textBox_MonstersHP.ReadOnly = true;
            this.textBox_MonstersHP.Size = new System.Drawing.Size(100, 20);
            this.textBox_MonstersHP.TabIndex = 8;
            this.textBox_MonstersHP.TextChanged += new System.EventHandler(this.textBox_MonstersHP_TextChanged);
            // 
            // label_MonstersHP
            // 
            this.label_MonstersHP.AutoSize = true;
            this.label_MonstersHP.BackColor = System.Drawing.Color.ForestGreen;
            this.label_MonstersHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_MonstersHP.Location = new System.Drawing.Point(1127, 258);
            this.label_MonstersHP.Name = "label_MonstersHP";
            this.label_MonstersHP.Size = new System.Drawing.Size(22, 13);
            this.label_MonstersHP.TabIndex = 9;
            this.label_MonstersHP.Text = "HP";
            this.label_MonstersHP.Click += new System.EventHandler(this.label_MonstersHP_Click);
            // 
            // textBoxCurrentDMG
            // 
            this.textBoxCurrentDMG.Enabled = false;
            this.textBoxCurrentDMG.Location = new System.Drawing.Point(653, 892);
            this.textBoxCurrentDMG.Name = "textBoxCurrentDMG";
            this.textBoxCurrentDMG.ReadOnly = true;
            this.textBoxCurrentDMG.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentDMG.TabIndex = 10;
            this.textBoxCurrentDMG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_YourDMG
            // 
            this.label_YourDMG.AutoSize = true;
            this.label_YourDMG.BackColor = System.Drawing.Color.Maroon;
            this.label_YourDMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_YourDMG.Location = new System.Drawing.Point(682, 860);
            this.label_YourDMG.Name = "label_YourDMG";
            this.label_YourDMG.Size = new System.Drawing.Size(32, 13);
            this.label_YourDMG.TabIndex = 11;
            this.label_YourDMG.Text = "DMG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(923, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 463);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_YourDMG);
            this.Controls.Add(this.textBoxCurrentDMG);
            this.Controls.Add(this.label_MonstersHP);
            this.Controls.Add(this.textBox_MonstersHP);
            this.Controls.Add(this.button_DealDMG);
            this.Controls.Add(this.button_Upgrade);
            this.Controls.Add(this.button4_quit);
            this.Controls.Add(this.button3_start);
            this.Controls.Add(this.button2_Click2);
            this.Controls.Add(this.button1_Click1);
            this.Controls.Add(this.textBox_Gold);
            this.Controls.Add(this.label_Gold);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Gold;
        private System.Windows.Forms.TextBox textBox_Gold;
        private System.Windows.Forms.Button button1_Click1;
        private System.Windows.Forms.Button button2_Click2;
        private System.Windows.Forms.Button button3_start;
        private System.Windows.Forms.Button button4_quit;
        private System.Windows.Forms.Button button_Upgrade;
        private System.Windows.Forms.Button button_DealDMG;
        private System.Windows.Forms.TextBox textBox_MonstersHP;
        private System.Windows.Forms.Label label_MonstersHP;
        private System.Windows.Forms.TextBox textBoxCurrentDMG;
        private System.Windows.Forms.Label label_YourDMG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

