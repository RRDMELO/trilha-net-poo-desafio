namespace DesafioPOO.Models
{
    public class Iphone: Smartphone
    {

        public Iphone()
        {

        }

        public Iphone(string numero)
        {
            Numero = numero;
        }

        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iphone\ninstalando {nomeApp}...");
        }


    }
}