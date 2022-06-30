using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MuseumManagementSystem
{
    public partial class AddRestoreArtWork : Form
    {
        public static int id;
        public int staffId;
        public AddRestoreArtWork()
        {
            InitializeComponent();
        }

        private void AddRestoreArtWork_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12,12);
            panelRestoreArtHeader.Size = new(Width, Height - 80);
            panelRestoreArtContent.Size = new(Width, Height - 80);

            MuseumDB.GetData("SELECT * FROM Authority WHERE State = 1", false, false, "Authority", "Authority", "Id", null, comboBoxArtworkRestoreAuthorityId);
            MuseumDB.GetSelectedRowData($"SELECT * FROM ArtWork WHERE Id = {id}",
                                        new object[] { textBoxRestoreArtId,textBoxartWorkCode,textBoxArtRestoreName,comboBoxArtworkRestoreAuthorityId, textBoxArtImg, textBoxArtPrice },
                                        new string[] { "Id", "ArtWorkCode", "Name", "AuthorityId", "Images", "Price" });

        }

        private void pictureBoxUpdateMemberExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().Show();
            Close();           
        }

        private void buttonRestoreArtWork_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Restore Etmek İstiyor Musunuz?", "Restore Alma İşlemi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MuseumDB.connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = MuseumDB.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "restoreArt";
                command.Parameters.Add("artworkId", SqlDbType.Int).Value = id;
                command.Parameters.Add("artworkcode", SqlDbType.NVarChar).Value = textBoxartWorkCode.Text;
                command.Parameters.Add("staffId", SqlDbType.Int).Value = comboBoxArtworkRestoreAuthorityId.SelectedValue;
                command.Parameters.Add("name", SqlDbType.NVarChar).Value = textBoxArtRestoreName.Text;
                command.Parameters.Add("image", SqlDbType.NVarChar).Value = textBoxArtImg.Text;
                command.Parameters.Add("date", SqlDbType.Date).Value = dateTimePickerRestoreArt.Value.ToString();               
                command.Parameters.Add("price", SqlDbType.Int).Value = Convert.ToInt32(textBoxArtPrice.Text);
                command.ExecuteNonQuery();

                MuseumDB.connection.Close();
         
            }
            else
            {
                MessageBox.Show("Eser Restoreye Alma İşlemi İptal Edildi.");
            }
            MuseumDB.connection.InfoMessage += Connection_InfoMessage;
        }

        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Restore Alma İşlemi");
        }
    }
}
