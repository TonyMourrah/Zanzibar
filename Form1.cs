using System.Media;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TP3TonyMourrah
{
    public partial class Form1 : Form
    {
        string meilleur = "wow.wav";
        SoundPlayer meilleurPoin;
        public Form1()
        {
            InitializeComponent();
        }
        private const string INVALIDE = "ce champ est obligatoire !!";
        string chemin = Application.StartupPath;
        private void textBox_un_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_un.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_un, INVALIDE);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox_deux_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_deux.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(textBox_deux, INVALIDE);
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_demarrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_un.Text) &&
                 !string.IsNullOrWhiteSpace(textBox_deux.Text)
                 )
            {
                Form2 ecranDeJeu =
            new Form2(textBox_nombre.Text, textBox_un.Text, textBox_deux.Text);
                ecranDeJeu.ShowDialog();
            }
        }

        private void button_pointage_Click(object sender, EventArgs e)
        {
            meilleurPoin = new SoundPlayer();
            meilleurPoin.SoundLocation = chemin + "//" + meilleur;
            meilleurPoin.Play();
            richTextBox_meilleurPointage.Clear();
            try
            {
                List<Joueur> joueurs = new List<Joueur>();
                StreamReader lecteur = new StreamReader("TableauResultat.TXT");
                {
                    while (!lecteur.EndOfStream)
                    {
                        string ligne = lecteur.ReadLine();
                        if (!string.IsNullOrWhiteSpace(ligne) && ligne.Contains(":"))
                        {
                            string[] elements = ligne.Split(':');
                            if (elements.Length == 2)
                            {
                                // avant le : cest le nom du joueur 
                                string nomJoueur = elements[0].Trim();
                                // apres le : cest le pointage 
                                string pointageEnChaine = elements[1].Trim();

                                joueurs.Add(new Joueur(nomJoueur, "Couleur", int.Parse(pointageEnChaine)));

                            }
                        }
                    }
                }
                List<Joueur> top3 = new List<Joueur>();
                List<Joueur> joueursTrier = joueurs.ToList();
                for (int i = 0; i < joueursTrier.Count - 1; i++)
                {
                    for (int j = i + 1; j < joueursTrier.Count; j++)
                    {
                        if (joueursTrier[j].pointage > joueursTrier[i].pointage)
                        {

                            Joueur temporaire = joueursTrier[i];
                            joueursTrier[i] = joueursTrier[j];
                            joueursTrier[j] = temporaire;
                        }
                    }
                }
                for (int i = 0; i < Math.Min(3, joueursTrier.Count); i++)
                {
                    top3.Add(joueursTrier[i]);
                }
                richTextBox_meilleurPointage.Text = "Top 3 Joueurs :\n";

                for (int i = 0; i < top3.Count; i++)
                {
                    richTextBox_meilleurPointage.Text +=
            (i + 1) + ". " + top3[i].nom + " - " + top3[i].pointage + " points\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur de gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox_meilleurPointage.Clear();
        }

    }
}
