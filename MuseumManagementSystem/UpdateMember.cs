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
    
    public partial class UpdateMember : Form
    {
        public static int id;
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            panelUpdateMemberHeader.Size = new(Width, Height - 80);
            panelUpdateMemberHeader.Size = new(Width, Height - 80);
            MuseumDB.GetSelectedRowData($"SELECT * FROM Member WHERE Id = {id}",
                                        new object[] { textBoxMemberId,textBoxMemberNamee, textBoxMemberSurname, textBoxMemberTel, textBoxMemberMail, textBoxMemberImg,comboBoxMemberState },
                                        new string[] {"Id","Name", "LastName", "Telephone", "EMail", "Image","State" });
        }
        private void pictureBoxUpdateMemberExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().Show();
            Close();
        }

        private void buttonUpdateMember_Click(object sender, EventArgs e)
        {
            MuseumDB.UpdateData($"UPDATE Member SET Name = '{textBoxMemberNamee.Text}', " +
                                 $"LastName = '{textBoxMemberSurname.Text}', " +
                                 $"Telephone = '{textBoxMemberTel.Text}', " +
                                 $"EMail = '{textBoxMemberMail.Text}', " +                                 
                                 $"Image = '{textBoxMemberImg.Text}', " +
                                 $"State = {comboBoxMemberState.SelectedIndex} " +
                                 $"WHERE Id = {id}", "Üye");
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MuseumDB.DeleteData("TicketSale", "MemberId", id);
                MuseumDB.DeleteData("GetTicketBack", "MemberId", id);
                MuseumDB.DeleteData("Member", "Id", id, "Member");
                new MuseumOperation().Show();
                Close();
            }
        }
    }
}
