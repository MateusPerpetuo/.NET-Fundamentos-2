using ESSENCIALS.Models;

Pessoa p1 = new Pessoa(nome: "Mateus",sobrenome: "Perpetuo");
Pessoa p2 = new Pessoa(nome: "Marcos",sobrenome: "Silva");
Pessoa p3 = new Pessoa(nome: "Jessica",sobrenome: "Paiva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();
cursoDeIngles.ListarAlunos();


















//p1.Nome = "Mateus";
//p1.Sobrenome = "Perpetuo";
//p1.Idade = 26;
//p1.Apresentar();