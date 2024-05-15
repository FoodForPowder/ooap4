using OOAP4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dolgota_double = double.Parse(dolgota.Text);
            var shirota_double = double.Parse(lonBox.Text);
            var YaApi = new YaApi();
            var Root = await YaApi.GetWeatherByPoint(dolgota_double, shirota_double);
            degrees.Text = $"Температура: {Root.Fact.Temp}°C";
            feelslike.Text = $"Ощущается как:{Root.Fact.FeelsLike}°C";
            windSpeed.Text = $"Скорость ветра:{Root.Fact.WindSpeed}м/с";
            place.Text = $"Погода в {Root.Info.tzinfo.name}";
        }
    }
}
