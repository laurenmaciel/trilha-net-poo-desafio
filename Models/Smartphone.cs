namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string NumeroLigando { get; set; } 
        
        public string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(string numeroLigando)
        {
            NumeroLigando = numeroLigando;
            Console.WriteLine($"Recebendo ligação de {numeroLigando}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
