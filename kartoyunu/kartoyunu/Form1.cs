using kartoyunu;

namespace kartoyunu
{
    public partial class Form1 : Form
    {
        private Oyuncu oyuncu1;
        private Oyuncu rakip;
        private IKart[] kartlar;

        public Form1()
        {
            InitializeComponent();

            oyuncu1 = new Oyuncu("Rümeysa", "Doðan");
            rakip = new Oyuncu("Zeynep Sena", "Doðan");
            labelOyuncuIsim.Text = "Oyuncu: " + oyuncu1.Adi + " " + oyuncu1.Soyadi;
            labelRakipIsim.Text = "Rakip: " + rakip.Adi + " " + rakip.Soyadi;


            kartlar = new IKart[]
            {
                new Saldýrý(),
                new Savunma(),
                new Sifa()
            };

            UpdateLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanýcý Can: " + oyuncu1.CanPuani + " Savunma: " + oyuncu1.Savunma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rakip Can: " + rakip.CanPuani + " Savunma: " + rakip.Savunma);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunu sýfýrlama");
            oyuncu1.CanPuani = 100;
            rakip.CanPuani = 100;

            foreach (var kart in kartlar)
            {
                kart.Enerji = 10;
            }

            UpdateCan();
        }
        private void RakipHamlesi()
        {
            Random rand = new Random();
            int rakipSecimi = rand.Next(0, kartlar.Length);
            kartlar[rakipSecimi].Aksiyon(rakip, oyuncu1);
            UpdateLabel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kartlar[0].Aksiyon(oyuncu1, rakip);
            RakipHamlesi();  
            UpdateCan();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kartlar[1].Aksiyon(oyuncu1, rakip);
            RakipHamlesi();  
            UpdateCan();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kartlar[2].Aksiyon(oyuncu1, rakip);
            RakipHamlesi();  
            UpdateCan();
        }

        
     

        private void UpdateLabel()
        {
            
            labelOyuncuIsim.Text = "Oyuncu: " + oyuncu1.Adi + " " + oyuncu1.Soyadi;
            labelRakipIsim.Text = "Rakip: " + rakip.Adi + " " + rakip.Soyadi;

            
            labelOyuncuCan.Text = "Can: " + oyuncu1.CanPuani;
            labelRakipCan.Text = "Can: " + rakip.CanPuani;
            UpdateCan();
        }


        private void UpdateCan()
        {
            progressBarOyuncu.Value = Math.Max(0, Math.Min(oyuncu1.CanPuani, 100));
            progressBarRakip.Value = Math.Max(0, Math.Min(rakip.CanPuani, 100));
        }

        private void labelRakipIsim_Click(object sender, EventArgs e)
        {
            
        }
    }
}
