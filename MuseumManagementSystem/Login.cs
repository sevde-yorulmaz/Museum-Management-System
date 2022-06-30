using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MuseumManagementSystem
{
    public partial class Login : Form
    {

        private string staffName, password;
        private int staffId;
         MuseumOperation oprt = new MuseumOperation();
         
       
        public Login()
        {
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(41, 12);
            pictureBoxExit.Location = new Point(1753, 12);
            buttonLogin.Location = new Point(59, 334);           
            buttonExit.Location = new Point(187, 334);
            buttonExit.Enabled = false;     
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sistemden Çıkış Yapmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPassword.Clear();
            textBoxName.Focus();
            staffName=string.Empty;
            password = string.Empty;
            buttonLogin.Visible = true;
            textBoxName.Visible = true;
            textBoxPassword.Visible = true;
            buttonExit.Visible = false;
           
            MessageBox.Show("Çıkış İşlemi Gerçekleşti.", "MuseumDB", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {            
            staffName = textBoxName.Text;
            password = textBoxPassword.Text;
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MuseumDB.connection.Open();
                SqlCommand logincheck = new SqlCommand($"SELECT * FROM Staff WHERE Name='{staffName}' AND Password='{password}'", MuseumDB.connection);
                SqlDataReader reader = logincheck.ExecuteReader();
                if (reader.Read())  
                {
                    groupBoxLogin.Enabled = false;
                    oprt.staffId = Convert.ToInt32(reader["Id"]);
                    oprt.authorityId = Convert.ToInt32(reader["AuthorityId"]);
                    MessageBox.Show("Giriş Başarılı Bir Şekilde Gerçekleşti", "MuseumDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonExit.Visible = true;
                    buttonExit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Uyuşmamaktadır.\nTekrar Deneyiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                MuseumDB.connection.Close();                
                Hide();
                oprt.ShowDialog();              
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Eksik.\nBilgilerinizi Eksiksiz Giriniz.", "MuseumDB", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
