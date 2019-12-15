using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Weka.Code_Library;

namespace Weka.UI_Library.UI_Forms
{
    public partial class frm_login : MetroForm
    {
        Data_Repository rps = new Data_Repository();
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show(this, "Vous êtes sur le point de quitter Weka, confirmez vous votre action? ", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_user_id.Text==""||txt_paswd.Text=="")
            {
                MessageBox.Show(this, "Rassurez vous d'avoir completé le code d'utilisateur et le mot de passe corrects!", "Informations incomplètes");
            }
            else
            {
                this.Hide();
                rps.rechercher_user(txt_user_id.Text, txt_paswd.Text);

                txt_paswd.Text = "";
                txt_user_id.Text = "";
                
                
                
            }
        }
    }
}
