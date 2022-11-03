namespace BuilderByInheritance.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Hello, I'am {Nome} and I'am {Idade} years old.");
        }
    }
}
