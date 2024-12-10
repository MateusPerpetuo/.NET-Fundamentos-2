

namespace ESSENCIALS.Models;

public class Curso
{
    public string Nome { get; set; }

    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno (Pessoa aluno)
    {
        Alunos.Add(aluno);
        Console.WriteLine($"Aluno {aluno.NomeCompleto} adicionado ao curso {Nome} com sucesso!");
    }

    public bool RemoverAluno(Pessoa aluno) => Alunos.Remove(aluno);


    public void ObterQuantidadeDeAlunosMatriculados() => Console.WriteLine($"Quantidade de Alunos matriculados: {Alunos.Count}");

    public void ListarAlunos()
    {
        Console.WriteLine($"Lista de alunos do curso: {Nome}:");
        foreach(Pessoa aluno in Alunos)
        {
            Console.WriteLine(aluno.NomeCompleto);
        }
    }


}
