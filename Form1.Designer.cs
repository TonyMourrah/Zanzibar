namespace TP3TonyMourrah
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_nomUn = new Label();
            label_nombreDeJoueurs = new Label();
            button_quitter = new Button();
            button_demarrer = new Button();
            button_pointage = new Button();
            label_titre = new Label();
            textBox_nombre = new TextBox();
            textBox_un = new TextBox();
            label_nomDeux = new Label();
            textBox_deux = new TextBox();
            pictureBox_imageJeu = new PictureBox();
            richTextBox_meilleurPointage = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_imageJeu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label_nomUn
            // 
            label_nomUn.AutoSize = true;
            label_nomUn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_nomUn.Location = new Point(17, 176);
            label_nomUn.Name = "label_nomUn";
            label_nomUn.Size = new Size(263, 31);
            label_nomUn.TabIndex = 0;
            label_nomUn.Text = "Nom du premier joueur ";
            // 
            // label_nombreDeJoueurs
            // 
            label_nombreDeJoueurs.AutoSize = true;
            label_nombreDeJoueurs.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_nombreDeJoueurs.Location = new Point(36, 110);
            label_nombreDeJoueurs.Name = "label_nombreDeJoueurs";
            label_nombreDeJoueurs.Size = new Size(218, 31);
            label_nombreDeJoueurs.TabIndex = 1;
            label_nombreDeJoueurs.Text = "Nombre de joueurs ";
            // 
            // button_quitter
            // 
            button_quitter.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button_quitter.ForeColor = Color.Red;
            button_quitter.Location = new Point(286, 399);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(225, 29);
            button_quitter.TabIndex = 2;
            button_quitter.Text = "Quitter";
            button_quitter.UseVisualStyleBackColor = true;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_demarrer
            // 
            button_demarrer.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button_demarrer.ForeColor = Color.ForestGreen;
            button_demarrer.Location = new Point(476, 339);
            button_demarrer.Name = "button_demarrer";
            button_demarrer.Size = new Size(255, 29);
            button_demarrer.TabIndex = 3;
            button_demarrer.Text = "Démarrer";
            button_demarrer.UseVisualStyleBackColor = true;
            button_demarrer.Click += button_demarrer_Click;
            // 
            // button_pointage
            // 
            button_pointage.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button_pointage.ForeColor = SystemColors.MenuHighlight;
            button_pointage.Location = new Point(36, 339);
            button_pointage.Name = "button_pointage";
            button_pointage.Size = new Size(235, 29);
            button_pointage.TabIndex = 4;
            button_pointage.Text = "Meilleur pointage";
            button_pointage.UseVisualStyleBackColor = true;
            button_pointage.Click += button_pointage_Click;
            // 
            // label_titre
            // 
            label_titre.AutoSize = true;
            label_titre.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_titre.Location = new Point(71, 30);
            label_titre.Name = "label_titre";
            label_titre.Size = new Size(166, 38);
            label_titre.TabIndex = 7;
            label_titre.Text = "ZANZIBAR";
            // 
            // textBox_nombre
            // 
            textBox_nombre.BackColor = Color.FromArgb(224, 224, 224);
            textBox_nombre.Enabled = false;
            textBox_nombre.ForeColor = SystemColors.ControlText;
            textBox_nombre.Location = new Point(305, 114);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(125, 27);
            textBox_nombre.TabIndex = 8;
            textBox_nombre.Text = "             2";
            // 
            // textBox_un
            // 
            textBox_un.Location = new Point(305, 182);
            textBox_un.Name = "textBox_un";
            textBox_un.Size = new Size(125, 27);
            textBox_un.TabIndex = 9;
            textBox_un.Validating += textBox_un_Validating;
            // 
            // label_nomDeux
            // 
            label_nomDeux.AutoSize = true;
            label_nomDeux.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_nomDeux.Location = new Point(17, 252);
            label_nomDeux.Name = "label_nomDeux";
            label_nomDeux.Size = new Size(282, 31);
            label_nomDeux.TabIndex = 10;
            label_nomDeux.Text = "Nom du deuxième joueur ";
            // 
            // textBox_deux
            // 
            textBox_deux.Location = new Point(305, 256);
            textBox_deux.Name = "textBox_deux";
            textBox_deux.Size = new Size(125, 27);
            textBox_deux.TabIndex = 11;
            textBox_deux.Validating += textBox_deux_Validating;
            // 
            // pictureBox_imageJeu
            // 
            pictureBox_imageJeu.Image = (Image)resources.GetObject("pictureBox_imageJeu.Image");
            pictureBox_imageJeu.Location = new Point(509, 12);
            pictureBox_imageJeu.Name = "pictureBox_imageJeu";
            pictureBox_imageJeu.Size = new Size(193, 176);
            pictureBox_imageJeu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_imageJeu.TabIndex = 12;
            pictureBox_imageJeu.TabStop = false;
            // 
            // richTextBox_meilleurPointage
            // 
            richTextBox_meilleurPointage.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox_meilleurPointage.Location = new Point(509, 222);
            richTextBox_meilleurPointage.Name = "richTextBox_meilleurPointage";
            richTextBox_meilleurPointage.ReadOnly = true;
            richTextBox_meilleurPointage.Size = new Size(193, 102);
            richTextBox_meilleurPointage.TabIndex = 13;
            richTextBox_meilleurPointage.Text = "";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_meilleurPointage);
            Controls.Add(pictureBox_imageJeu);
            Controls.Add(textBox_deux);
            Controls.Add(label_nomDeux);
            Controls.Add(textBox_un);
            Controls.Add(textBox_nombre);
            Controls.Add(label_titre);
            Controls.Add(button_pointage);
            Controls.Add(button_demarrer);
            Controls.Add(button_quitter);
            Controls.Add(label_nombreDeJoueurs);
            Controls.Add(label_nomUn);
            Name = "Form1";
            Text = "Écran d'accueil ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_imageJeu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nomUn;
        private Label label_nombreDeJoueurs;
        private Button button_quitter;
        private Button button_demarrer;
        private Button button_pointage;
        private Label label_titre;
        private TextBox textBox_nombre;
        private TextBox textBox_un;
        private Label label_nomDeux;
        private TextBox textBox_deux;
        private PictureBox pictureBox_imageJeu;
        private RichTextBox richTextBox_meilleurPointage;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}