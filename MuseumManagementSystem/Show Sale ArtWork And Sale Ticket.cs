using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumManagementSystem
{
    public partial class Show_Sale_ArtWork_And_Sale_Ticket : Form
    {
        public Show_Sale_ArtWork_And_Sale_Ticket()
        {
            InitializeComponent();
        }

        private void Show_Sale_ArtWork_And_Sale_Ticket_Load(object sender, EventArgs e)
        {
            panelShowHeader.Size = new Size(this.Width, 80);
            panelShowContent.Size = new Size(this.Width, this.Height - 80);

            MuseumDB.GetData("Select Id,ArtWorkCode AS 'Eser Kodu',ArtWorkId,StaffId,MemberId,Name AS 'Eser Adı',GiveDate AS 'Satılma Tarihi',Price AS 'Satış Fiyatı' FROM ArtWorkSale", true, false, null, null, "ArtWorkSale", dataGridViewSaleArt, null);

            MuseumDB.GetData("Select Id,AuthorityId,MemberId,TicketCategoryId,TicketSectionId,GiveDate AS 'Satılma Tarihi',Quantity AS 'Adet',Price AS 'Fiyatı' From TicketSale", true, false, null, null, "TicketSale", dataGridViewSaleTicket, null);
           
        }

        private void pictureBoxAddArtWorkExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().Show();
            Close();
        }

    }
}
