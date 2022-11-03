using BuilderByInheritance.Models;

Professor prof = new Professor("Ruan", 40);
prof.Apresentar();

Pessoa p1 = new Pessoa("Tania", 55);
p1.Apresentar();

Aluno a1 = new Aluno("Thiago", 4);
a1.Apresentar();

Computador cp = new Computador();
Console.WriteLine(cp.ToString());