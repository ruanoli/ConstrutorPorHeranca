namespace BuilderByInheritance.Models
{
    public class Diretor : Aluno
    {
        public Diretor(string nome, int idade) : base(nome, idade)
        {
        }

        //Não podemos sobrescrever o método Apresentar de alunos, pois o método está selado.
    }
}