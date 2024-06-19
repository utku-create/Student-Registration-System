using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OgrenciKayitFormu
{
    public partial class OgrencGirisFormu : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        string TC, dogumTar, adSoyad, yasadigiIl, no, cinsiyet;
        byte TcHata, AdHata, YasHata, TelHata = 0;
        public int id;


        public OgrencGirisFormu()
        {
            InitializeComponent();
        }

        static bool TCKontrol(string text)
        {
            bool sonuc = true;
            for (int i = 0; i < text.Length; i++)

                if (!char.IsDigit(text[i]))
                    sonuc = false;
            return sonuc;
        }

        static bool TelefonNoKontrol(string text)
        {
            bool sonuc = true;
            for (int i = 0; i < text.Length; i++)

                if (!char.IsDigit(text[i]))
                    sonuc = false;
            return sonuc;
        }

        static bool AdKontrol(string text)
        {
            bool sonuc = true;
            for (int i = 0; i < text.Length; i++)

                if (!char.IsLetter(text[i]) & !char.IsWhiteSpace(text[i]))
                    sonuc = false;
            return sonuc;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtNo.Text.Length > 9 & txtNo.Text.Length < 12)
            {
                if (TelefonNoKontrol(txtNo.Text) == true)
                {
                    TelHata = 0;
                    no = txtNo.Text;
                }
                else if (TelefonNoKontrol(txtNo.Text) == false)
                {
                    TelHata = 1;
                }
            }
            else
            {
                TelHata = 1;
            }
            if (txtTCKimlik.Text.Length == 11)
            {
                if (TCKontrol(txtTCKimlik.Text) == true)
                {
                    TcHata = 0;
                    TC = txtTCKimlik.Text;
                }
            }
            else
            {
                TcHata = 1;
            }

            int sene = dtpDogumTar.Value.Year;
            int sene2 = 2023 - sene;

            if (sene2 < 18)
            {
                YasHata = 1;
            }

            else
            {
                YasHata = 0;
                dogumTar = dtpDogumTar.Text;
            }

            if (AdKontrol(txtAdSoyad.Text) == true)
            {
                AdHata = 0;
                adSoyad = txtAdSoyad.Text;
            }

            else if (AdKontrol(txtAdSoyad.Text) == false)
            {
                AdHata = 1;
            }


            yasadigiIl = cmbIller.Text;


            if (rbErkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            if (rbKadin.Checked == true)
            {
                cinsiyet = "Kadýn";
            }



            if (id != 0)
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "UP_OGRENCILER";
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@NAMESURNAME", txtAdSoyad.Text);
                        command.Parameters.AddWithValue("@TC", txtTCKimlik.Text);
                        command.Parameters.AddWithValue("@GSMNUM", txtNo.Text);
                        command.Parameters.AddWithValue("@GENDER", rbErkek.Checked == true ? 'E' : 'K');
                        command.Parameters.AddWithValue("@CITY", cmbIller.Text);
                        command.Parameters.AddWithValue("@BIRTHDATE", Convert.ToDateTime(dtpDogumTar.Text));
                        command.ExecuteNonQuery();
                    }

                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "IN_OGRENCILER";
                        command.Parameters.AddWithValue("@NAMESURNAME", txtAdSoyad.Text);
                        command.Parameters.AddWithValue("@TC", txtTCKimlik.Text);
                        command.Parameters.AddWithValue("@GSMNUM", txtNo.Text);
                        command.Parameters.AddWithValue("@GENDER", rbErkek.Checked == true ? 'E' : 'K');
                        command.Parameters.AddWithValue("@CITY", cmbIller.Text);
                        command.Parameters.AddWithValue("@BIRTHDATE", Convert.ToDateTime(dtpDogumTar.Text));
                        command.ExecuteNonQuery();
                    }

                }
            }


            MessageBox.Show("Baþarýlý", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OgrencGirisFormu_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DataTable dt = new DataTable();
                dt = GetOgrenciById(id);
                txtAdSoyad.Text = dt.Rows[0]["NAMESURNAME"].ToString();
                txtNo.Text = dt.Rows[0]["GSMNUM"].ToString();
                txtTCKimlik.Text = dt.Rows[0]["TC"].ToString();
                dtpDogumTar.Text = dt.Rows[0]["BIRTHDATE"].ToString();
                cmbIller.Text = dt.Rows[0]["CITY"].ToString();
                if (dt.Rows[0]["GENDER"].ToString() == "E")
                {
                    rbErkek.Checked = true;
                }
                else
                {
                    rbKadin.Checked = true;
                }
            }
        }

        private DataTable GetOgrenciById(int id)
        {
                DataTable dt = new DataTable();
                try
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "GETOGRENCIBYID";
                            cmd.Parameters.AddWithValue("@ID", id);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.SelectCommand = cmd;
                            da.Fill(dt);
                        }
                    }

                    return dt;
                }

                catch (Exception)
                {
                    throw;
                }
        }
    }
}