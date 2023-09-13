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
            string inputNegara = NegaraTextBox.Text;
            if (inputNegara.Length >= 3)
            {
                string apiUrl = $"https://insw-dev.ilcs.co.id/n/negara?ur_negara={inputNegara}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string response = await client.GetStringAsync(apiUrl);
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void PelabuhanTextBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = PelabuhanTextBox.Text;
            string kdNegara = null
            if (userInput.Length >= 3 && !string.IsNullOrEmpty(kdNegara))
            {
                string apiUrl = $"https://insw-dev.ilcs.co.id/n/pelabuhan?kd_negara={kdNegara}&ur_pelabuhan={userInput}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string response = await client.GetStringAsync(apiUrl);
                    }
                    catch (HttpRequestException ex)
                    {
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


                        float tarifBeaMasuk = ParseTarifResponse(tarifResponse);

                        float harga;
                        if (float.TryParse(HargaTextBox.Text, out harga))
                        {
                            float total = harga * tarifBeaMasuk;
                            TotalTextBox.Text = total.ToString();
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

