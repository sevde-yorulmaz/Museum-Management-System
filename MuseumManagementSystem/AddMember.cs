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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(13, 12);
            panelAddMemberHeader.Size = new(Width, Height - 80);
            panelAddMemberContent.Size = new(Width, Height - 80);

        }

        private void pictureBoxAddMemberExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().Show();
            Close();
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxMemberNamee.Text)&& string.IsNullOrWhiteSpace(textBoxMemberSurname.Text)&&string.IsNullOrWhiteSpace(textBoxMemberTel.Text)&& string.IsNullOrWhiteSpace(textBoxMemberMail.Text) && string.IsNullOrWhiteSpace(comboBoxMemberState.Text))
            {
                MessageBox.Show("Bilgileri Eksik Giremezsiniz.", "Hata Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MuseumDB.AddData("Member", "Name, LastName, Telephone, EMail, Image, State", $"'{textBoxMemberNamee.Text}','{textBoxMemberSurname.Text}','{textBoxMemberTel.Text}','{textBoxMemberMail.Text}','{textBoxMemberImg.Text}',{comboBoxMemberState.SelectedIndex}", "Member");
            }
        }

       
    }
}
