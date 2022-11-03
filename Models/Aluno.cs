namespace BuilderByInheritance.Models
{
    public class Aluno : Pessoa
    {
        //contrutor por herança
        //recebo o parâmetro nome e passo-o para a classe pai(base).
        public Aluno(string nome, int idade) : base(nome, idade)
        {
            
        }
        public decimal Nota { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Sou {Nome}, aluno do Recriando bem-me-quer.");
        }
    }
}