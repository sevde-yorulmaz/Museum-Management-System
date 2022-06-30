using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MuseumManagementSystem
{
    class MuseumDB
    {
        public static SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MuseumDb;Integrated Security=True");

        public static void GetData(string query, bool IsTable, bool SendDataMessage, string tableName,string displayMember,string valueMember, DataGridView dataGridView, ComboBox comboBox)
        {
            connection.Open();
            if (IsTable)
            {
                DataTable dataTable = new();
                SqlDataAdapter sqlDataAdapter = new(query, connection);
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

                if (SendDataMessage)
                {
                    switch (dataTable.Rows.Count)
                    {
                        case 0:
                            MessageBox.Show("Veri Kaydı Bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        default:
                            MessageBox.Show(+dataTable.Rows.Count + "adet veri kaydı bulunmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            else
            {

                DataTable dataTable = new(tableName);
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);

                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.SelectedIndex = -1;

            }
            connection.Close();
        }
        public static void DeleteData(string tableName, string columns, int value, string dataType = null)
        {
            connection.Open();
            SqlCommand command = new($"DELETE FROM {tableName} WHERE {columns}={value}", connection);
            command.ExecuteNonQuery();
            if (dataType != null)
            {
                MessageBox.Show($"{dataType} silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
        public static void GetSelectedRowData(string query, object[] controls, object[] values)
        {
            connection.Open();

            SqlCommand command = new(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 0; i < controls.Length; i++)
                {
                    if (controls[i] is TextBox)
                    {
                        (controls[i] as TextBox).Text = reader[(string)values[i]].ToString();
                    }                   
                    else if (controls[i] is ComboBox)
                    {
                        if ((controls[i] as ComboBox).Name.Contains("State"))
                        {
                            (controls[i] as ComboBox).SelectedIndex = Convert.ToInt32(reader[(string)values[i]]);
                        }
                        else
                        {
                            (controls[i] as ComboBox).SelectedValue = reader[(string)values[i]].ToString();
                        }
                    }
                }
            }

            connection.Close();
        }
        public static void AddData(string tableName, string columns, string values, string dataType = null)
        {
            connection.Open();

            SqlCommand query = new($"INSERT INTO {tableName} ({columns}) VALUES ({values})", connection);
            query.ExecuteNonQuery();

            if (dataType != null)
                MessageBox.Show($"{dataType} eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        public static void UpdateData(string query, string dataType)
        {
            connection.Open();

            SqlCommand command = new(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show($"{dataType} güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }
        public static int GetCount(string query,string columnName)
        {
            int dataNumber=0;
            
            MuseumDB.connection.Open();
            SqlCommand command = new SqlCommand(query, MuseumDB.connection);

            SqlDataReader readData = command.ExecuteReader();

            if (readData.Read())
            {
                dataNumber=(int)(readData[columnName]);
            }

            MuseumDB.connection.Close();
            
            return dataNumber;
        }
       
    }
   
}
