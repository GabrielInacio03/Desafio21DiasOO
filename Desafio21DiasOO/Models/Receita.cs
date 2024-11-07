namespace Desafio21DiasOO.Models
{
    public class Receita
    {
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }

        public Receita(){}
        public Receita(string Nome)
        {
            this.Nome = Nome;
        }
        public Receita(string Nome, string Tamanho, double Peso, double Preco)
        {
            this.Nome = Nome;
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

        public override string ToString() 
        {
            return $"Receita {this.Nome}:"+
                $"\n Tamanho: {this.Tamanho}"+
                $"\n Peso: {this.Preco}"+
                $"\n Preço: {this.Preco}";
        }
    }
}