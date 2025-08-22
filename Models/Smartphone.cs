namespace DesafioPOO.Models
{
    // Classe abstrata que representa um smartphone
    public abstract class Smartphone
    {
        // Propriedades comuns
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos concretos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato -> cada marca implementa sua versão
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
