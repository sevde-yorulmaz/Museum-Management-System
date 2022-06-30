using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MuseumManagementSystem
{
    public partial class MuseumOperation : Form
    {
        public int memberId, ticketId, artworkId, staffId, ticketsectionId;
        public int authorityId, price, price1, value, total, sectionprice;
        string artworkcode;

        public MuseumOperation()
        {
            InitializeComponent();
        }

        private void MuseumSystem_Load(object sender, EventArgs e)
        {
            panel4.Location = new Point(19, 7);
            tabControlMuseum.Size = new(Width, Height - 120);
            dataGridViewMember.Size = new Size(tabPageArtWork.Width, tabPageArtWork.Height - 120);
            panelMember.Size = new Size(tabPageArtWork.Width, 100);
            dataGridViewArtWork.Size = new Size(tabPageArtWork.Width, tabPageArtWork.Height - 120);

            panelArtWork.Size = new Size(tabPageArtWork.Width, 100);

            panelArtOprtHeader.Size = new Size(panelArtOprt.Width - 30, 80);
            panelArtOprtContent.Size = new Size(panelArtOprt.Width - 30, tabPageArtWork.Height - 80);
            panel2.Size = new Size(tabPageTicketOperation.Width-panel5.Width, tabPageTicketOperation.Height);
            panel1.Size = new Size(panel2.Width, panel2.Height/100*90);
            panel3.Size = new Size(panel2.Width, panel2.Height / 100 * 10);


            paneldatacontent.Size = new Size(paneldatacontent.Width, tabPageTicketOperation.Height/2);

            panel5.Size = new Size(tabPageTicketOperation.Width- panel2.Width, tabPageTicketOperation.Height/2);
            panelticketcategory.Size = new Size((tabPageTicketOperation.Width- panel2.Width)/2 , panelticketcategory.Height);

            paneldataheader.Size = new Size((tabPageTicketOperation.Width - panel2.Width) - panelticketcategory.Width, paneldataheader.Height);
           

            dataGridViewOprtArt.Size = new Size(panelArtOprt.Width + 100, panelArtOprt.Height);
            dataGridViewOprtMember.Size = new Size(panelArtOprt.Width + 100, panelArtOprt.Height);
            dataGridViewTicketSection.Size = new Size(panelArtOprt.Width + 50, panelArtOprt.Height / 2);

            if (authorityId == 1)//Müdürün ulaşabileceği tabpageler ve yapabileceği işlemler
            {
                foreach (TabPage tab in tabControlMuseum.TabPages)
                {
                    tab.Enabled = false;
                }
                (tabControlMuseum.TabPages[0] as TabPage).Enabled = true;
                (tabControlMuseum.TabPages[4] as TabPage).Enabled = true;
                buttonAddMember.Enabled = false;


            }
            else if (authorityId == 2)//Bilet Yetkilisinin ulaşabileceği tabpageler ve yapabileceği işlemler
            {
                foreach (TabPage tab in tabControlMuseum.TabPages)
                {
                    tab.Enabled = false;
                }
                (tabControlMuseum.TabPages[2] as TabPage).Enabled = true;
                (tabControlMuseum.TabPages[3] as TabPage).Enabled = true;
                buttonDashBoard.Enabled = false;

            }
            else if (authorityId == 3)//Eser Yetkilisinin ulaşabieceği tabpageler ve yapabileceği işlemler
            {
                foreach (TabPage tab in tabControlMuseum.TabPages)
                {
                    tab.Enabled = false;
                }
                (tabControlMuseum.TabPages[0] as TabPage).Enabled = true;
                (tabControlMuseum.TabPages[1] as TabPage).Enabled = true;
                (tabControlMuseum.TabPages[2] as TabPage).Enabled = true;
                (tabControlMuseum.TabPages[4] as TabPage).Enabled = true;
                (tabControlMuseum.TabPages[5] as TabPage).Enabled = true;
                buttonTicketSale.Enabled = false;
                buttonRefundTicket.Enabled = false;
                buttonDashBoard.Enabled = false;
                buttonAddStaff.Enabled = false;

            }
            else if (authorityId == 4)//Muhasebe biriminin ulaşabileceği tabpageler ve yapabileeği işlemler
            {
                buttonDashBoard.Enabled = true;
            }

            MuseumDB.GetData("SELECT Id,ArtWorkCode AS 'Eser Kodu',Name AS 'Eser Adı',AuthorityId,Images AS 'Eser Resmi',Price AS 'Eser Fiyatı',State AS 'Eser Durumu' FROM ArtWork", true, false, null, null, "ArtWork", dataGridViewOprtArt, null);

            MuseumDB.GetData("SELECT Id,Name AS 'Üye Adı',LastName AS 'Üye Soyadı',Telephone AS 'Üye TelNo',EMail AS 'Üye Mail',Image AS 'Üye Resmi',State AS 'Üye Durumu' FROM Member", true, false, null, null, "Member", dataGridViewOprtMember, null);

            MuseumDB.GetData("SELECT Id,Name AS 'Bölüm Adı',Price AS 'Bölüm Fiyatı' FROM TicketSection", true, false, null, null, "Member", dataGridViewTicketSection, null);

            MuseumDB.GetData("SELECT Id,Name AS 'Üye Adı',LastName AS 'Üye Soyadı',Telephone AS 'Üye TelNo',EMail AS 'Üye Mail',Image AS 'Üye Resmi',State AS 'Üye Durumu' FROM Member", true, false, null, null, "Member", dataGridViewMemberOprt, null);

            MuseumDB.GetData("SELECT Id,Name AS 'Bilet Türü',Price AS 'Bilet Fiyatı' FROM TicketCategory", true, false, null, null, "TicketCategory", dataGridViewTicketCategory, null);

            MuseumDB.GetData("SELECT Id,ArtWorkCode AS 'Eser Kodu',Name AS 'Eser Adı',AuthorityId,Images AS 'Eser Resmi',Price AS 'Eser Fiyatı',State AS 'Eser Durumu' FROM ArtWork where State=0", true, false, null, null, "ArtWork", dataGridViewRestore, null);
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();

        }
        private void dataGridViewMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMember.id = (int)dataGridViewMember.CurrentRow.Cells["Id"].Value;
            Hide();
            new UpdateMember().ShowDialog();
        }

        private void buttonSearchMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMemberName.Text) && string.IsNullOrWhiteSpace(textBoxMemberLastName.Text) && string.IsNullOrWhiteSpace(textBoxMemberTel.Text) && string.IsNullOrWhiteSpace(textBoxMemberEmail.Text))
            {
                MessageBox.Show("Arama Yapmak için En Az Bir Bilgi Girilmesi Gerekmektir.", "Hata Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MuseumDB.GetData("SELECT Member.Id,Member.Name AS 'Üye Adı' ,Member.LastName AS 'Üye Soyad',Member.Telephone AS 'Üye Telefon',Member.EMail AS 'Üye Mail',Member.Image AS 'Üye Fotoğrafı',Member.State AS 'Üye Durumu' FROM Member WHERE Member.Name='" + textBoxMemberName.Text + "'", true, true, "Member", null, null, dataGridViewMember, null);
            }
        }

        private void buttonListMember_Click(object sender, EventArgs e)
        {
            MuseumDB.GetData("SELECT Id,Name AS 'Üye Adı',LastName AS 'Üye Soyadı',Telephone AS 'Üye TelNo',EMail AS 'Üye Mail',Image AS 'Üye Resmi',State AS 'Üye Durumu' FROM Member", true, false, null, null, "Member", dataGridViewMember, null);
        }
        private void buttonSearchArt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxArtName.Text))
            {
                MessageBox.Show("Arama Yapmak için Bilgi Girilmesi Gerekmektir.", "Hata Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MuseumDB.GetData("SELECT ArtWork.Id,ArtWork.ArtWorkCode AS 'Eser Kodu',ArtWork.Name AS 'Eser Adı' ,ArtWork.AuthorityId,ArtWork.Images AS 'Eser Resmi',ArtWork.Price AS 'Eser Fiyatı',ArtWork.State AS 'Eser Durumu' FROM ArtWork WHERE ArtWork.Name='" + textBoxArtName.Text + "'", true, true, "ArtWork", null, null, dataGridViewArtWork, null);
            }
        }
        private void Clear(DataGridView dataGridView, Control[] controls)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            foreach (Control control in controls)
            {
                control.Text = "";
            }
        }

        private void buttonDeleteArt_Click(object sender, EventArgs e)
        {
            Clear(dataGridViewArtWork, new Control[] { textBoxArtName });
        }

        private void buttonListArt_Click(object sender, EventArgs e)
        {
            MuseumDB.GetData("SELECT Id,ArtWorkCode AS 'Eser Kodu',Name AS 'Eser Adı',AuthorityId,Images AS 'Eser Resmi',Price AS 'Eser Fiyatı',State AS 'Eser Durumu' FROM ArtWork", true, false, null, null, "ArtWork", dataGridViewArtWork, null);
        }

        private void dataGridViewOprtArt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxArtNamee.Text = dataGridViewOprtArt.CurrentRow.Cells["Eser Adı"].Value.ToString();
            artworkId = Convert.ToInt32(dataGridViewOprtArt.CurrentRow.Cells["Id"].Value);
            authorityId = Convert.ToInt32(dataGridViewOprtArt.CurrentRow.Cells["AuthorityId"].Value);
            artworkcode = dataGridViewOprtArt.CurrentRow.Cells["Eser Kodu"].Value.ToString();
            labelPrice.Text = "Fiyat:" + dataGridViewOprtArt.CurrentRow.Cells["Eser Fiyatı"].Value.ToString();
            price = Convert.ToInt32(dataGridViewOprtArt.CurrentRow.Cells["Eser Fiyatı"].Value);
            DateTime dateTime = new DateTime();
            dateTime = dateTimePickerArt.Value;

        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            Hide();
            new AddStaff().ShowDialog();

        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            Hide();
            new AddMember().ShowDialog();
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            Clear(dataGridViewMember, new Control[] { textBoxMemberName });
        }

        private void buttonTicketSale_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Bilet Almak İstiyor Musunuz?", "Bilet Alma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MuseumDB.connection.Open();

                value = Convert.ToInt32(numericUpDownTicketQuantity.Value);
                total = Convert.ToInt32((price1 * value) + (sectionprice * value));
                labeltotalPrice.Text = total.ToString();

                SqlCommand command = new SqlCommand();
                command.Connection = MuseumDB.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SaleTicket";
                command.Parameters.Add("authorityId", SqlDbType.Int).Value = authorityId;
                command.Parameters.Add("staffId", SqlDbType.Int).Value = staffId;
                command.Parameters.Add("memberId", SqlDbType.Int).Value = memberId;
                command.Parameters.Add("ticketCategoryId", SqlDbType.Int).Value = ticketId;
                command.Parameters.Add("ticketSectionId", SqlDbType.Int).Value = ticketsectionId;
                command.Parameters.Add("givedate", SqlDbType.Date).Value = dateTimePickerTicket.Value.ToString();
                command.Parameters.Add("quantity", SqlDbType.Int).Value = value;
                command.Parameters.Add("price", SqlDbType.Int).Value = total;
                command.ExecuteNonQuery();
                MessageBox.Show("Bilet Satma İşlemi Gerçekleşti.\n\n" + textBoxTicketCategory.Text + " " + "Adlı Bilet" + " " + textBoxMemberNam.Text + " " + "Idli Üyeye" + " " + labeltotalPrice.Text + "Fiyata Satılmıştır.");

                textBoxTicketCategory.Clear();
                textBoxMemberNam.Clear();
                textBoxticketSection.Clear();
                numericUpDownTicketQuantity.Value = 1;
                memberId = 0;
                ticketsectionId = 0;
                ticketId = 0;
                MuseumDB.connection.Close();

            }
            else
            {
                MessageBox.Show("Bilet Alma İşlemi İptal Edildi.");
            }
            MuseumDB.connection.InfoMessage += Connection_InfoMessage;
        }

        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Bilet Alma İşlemi");
        }

        private void buttonRefundTicket_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Bileti İade Etmek İstiyor Musunuz?", "Bilet İade İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                MuseumDB.connection.Open();
                value = Convert.ToInt32(numericUpDownTicketQuantity.Value);
                total = Convert.ToInt32((price1 * value) + (sectionprice * value));
                labeltotalPrice.Text = total.ToString();

                SqlCommand command = new SqlCommand();
                command.Connection = MuseumDB.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TicketBack";
                command.Parameters.Add("authorityId", SqlDbType.Int).Value = authorityId;
                command.Parameters.Add("staffId", SqlDbType.Int).Value = staffId;
                command.Parameters.Add("memberId", SqlDbType.Int).Value = memberId;
                command.Parameters.Add("ticketCategoryId", SqlDbType.Int).Value = ticketId;
                command.Parameters.Add("ticketSectionId", SqlDbType.Int).Value = ticketsectionId;
                command.Parameters.Add("backdate", SqlDbType.Date).Value = dateTimePickerTicket.Value.ToString();
                command.Parameters.Add("quantity", SqlDbType.Int).Value = value;
                command.Parameters.Add("price", SqlDbType.Int).Value = total;
                command.ExecuteNonQuery();
                MessageBox.Show("Bilet İade İşlemi Gerçekleşti.\n\n" + textBoxTicketCategory.Text + " " + "Adlı Bilet" + " " + textBoxMemberNam.Text + " " + "Adlı Üyeden" + " " + labeltotalPrice.Text + "Ücrete Geri Alınmıştır.");

                textBoxTicketCategory.Clear();
                textBoxMemberNam.Clear();
                textBoxticketSection.Clear();
                numericUpDownTicketQuantity.Value = 1;
                memberId = 0;
                ticketsectionId = 0;
                ticketId = 0;
                MuseumDB.connection.Close();


            }
            else
            {
                MessageBox.Show("Bilet İade İşlemi İptal Edildi.");
            }
            MuseumDB.connection.InfoMessage += Connection_InfoMessage2;
        }

        private void Connection_InfoMessage2(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Bilet İade İşlemi");
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            Hide();
            new Dashboard().ShowDialog();
        }

        private void Connection_InfoMessage3(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Restoreden Çıkarma İşlemi");
        }

        private void dataGridViewRestore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            artworkcode = dataGridViewRestore.CurrentRow.Cells["Eser Kodu"].Value.ToString();
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Restoreden Çıkarmak İstiyor Musunuz?", "Restoreden Çıkarma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MuseumDB.connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = MuseumDB.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "restoreBackArt";
                command.Parameters.Add("artworkcode", SqlDbType.NVarChar).Value = artworkcode;
                command.Parameters.Add("staffId", SqlDbType.Int).Value = staffId;

                command.ExecuteNonQuery();

                MessageBox.Show("Eser Restoreden Çıkarılmıştır.");

                MuseumDB.connection.Close();

            }
            else
            {
                MessageBox.Show("Restoreden Çıkarma İşlemi İptal Edildi.");
            }
            MuseumDB.connection.InfoMessage += Connection_InfoMessage3;
        }

        private void dataGridViewTicketCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTicketCategory.Text = dataGridViewTicketCategory.CurrentRow.Cells["Bilet Türü"].Value.ToString();
            ticketId = Convert.ToInt32(dataGridViewTicketCategory.CurrentRow.Cells["Id"].Value);
            DateTime time = new DateTime();
            time = dateTimePickerTicket.Value.Date;
            labelPriceTicket.Text = "Fiyat:" + dataGridViewTicketCategory.CurrentRow.Cells["Bilet Fiyatı"].Value.ToString();
            price1 = Convert.ToInt32(dataGridViewTicketCategory.CurrentRow.Cells["Bilet Fiyatı"].Value.ToString());
        }

        private void buttonBuyArt_Click(object sender, EventArgs e)
        {
            Hide();
            new BuyArt().Show();
        }

        private void dataGridViewArtWork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddRestoreArtWork.id = (int)dataGridViewArtWork.CurrentRow.Cells["Id"].Value;
            Hide();
            new AddRestoreArtWork().Show();
        }

        private void dataGridViewMemberOprt_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMemberNam.Text = dataGridViewMemberOprt.CurrentRow.Cells["Üye Adı"].Value.ToString();
            memberId = Convert.ToInt32(dataGridViewMemberOprt.CurrentRow.Cells["Id"].Value);
        }


        private void dataGridViewTicketSection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketsectionId = Convert.ToInt32(dataGridViewTicketSection.CurrentRow.Cells["Id"].Value);
            labelSectionPrice.Text = "Fiyat:" + dataGridViewTicketSection.CurrentRow.Cells["Bölüm Fiyatı"].Value.ToString();
            sectionprice = Convert.ToInt32(dataGridViewTicketSection.CurrentRow.Cells["Bölüm Fiyatı"].Value);
            textBoxticketSection.Text = dataGridViewTicketSection.CurrentRow.Cells["Bölüm Adı"].Value.ToString();
        }

        private void buttonSaleTicketAndArtShow_Click(object sender, EventArgs e)
        {
            Hide();
            new Show_Sale_ArtWork_And_Sale_Ticket().Show();
        }

        private void dataGridViewOprtMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMemberNamee.Text = dataGridViewOprtMember.CurrentRow.Cells["Üye Adı"].Value.ToString();
            memberId = Convert.ToInt32(dataGridViewOprtMember.CurrentRow.Cells["Id"].Value);
        }

        private void buttonArtWorkSale_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Eser Almak İstiyor Musunuz?Eseri Satın Alırsanız Geri İade Edemezsiniz.", "Eser Satma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MuseumDB.connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = MuseumDB.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SaleArt";
                command.Parameters.Add("artworkcode", SqlDbType.NVarChar).Value = artworkcode;
                command.Parameters.Add("staffId", SqlDbType.Int).Value = staffId;
                command.Parameters.Add("artworkId", SqlDbType.Int).Value = artworkId;
                command.Parameters.Add("memberId", SqlDbType.Int).Value = memberId;
                command.Parameters.Add("name", SqlDbType.NVarChar).Value = textBoxArtNamee.Text;
                command.Parameters.Add("date", SqlDbType.DateTime).Value = dateTimePickerArt.Value.ToString();
                command.Parameters.Add("price", SqlDbType.Int).Value = price;
                command.ExecuteNonQuery();

                MessageBox.Show("Eser Satma İşlemi Gerçekleşti.\n\n" + textBoxArtNamee.Text + " " + "Adlı Eser" + " " + textBoxMemberNamee.Text + " " + "Idli Üyeden" + " " + labelPrice.Text + "Fiyata" + dateTimePickerArt.Value.ToString() + " Tarihinde Satılmıştır."); ;
                textBoxArtNamee.Clear();
                textBoxMemberNamee.Clear();
                memberId = 0;
                artworkId = 0;
                staffId = 0;
                MuseumDB.connection.Close();
            }
            else
            {
                MessageBox.Show("Eser Satma İşlemi İptal Edildi.");
            }
            MuseumDB.connection.InfoMessage += Connection_InfoMessage1;
        }

        private void Connection_InfoMessage1(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Eser Satma İşlemi");
        }
    }
}
