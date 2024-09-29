using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia()
        {

        }

        public Nokia(string numero)
        {
            Numero = numero;
        }

        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Nokia\ninstalando {nomeApp}...");
        }


    }
}