using Newtonsoft.Json;
using ooap4.Models;
using OOAP4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Root Root;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dolgota_double = double.Parse(dolgota.Text);
            var shirota_double = double.Parse(lonBox.Text);
            var YaApi = new YaApi();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Yandex-API-Key", "f525e4a0-5fd3-4395-a2fa-0df5ff1bc78c");
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.weather.yandex.ru/v2/forecast/?lat={dolgota_double.ToString(CultureInfo.InvariantCulture)}&lon={shirota_double.ToString(CultureInfo.InvariantCulture)}&lang=ru_RU&hours=false&limit=1");
            request.Headers.Add("X-Yandex-API-Key", "f525e4a0-5fd3-4395-a2fa-0df5ff1bc78c");

            var response = await client.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {
                var jsonresponse = await response.Content.ReadAsStringAsync();
                 Root = JsonConvert.DeserializeObject<Root>(jsonresponse);
            }
            degrees.Text = $"Температура: {Root.Fact.Temp}°C";
            feelslike.Text = $"Ощущается как:{Root.Fact.FeelsLike}°C";
            windSpeed.Text = $"Скорость ветра:{Root.Fact.WindSpeed}м/с";
            place.Text = $"Погода в {Root.Info.tzinfo.name}";
        }
    }
}
