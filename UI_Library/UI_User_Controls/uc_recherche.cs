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
    public partial class uc_recherche : UserControl
    {
        Data_Repository rps = new Data_Repository();
        DataSet DS = new DataSet();
        public uc_recherche()
        {
            InitializeComponent(); refreshData();
        }
        private void refreshData()
        {
            rps.afficher_recherche_document(bunifuCustomDataGrid1);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if a file is selected in Grid
                if (bunifuCustomDataGrid1.CurrentCell == null)
                {
                    MessageBox.Show("Premièrement selectionner un fichier dans la grille de donnnées!");
                    return;
                }
                else
                {
                    int SelectedRow = bunifuCustomDataGrid1.CurrentCell.RowIndex;
                    string OriginalPath = DS.Tables[0].Rows[SelectedRow][4].ToString();
                    saveFileDialog1.FileName = OriginalPath;
                    DialogResult DR = saveFileDialog1.ShowDialog();
                    if (DR == DialogResult.OK)
                    {
                        string FileName = saveFileDialog1.FileName;
                        //Get File data from dataset row.
                        byte[] FileData = (byte[])DS.Tables["FilesStore"].Rows[SelectedRow]["FileData"];
                        //Write file data to selected file.
                        using (FileStream fs = new FileStream(FileName, FileMode.Create))
                        {
                            fs.Write(FileData, 0, FileData.Length);
                            fs.Close();
                        }
                        MessageBox.Show("Le fichier a été recupéré!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_path_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_document_partitre(bunifuCustomDataGrid1, txt_path.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
