namespace DesafioPOO.Models
{
    // Correção: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Correção: Passar os parâmetros do construtor para as propriedades
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Implementar lógica específica do construtor, se necessário
        }

        // Correção: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Implementar lógica de instalação de aplicativo para Nokia
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}
