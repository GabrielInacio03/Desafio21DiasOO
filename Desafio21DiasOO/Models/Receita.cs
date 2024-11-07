namespace Desafio21DiasOO.Models
{
    public class Receita
    {
        public string Tamanho { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }

        public Receita(){}

        public Receita(string Tamanho, double Peso, double Preco)
        {
            this.Tamanho = Tamanho;
            this.Peso = Peso;
            this.Preco = Preco;
        }

        public void Salvar()
        {
            System.Console.WriteLine("Salvando Receita...");
        }
        public void Mostrar()
        {
            System.Console.WriteLine("Mostrar Receita...");
        }
    }
}