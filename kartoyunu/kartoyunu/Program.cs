namespace kartoyunu
{
    public static class Program
    {
      
        [STAThread]

        static void Main()
        {
            Oyuncu oyuncu1 = new Oyuncu("R�MEYSA", "DO�AN");
            Oyuncu rakip = new Oyuncu("ZEYNEP SENA", "DO�AN");

            
            IKart[] kartlar = new IKart[]
            {
                new Sald�r�(),
                new Savunma(),
                new Sifa()
            };

            
            kartlar[0].Aksiyon(oyuncu1, rakip);  
            kartlar[1].Aksiyon(oyuncu1, rakip);  
            kartlar[2].Aksiyon(oyuncu1, rakip);  


            Application.Run(new Form1());

        }
    }
}