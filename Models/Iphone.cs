namespace DesafioPOO.Models
{
    // Correção: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Correção: Passar os parâmetros do construtor para as propriedades
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Implementar lógica específica do construtor, se necessário
        }

        // Correção: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Implementar lógica de instalação de aplicativo para iPhone
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}