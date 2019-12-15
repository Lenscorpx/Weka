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
using System.IO;

namespace Weka.UI_Library.UI_User_Controls
{
    public partial class uc_sauvegarde : UserControl
    {
        Data_Repository rps = new Data_Repository();
        byte[] fichier;        
        public uc_sauvegarde()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_document(bunifuCustomDataGrid1);
            rps.recuperer_categorie(cbx_categorie);
            txt_file_size.Clear();
            txt_file_type.Clear();
            txt_num_doc.Clear();
            txt_path.Clear();
            txt_titre_doc.Clear();
            cbx_categorie.Refresh();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtFilePath text box.
                txt_path.Text = dlg.FileName;
                FileInfo oFileInfo = new FileInfo(txt_path.Text);

                if (txt_path.Text != null || txt_path.Text.Length == 0)
                {
                    txt_file_size.Text = oFileInfo.Length.ToString();
                    txt_file_type.Text = Path.GetExtension(txt_path.Text);
                }
            }
        }

        private void txt_path_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_enregistrer_Click_1(object sender, EventArgs e)
        {
            if(txt_path.Text!=null)
            {
                using (var stream = new FileStream(txt_path.Text, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(stream))
                {
                    fichier = reader.ReadBytes((int)stream.Length);
                }
                rps.enregistrer_document(txt_titre_doc.Text, richTextBox1.Text, txt_path.Text, cbx_categorie.Text, Convert.ToDecimal(txt_file_size.Text), txt_file_type.Text, "CDIGOMA/003", fichier, DateTime.Now);
            }
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
