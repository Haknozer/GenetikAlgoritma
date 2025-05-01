using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace genetik_algoritma
{
    public partial class Grafik : Form
    {
        public Grafik(List<birey> bireyler)
        {
            InitializeComponent();
            UiChart();
            birey_liste = bireyler;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        Chart chartFitness;
        List<birey> birey_liste;

        private void Grafik_Load(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < birey_liste.Count; i++)
            {
                chartFitness.Series["Fitness"].Points.AddXY(i, birey_liste[i].Fitness);
            }

            TextAnnotation annotation = new TextAnnotation
            {
                Text = $"En İyi Değerler =  X: {birey_liste[i - 1].X}, Y: {birey_liste[i - 1].Y}, Fitness: {birey_liste[i - 1].Fitness}",
                X = 10,  
                Y = 0,  
                ForeColor = Color.Red,  
                Font = new Font("Arial", 8, FontStyle.Italic) 
            };

            chartFitness.Annotations.Add(annotation);
        }



        private void UiChart()
        {
            chartFitness = new Chart();

            chartFitness.Dock = DockStyle.Fill;

            chartFitness.Titles.Add("Yakınsam Grafiği");
            chartFitness.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

            ChartArea chartArea = new ChartArea
            {
                AxisX =
        {
            Title = "Jenerasyon",
            Interval = 2,
            MajorGrid = { LineColor = Color.LightGray }
        },
                AxisY =
        {
            Title = "En İyi Fitness",
            MajorGrid = { LineColor = Color.LightGray }
        }
            };
            chartFitness.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Fitness",
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Red,
            };

            chartFitness.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartFitness.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFitness.BackColor = Color.WhiteSmoke;
            chartFitness.ChartAreas[0].BackColor = Color.LightYellow;

            chartFitness.ChartAreas["ChartArea1"].CursorX.Interval = 0.01;
            chartFitness.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            chartFitness.ChartAreas["ChartArea1"].CursorX.AutoScroll = true;
            chartFitness.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;

            chartFitness.ChartAreas["ChartArea1"].CursorY.Interval = 0.01;
            chartFitness.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
            chartFitness.ChartAreas["ChartArea1"].CursorY.AutoScroll = true;
            chartFitness.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;

            chartFitness.Series.Add(series);

            this.Controls.Add(chartFitness);
        }

    }
}
