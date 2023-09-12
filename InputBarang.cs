using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInputBarang
{
    public partial class FormInputBarang : Form
    {
        public FormInputBarang()
        {
            InitializeComponent();
        }

        private async void NegaraTextBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = NegaraTextBox.Text;
            if (userInput.Length >= 3)
            {
                string apiUrl = $"https://insw-dev.ilcs.co.id/n/negara?ur_negara={userInput}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string response = await client.GetStringAsync(apiUrl);
                        // Tampilkan hasil response dalam ComboBox atau ListBox untuk pilihan negara.
                    }
                    catch (HttpRequestException ex)
                    {
                        // Handle error saat panggilan API.
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void PelabuhanTextBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = PelabuhanTextBox.Text;
            string kdNegara = GetKodeNegara(); // Implementasi GetKodeNegara() tergantung pada bagian sebelumnya.
            if (userInput.Length >= 3 && !string.IsNullOrEmpty(kdNegara))
            {
                string apiUrl = $"https://insw-dev.ilcs.co.id/n/pelabuhan?kd_negara={kdNegara}&ur_pelabuhan={userInput}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string response = await client.GetStringAsync(apiUrl);
                        // Tampilkan hasil response dalam ComboBox atau ListBox untuk pilihan pelabuhan.
                    }
                    catch (HttpRequestException ex)
                    {
                        // Handle error saat panggilan API.
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void KodeBarangTextBox_TextChanged(object sender, EventArgs e)
        {
            string kodeBarang = KodeBarangTextBox.Text;
            if (!string.IsNullOrEmpty(kodeBarang))
            {
                string previewUrl = $"https://insw-dev.ilcs.co.id/n/barang?hs_code={kodeBarang}";
                string tarifUrl = $"https://insw-dev.ilcs.co.id/n/tarif?hs_code={kodeBarang}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string previewResponse = await client.GetStringAsync(previewUrl);
                        string tarifResponse = await client.GetStringAsync(tarifUrl);

                        // Tampilkan data dari previewResponse di TextBox "Preview Barang".

                        // Parse tarifResponse untuk mendapatkan Tarif Bea Masuk.
                        float tarifBeaMasuk = ParseTarifResponse(tarifResponse);

                        // Hitung Total berdasarkan Harga dan Tarif Bea Masuk.
                        float harga;
                        if (float.TryParse(HargaTextBox.Text, out harga))
                        {
                            float total = harga * tarifBeaMasuk;
                            TotalTextBox.Text = total.ToString();
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        // Handle error saat panggilan API.
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Implementasikan ParseTarifResponse sesuai dengan format response API yang digunakan.
        private float ParseTarifResponse(string tarifResponse)
        {
            // Implementasi parsing response API untuk mendapatkan Tarif Bea Masuk.
            // Return nilai Tarif Bea Masuk yang di-parse.
            return 0.0f;
        }

        // Implementasikan GetKodeNegara sesuai dengan langkah-langkah sebelumnya.
        private string GetKodeNegara()
        {
            // Implementasi untuk mendapatkan kode negara.
            return "KODE_NEGARA"; // Gantilah dengan kode yang sesuai.
        }
    }
}
