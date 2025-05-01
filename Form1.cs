using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Numerics;
using System;

namespace genetik_algoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Random rand = new Random();
        List<birey> populasyon = new List<birey>();
        int populasyonBoyutu;
        int jeneresyon;
        double mutasyonOraný;
        double caprazlamaOraný;
        int maxValue = 5;
        int minValue = -5;
        double secicilik;

        private void button_coz_Click(object sender, EventArgs e)
        {

            populasyonBoyutu = Convert.ToInt32(populasyon_size_textbox.Text);
            jeneresyon = Convert.ToInt32(jenerasyon_textbox.Text);
            mutasyonOraný = Convert.ToDouble(mutasyon_oraný_up_down.Value);
            caprazlamaOraný = Convert.ToDouble(caprazlama_oraný_up_down.Value);
            secicilik = Convert.ToDouble(secicilik_up_down.Value);

            populasyon = PopulasyonOlustur();
            genetikAlgoritma();
        }


        private List<birey> PopulasyonOlustur()
        {
            List<birey> population = new List<birey>();
            for (int i = 0; i < populasyonBoyutu; i++)
            {
                population.Add(new birey());
            }
            return population;
        }

        private birey TurnuvaaSecme()
        {
            return populasyon.OrderBy(_ => rand.Next()).Take(5).OrderBy(ind => ind.Fitness).First();
        }

        private birey Caprazlama(birey e1, birey e2)
        {
            double alpha = rand.NextDouble();
            if (alpha > caprazlamaOraný)
            {
                return new birey(e1.X, e1.Y);
            };

            double newX = (alpha * e1.X) + ((1 - alpha) * e2.X);
            double newY = (alpha * e1.Y) + ((1 - alpha) * e2.Y);
            return new birey(newX, newY);
        }

        private void Mutasyon(birey b)
        {
            if (rand.NextDouble() < mutasyonOraný)
                b.X += minValue + (maxValue - minValue) * rand.NextDouble();
            if (rand.NextDouble() < mutasyonOraný)
                b.Y += minValue + (maxValue - minValue) * rand.NextDouble();

            b.FitnessHesapla();
        }

        public void Evrim()
        {
            int secicilikSayi = (int)(secicilik * populasyonBoyutu);
            List<birey> newPopulation = new List<birey>();

            var sortedPopulasyon = populasyon.OrderBy(ind => ind.Fitness).ToList();
            for (int i = 0; i < secicilikSayi; i++)
            {
                newPopulation.Add(sortedPopulasyon[i]);
            }

            for (int i = secicilikSayi; i < populasyonBoyutu; i++)
            {
                birey e1 = TurnuvaaSecme();
                birey e2 = TurnuvaaSecme();
                birey cocuk = Caprazlama(e1, e2);
                Mutasyon(cocuk);
                newPopulation.Add(cocuk);
            }

            populasyon = newPopulation;
        }
        void genetikAlgoritma()
        {
            List<birey> charta_ekle = new List<birey>();
            birey best = populasyon.OrderBy(ind => ind.Fitness).First();
            charta_ekle.Add(best);

            for (int i = 0; i < jeneresyon; i++)
            {
                Evrim();
                best = populasyon.OrderBy(ind => ind.Fitness).First();

                charta_ekle.Add(best);
            }

            Grafik grafik = new Grafik(charta_ekle);
            grafik.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
