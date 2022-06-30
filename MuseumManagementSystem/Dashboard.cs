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
    public partial class Dashboard : Form
    {
        public int studentCount;
        public int adultCount;
        public int museumCardCount;

        public int saleArtCount;
        public int restoreArtCount;
        public int artCount;
        public int ticketSum;
        public int ArtSum;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)

        {
            textBoxTicketTotal.Text = MuseumDB.GetCount("Select Sum(Quantity) as 'Quantity' from TicketSale","Quantity").ToString();

            textBoxMemberTotal.Text = MuseumDB.GetCount("Select Count(Id) as 'Id' from Member", "Id").ToString();

            textBoxArtWorkTotal.Text = MuseumDB.GetCount("Select Count(Id) as 'Id' from ArtWork", "Id").ToString();

            studentCount = MuseumDB.GetCount("Select Sum(Quantity) as 'Quantity' from TicketStock where TicketCategoryId=1", "Quantity");

            adultCount = MuseumDB.GetCount("Select Sum(Quantity) as 'Quantity' from TicketStock where TicketCategoryId=2", "Quantity");

            museumCardCount = MuseumDB.GetCount("Select Sum(Quantity) as 'Quantity' from TicketStock where TicketCategoryId=3", "Quantity");

            labelStudent.Text = studentCount.ToString();
            labelAdult.Text = adultCount.ToString();
            labelMuseumCard.Text = museumCardCount.ToString();

            saleArtCount = MuseumDB.GetCount("Select Count(ArtWorkId) as 'ArtWorkId' from ArtWorkSale", "ArtWorkId");
            artCount = MuseumDB.GetCount("Select Count(Id) as 'Id' from ArtWork where State=1", "Id");
            restoreArtCount = MuseumDB.GetCount("Select Count(ArtWorkId) as 'ArtWorkId' from ArtWorkRestore", "ArtWorkId");

            label4.Text = saleArtCount.ToString();
            label3.Text = artCount.ToString();
            label2.Text = restoreArtCount.ToString();


            ticketSum = studentCount + adultCount + museumCardCount;
            panelStudent.Height = ((panelTicketCategory.Height - panel2.Height) / ticketSum * studentCount)*2;
            panelAdult.Height = ((panelTicketCategory.Height - panel2.Height) / ticketSum * adultCount)*2;
            panelMuseumCard.Height = ((panelTicketCategory.Height - panel2.Height) / ticketSum * museumCardCount)*2;


            panelStudent.Location = new Point(panelStudent.Location.X,panelTicketCategory.Height - panel2.Height - panelStudent.Height-1);
            panelAdult.Location = new Point(panelAdult.Location.X,panelTicketCategory.Height - panel2.Height - panelAdult.Height-1);
            panelMuseumCard.Location = new Point(panelMuseumCard.Location.X,panelTicketCategory.Height - panel2.Height - panelMuseumCard.Height-1);


            ArtSum = saleArtCount + artCount + restoreArtCount;
          
            panelRestoreArtWork.Width = panelArtWork.Width/ ArtSum * restoreArtCount;
            panelSaleArtWork.Width = panelArtWork.Width / ArtSum * saleArtCount;

        }

        private void buttonDashboardExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().ShowDialog();
            Close();
        }
    }
}
