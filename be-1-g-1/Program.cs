namespace be_1_g_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta(); 
            atleta1.Height = 180;
            atleta1.Sport = "Lanciatore di Coriandoli";
            atleta1.Age = 20;
            atleta1.Presentazione();

            Dipendente gianpiero = new Dipendente();
            gianpiero.Name = "GianPiero";
            gianpiero.Azienda = "Epicoddo";
            gianpiero.Work = "Sollevatore di Polemiche";
            gianpiero.Orario = 8;
            gianpiero.Hellodip();

            Animale animalaccio = new Animale();
            animalaccio.Razza = "Cane";
            animalaccio.Verso = "wof wof wof wof wof wof";
            animalaccio.Arrabbiato = "grrrrrrrrr";
            animalaccio.Bestia();

            Veicolo macchina = new Veicolo();
            macchina.Marca = "Alfa Romeo";
            macchina.DataUscita = 2011;
            macchina.Cilindrata = 1600;
            macchina.ShowMacchina();
        }
    } class Atleta
    {
        public int Height { get; set; }
        public string Sport { get; set; }
        public int Age { get; set; }
        public void Presentazione ()
        {
            Console.WriteLine ("Sono alto " + Height.ToString()+ " ho " + Age.ToString() + " anni e faccio il " + this.Sport);
        }

    }
    public class Dipendente
    {
        public string Name { get; set; }
        public string Azienda { get; set; }
        public string Work { get; set; }
        public int Orario { get; set; }

        public void Hellodip()
        {
            Console.WriteLine("Ciao sono " + this.Name + ", lavoro da " + this.Azienda + ", faccio il " + this.Work + " e solitamente lavoro " + this.Orario.ToString() + " ore");
        }
    }
    class Animale
    {
        public string Razza { get; set; }
        public string Verso { get; set; }
        public string Arrabbiato { get; set; }

        public void Bestia()
        {
            Console.WriteLine("Ciao sono un " + this.Razza + this.Verso + " "+ this.Arrabbiato);
        }
    }
    class Veicolo
    {
        public string Marca { get; set; }
        public int DataUscita { get; set; }
        public int Cilindrata { get; set; }

        public void ShowMacchina()
        {
            Console.WriteLine(this.Marca + " in vendita, uscita nel " + DataUscita.ToString() + " con cilindrata di " + Cilindrata.ToString());
        }
    }
}
