namespace TP3TonyMourrah
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label_Score1 = new Label();
            label_Score2 = new Label();
            textBox_Score1 = new TextBox();
            textBox_Score2 = new TextBox();
            button_Lancer = new Button();
            label_quelJoueur = new Label();
            label_tour = new Label();
            button_arreter = new Button();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            nouvellePartieToolStripMenuItem = new ToolStripMenuItem();
            sauvegarderLesPointagesToolStripMenuItem = new ToolStripMenuItem();
            retourToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_Score1
            // 
            label_Score1.AutoSize = true;
            label_Score1.BackColor = Color.LightSteelBlue;
            label_Score1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_Score1.ForeColor = Color.RoyalBlue;
            label_Score1.Location = new Point(492, 91);
            label_Score1.Name = "label_Score1";
            label_Score1.Size = new Size(94, 35);
            label_Score1.TabIndex = 4;
            label_Score1.Text = "Score1";
            // 
            // label_Score2
            // 
            label_Score2.AutoSize = true;
            label_Score2.BackColor = Color.DarkKhaki;
            label_Score2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_Score2.ForeColor = Color.Yellow;
            label_Score2.Location = new Point(492, 171);
            label_Score2.Name = "label_Score2";
            label_Score2.Size = new Size(97, 35);
            label_Score2.TabIndex = 5;
            label_Score2.Text = "Score2";
            // 
            // textBox_Score1
            // 
            textBox_Score1.BackColor = Color.CornflowerBlue;
            textBox_Score1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox_Score1.ForeColor = Color.Black;
            textBox_Score1.Location = new Point(710, 86);
            textBox_Score1.Multiline = true;
            textBox_Score1.Name = "textBox_Score1";
            textBox_Score1.ReadOnly = true;
            textBox_Score1.Size = new Size(129, 56);
            textBox_Score1.TabIndex = 6;
            textBox_Score1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Score2
            // 
            textBox_Score2.BackColor = Color.Yellow;
            textBox_Score2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox_Score2.ForeColor = Color.Black;
            textBox_Score2.Location = new Point(710, 163);
            textBox_Score2.Multiline = true;
            textBox_Score2.Name = "textBox_Score2";
            textBox_Score2.ReadOnly = true;
            textBox_Score2.Size = new Size(129, 54);
            textBox_Score2.TabIndex = 7;
            textBox_Score2.TextAlign = HorizontalAlignment.Center;
            // 
            // button_Lancer
            // 
            button_Lancer.Font = new Font("Segoe UI Light", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            button_Lancer.ForeColor = Color.LimeGreen;
            button_Lancer.Location = new Point(92, 376);
            button_Lancer.Name = "button_Lancer";
            button_Lancer.Size = new Size(164, 39);
            button_Lancer.TabIndex = 11;
            button_Lancer.Text = "Lancer!!";
            button_Lancer.UseVisualStyleBackColor = true;
            button_Lancer.Click += button_Lancer_Click;
            // 
            // label_quelJoueur
            // 
            label_quelJoueur.AutoSize = true;
            label_quelJoueur.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_quelJoueur.Location = new Point(145, 39);
            label_quelJoueur.Name = "label_quelJoueur";
            label_quelJoueur.Size = new Size(140, 32);
            label_quelJoueur.TabIndex = 12;
            label_quelJoueur.Text = "Joueur nom";
            // 
            // label_tour
            // 
            label_tour.AutoSize = true;
            label_tour.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label_tour.Location = new Point(507, 240);
            label_tour.Name = "label_tour";
            label_tour.Size = new Size(0, 54);
            label_tour.TabIndex = 13;
            // 
            // button_arreter
            // 
            button_arreter.Font = new Font("Segoe UI Light", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            button_arreter.ForeColor = Color.Red;
            button_arreter.Location = new Point(364, 376);
            button_arreter.Name = "button_arreter";
            button_arreter.Size = new Size(148, 38);
            button_arreter.TabIndex = 14;
            button_arreter.Text = "Arrêter!!";
            button_arreter.UseVisualStyleBackColor = true;
            button_arreter.Click += button_arreter_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(899, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouvellePartieToolStripMenuItem, sauvegarderLesPointagesToolStripMenuItem, retourToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            nouvellePartieToolStripMenuItem.Size = new Size(198, 26);
            nouvellePartieToolStripMenuItem.Text = "Nouvelle partie ";
            nouvellePartieToolStripMenuItem.Click += nouvellePartieToolStripMenuItem_Click;
            // 
            // sauvegarderLesPointagesToolStripMenuItem
            // 
            sauvegarderLesPointagesToolStripMenuItem.Name = "sauvegarderLesPointagesToolStripMenuItem";
            sauvegarderLesPointagesToolStripMenuItem.Size = new Size(198, 26);
            sauvegarderLesPointagesToolStripMenuItem.Text = "Sauvegarder ";
            sauvegarderLesPointagesToolStripMenuItem.Click += sauvegarderLesPointagesToolStripMenuItem_Click;
            // 
            // retourToolStripMenuItem
            // 
            retourToolStripMenuItem.Name = "retourToolStripMenuItem";
            retourToolStripMenuItem.Size = new Size(198, 26);
            retourToolStripMenuItem.Text = "Retour";
            retourToolStripMenuItem.Click += retourToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6;
            pictureBox1.Location = new Point(158, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(291, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._61;
            pictureBox3.Location = new Point(225, 203);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(131, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button_arreter);
            Controls.Add(label_tour);
            Controls.Add(label_quelJoueur);
            Controls.Add(button_Lancer);
            Controls.Add(textBox_Score2);
            Controls.Add(textBox_Score1);
            Controls.Add(label_Score2);
            Controls.Add(label_Score1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Écran de jeu ";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Score1;
        private Label label_Score2;
        private TextBox textBox_Score1;
        private TextBox textBox_Score2;
        private Button button_Lancer;
        private Label label_quelJoueur;
        private Label label_tour;
        private Button button_arreter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private ToolStripMenuItem sauvegarderLesPointagesToolStripMenuItem;
        private ToolStripMenuItem retourToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private SaveFileDialog saveFileDialog1;
    }
}