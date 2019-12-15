using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weka.Code_Library;

namespace Weka.UI_Library.UI_User_Controls
{
    public partial class uc_users : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_users()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_user(bunifuCustomDataGrid1);
            txt_noms.Clear();
            txt_password1.Clear();
            txt_password2.Clear();
            txt_userid.Clear();
            cbx_id_entreprise.Refresh();
            rps.recuperer_entreprise(cbx_id_entreprise);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_userid.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_noms.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txt_password2.Text=txt_password1.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            cbx_id_entreprise.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            if (bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString() == "Admin")
            {
                rdbtn_admin.Checked = true;
            }
            else
            {
                rdbtn_user.Checked = true;
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
