namespace BuilderByInheritance.Models
{
    public  sealed class Professor : Pessoa
    {
        //contrutor por herança
        public Professor(string nome, int idade) : base(nome, idade)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Eu sou um professor e me chamo {Nome}");
        }
    }
}