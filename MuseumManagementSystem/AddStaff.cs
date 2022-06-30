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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            panelAddStaffHeader.Size = new(Width, Height - 80);
            panelAddStaffContent.Size = new(Width, Height - 80);

            MuseumDB.GetData("SELECT * FROM Authority WHERE State = 1", false, false, "Authority", "Authority", "Id", null, comboBoxAuthorityStaff);

        }

        private void pictureBoxAddStaffExit_Click(object sender, EventArgs e)
        {
            new MuseumOperation().Show();
            Close();
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxStaffNamee.Text)&& string.IsNullOrWhiteSpace(textBoxStaffSurname.Text)&& string.IsNullOrWhiteSpace(textBoxStaffSalary.Text) && string.IsNullOrWhiteSpace(comboBoxAuthorityStaff.Text) &&string.IsNullOrWhiteSpace(textBoxStaffPassword.Text)&& string.IsNullOrWhiteSpace(comboBoxStaffState.Text))
            {
                MessageBox.Show("Bilgileri Eksik Giremezsiniz.", "Hata Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MuseumDB.AddData("Staff", "Name, LastName, AuthorityId, Password, Salary, State", $"'{textBoxStaffNamee.Text}','{textBoxStaffSurname.Text}',{Convert.ToInt32(comboBoxAuthorityStaff.SelectedValue)},'{textBoxStaffPassword.Text}','{Convert.ToInt32(textBoxStaffSalary.Text)}',{comboBoxStaffState.SelectedIndex}", "Staff");
            }

        }
    }
}
