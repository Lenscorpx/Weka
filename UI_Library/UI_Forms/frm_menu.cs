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
using Weka.UI_Library.UI_User_Controls;
using Weka.Code_Library;

namespace Weka.UI_Library.UI_Forms
{
    public partial class frm_menu : MetroForm
    {
        Cls_entreprise obj_entreprise = new Cls_entreprise();
        Cls_level_user obj_level = new Cls_level_user();
        Cls_noms obj_noms = new Cls_noms();
        Cls_user_id obj_iDuser = new Cls_user_id();
        public frm_menu()
        {
            InitializeComponent();
            afficher_accueil();
            //userID.User_ID = "Lens";// a ne pas oublier d'effacer!
            MessageBox.Show(obj_entreprise.Id_entreprise+" "+ obj_level.Level_user+" "+ obj_noms.Noms+" "+ obj_iDuser.User_ID);
            lbl_username.Text = obj_noms.Noms;
        }
        private void afficher_accueil()
        {
            var fr = new uc_accueil()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            var fr = new uc_users()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new uc_sauvegarde()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new uc_reports()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var fr = new uc_wait()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            var fr = new uc_wait()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var fr = new uc_recherche()
            {
                Size = panel3.Size
            };
            panel3.Controls.Clear();
            panel3.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show(this, "Souhaitez vous quitter l'application?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(rs==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
