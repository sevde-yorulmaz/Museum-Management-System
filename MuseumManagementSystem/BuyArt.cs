using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MuseumManagementSystem
{
    public partial class BuyArt : Form

    {

        public string[] artworkcode;
      


        public BuyArt()
        {
            InitializeComponent();
        }

        private void pictureBoxAddArtWorkExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().Show();
            Close();
        }

        private void buttonAddArtWork_Click(object sender, EventArgs e)
        {
            read();
            if (string.IsNullOrWhiteSpace(textBoxArtWorkCode.Text) && string.IsNullOrWhiteSpace(textBoxArtName.Text) && string.IsNullOrWhiteSpace(textBoxArtImg.Text) && string.IsNullOrWhiteSpace(comboBoxArtworkAddStaffId.Text) && string.IsNullOrWhiteSpace(textBoxArtPrice.Text) && string.IsNullOrWhiteSpace(comboBoxArtState.Text))
            {
                MessageBox.Show("Bilgileri Eksik Giremezsiniz.", "Hata Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!artworkcode.Contains(textBoxArtWorkCode.Text))
                {
                    MuseumDB.AddData("ArtWork", "ArtWorkCode,Name,AuthorityId, Images, Price, State", $"'{textBoxArtWorkCode.Text}','{textBoxArtName.Text}',{Convert.ToInt32(comboBoxArtworkAddStaffId.SelectedValue)},'{textBoxArtImg.Text}','{Convert.ToInt32(textBoxArtPrice.Text)}',{comboBoxArtState.SelectedIndex}", "ArtWork");
                  
                }
            }
        }

        private void AddArtWork_Load(object sender, EventArgs e)
        {
            panelAddArtHeader.Size = new(Width, Height - 80);
            panelAddArtContent.Size = new(Width, Height - 80);

            MuseumDB.GetData("SELECT * FROM Authority WHERE State = 1", false, false, "Authority", "Authority", "Id", null, comboBoxArtworkAddStaffId);
        }
        public void read()
        {
            MuseumDB.connection.Open();
            SqlCommand command = new SqlCommand("select ArtWorkCode from ArtWork ", MuseumDB.connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                artworkcode = new string[] { reader["ArtWorkCode"].ToString() };                
            }
            MuseumDB.connection.Close();
        }
    }
}
