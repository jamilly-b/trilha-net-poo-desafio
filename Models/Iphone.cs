namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" **** Feito! ****
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" **** Feito! ****
        public override void InstalarAplicativo(string nomeAPP){
            Console.WriteLine($"Instalando aplicativo \"{nomeAPP}\" no Iphone.");
            Console.WriteLine($"{nomeAPP} Instalado.");
        }
    }
}