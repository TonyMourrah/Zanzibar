using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection.Emit;
using System.Xml.Schema;
namespace TP3TonyMourrah
{
    public partial class Form2 : Form
    {
        string nombreJoueurs;
        string premierNom;
        string deuxiemeNom;
        Partie partie;
        Thread dee;
        private const string FIN = "Merci d'avoir jouer Zanzibar : )";
        private const string BYE = "ByeBye !";
        int resultat1, resultat2, resultat3;
        string chemin = Application.StartupPath;
        private Random deAleatoire = new Random();
        string brassage = "brasser.wav";
        string arreter = "arreter.wav";

        SoundPlayer lecteur;
        SoundPlayer arret;

        public Form2(string pNombreJoueurs, string pPremierNom, string pDeuxiemeNom)
        {
            this.nombreJoueurs = pNombreJoueurs;
            this.premierNom = pPremierNom;
            this.deuxiemeNom = pDeuxiemeNom;
            InitializeComponent();
            partie = new Partie(pPremierNom, pDeuxiemeNom, int.Parse(pNombreJoueurs),
               new List<int>(), 1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_Score1.Text = premierNom;
            label_Score2.Text = deuxiemeNom;
            button_arreter.Enabled = false;
            label_tour.Text = "Tour " + partie.tourEnCours + "/6";
            label_quelJoueur.Text = partie.joueurs[0].nom;
            label_quelJoueur.ForeColor = Color.Black;


        }

        private void button_Lancer_Click(object sender, EventArgs e)
        {
            button_Lancer.Enabled = false;
            button_arreter.Enabled = true;
            lecteur = new SoundPlayer();
            lecteur.SoundLocation = chemin + "//" + brassage;
            lecteur.Play();

            dee = new Thread(t =>
            {
                try
                {
                    while (dee.IsAlive)
                    {

                        resultat1 = deAleatoire.Next(1, 6 + 1);
                        resultat2 = deAleatoire.Next(1, 6 + 1);
                        resultat3 = deAleatoire.Next(1, 6 + 1);
                        pictureBox1.ImageLocation = chemin + resultat1 + ".png";
                        pictureBox2.ImageLocation = chemin + resultat2 + ".png";
                        pictureBox3.ImageLocation = chemin + resultat3 + ".png";
                        Thread.Sleep(50);

                    }
                }
                catch (Exception ex)
                {
                }

            })
            { IsBackground = true };
            dee.Start();
        }

        private void button_arreter_Click(object sender, EventArgs e)
        {
            button_arreter.Enabled = false;
            button_Lancer.Enabled = true;
            lecteur.Stop();
            dee.Interrupt();
            arret = new SoundPlayer();
            arret.SoundLocation = chemin + "//" + arreter;
            arret.Play();
            int vPointage1 = 0;
            int vPointage2 = 0;
            int vPointage3 = 0;
            // regles du zanzibar 
            if (resultat1 == 1)
            {
                vPointage1 += 100;
            }
            else if (resultat1 == 2)
            {
                vPointage1 += 2;
            }
            else if (resultat1 == 3)
            {
                vPointage1 += 3;
            }
            else if (resultat1 == 4)
            {
                vPointage1 += 4;
            }
            else if (resultat1 == 5)
            {
                vPointage1 += 5;
            }
            else if (resultat1 == 6)
            {
                vPointage1 += 60;
            }

            if (resultat2 == 1)
            {
                vPointage2 += 100;
            }
            else if (resultat2 == 2)
            {
                vPointage2 += 2;
            }
            else if (resultat2 == 3)
            {
                vPointage2 += 3;
            }
            else if (resultat2 == 4)
            {
                vPointage2 += 4;
            }
            else if (resultat2 == 5)
            {
                vPointage2 += 5;
            }
            else if (resultat2 == 6)
            {
                vPointage2 += 60;
            }

            if (resultat3 == 1)
            {
                vPointage3 += 100;
            }
            else if (resultat3 == 2)
            {
                vPointage3 += 2;
            }
            else if (resultat3 == 3)
            {
                vPointage3 += 3;
            }
            else if (resultat3 == 4)
            {
                vPointage3 += 4;
            }
            else if (resultat3 == 5)
            {
                vPointage3 += 5;
            }
            else if (resultat3 == 6)
            {
                vPointage3 += 60;
            }
            int total = vPointage1 + vPointage2 + vPointage3;
            int indiceJoueur = partie.tourEnCours % 2; // Alterne entre 0 (joueur 1) et 1 (joueur 2)
            partie.joueurs[indiceJoueur].pointage += total;



            if (indiceJoueur == 0)
            {
                textBox_Score2.Text = partie.joueurs[indiceJoueur].ToString();
                label_quelJoueur.ForeColor = Color.Black;
            }
            else
            {
                textBox_Score1.Text = partie.joueurs[indiceJoueur].ToString();
                label_quelJoueur.ForeColor = Color.DarkSlateGray;
            }
            label_quelJoueur.Text = partie.joueurs[indiceJoueur].nom;
            partie.tourEnCours++;
            label_tour.Text = "Tour " + partie.tourEnCours + "/6";

            // Vérifie si c'est le dernier tour
            if (partie.tourEnCours > 6)
            {
                Joueur gagnant = partie.DeterminerGagnant();
                MessageBox.Show("Cette partie est terminée ! Le gagnant est " + gagnant.couleur,
                                "Merci " + premierNom + " et " + deuxiemeNom,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_Lancer.Enabled = false;
                button_arreter.Enabled = false;
                label_quelJoueur.Text = FIN;
                label_tour.Text = BYE;
            }
        }

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Lancer.Enabled = true;
            label_quelJoueur.Text = label_quelJoueur.Text = partie.joueurs[0].nom;
            partie.joueurs[0].pointage = 0;
            partie.joueurs[1].pointage = 0;
            textBox_Score1.Text = partie.joueurs[0].ToString();
            textBox_Score2.Text = partie.joueurs[1].ToString();
            partie.tourEnCours = 1;
            label_tour.Text = "Tour 1/6";
        }

        private void sauvegarderLesPointagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cheminFichier = chemin + "TableauResultat.TXT";
                try
                {
                    StreamWriter sauvegarde = new StreamWriter(cheminFichier, true);
                    sauvegarde.WriteLine(premierNom + ": " + textBox_Score1.Text );
                    sauvegarde.WriteLine(deuxiemeNom + ": " + textBox_Score2.Text);
                    sauvegarde.WriteLine("*********************************");
                    sauvegarde.Close();
                MessageBox.Show("Sauvegarde réussie !", premierNom + " et " + deuxiemeNom,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                    MessageBox.Show("Erreur : " + ex.Message, "Sauvegarde",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

