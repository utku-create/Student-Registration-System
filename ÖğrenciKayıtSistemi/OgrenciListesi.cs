using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OgrenciKayitFormu
{
    public partial class OgrenciListesi : Form
    {
        int id;
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dgList.DataSource = GetOgrenciler();
            dgList.Columns["ID"].Visible = false;
        }

        private object GetOgrenciler()
        {
            DataTable dtTable = new DataTable();
            try
            {

                SqlConnection conn = new SqlConnection(conString);

                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GETOGRENCILER";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    da.Fill(dtTable);
                    conn.Close();
                }




                /*SqlCommand com = new SqlCommand("select * from OGRENCITABLOSU");
                com.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.SelectCommand = com;
                da.Fill(dtTable);
                conn.Close();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OgrencGirisFormu ogf = new OgrencGirisFormu();
            ogf.id = 0;
            ogf.ShowDialog();
            FillGrid();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OgrencGirisFormu okf = new OgrencGirisFormu();
            okf.id = id;
            okf.ShowDialog();
            FillGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DEL_OGRENCILER";
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            FillGrid();
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgList.Rows[dgList.CurrentRow.Index].Cells["ID"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress("yusufkayabm@gmail.com", "Solta Group");
            var toAddress = new MailAddress("utkubugrayil@gmail.com", "Yusuf Kaya");
            const string fromPassword = "bpam pakk zrpw tjie";
            const string subject = "test";
            const string body = "body";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }


        }

    }
}




