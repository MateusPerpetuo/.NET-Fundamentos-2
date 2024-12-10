using System.Globalization;
using ESSENCIALS.Models;


// Definindo a formatação de moedas (dinheiro) para o padrão do Brasil
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.03M;
//Exibindo dinheiro ja na formação correta
Console.WriteLine($"{valorMonetario:C}");

// Forcando a mostrar a moeda com fortação no padrão dos EUA
Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));

// Pra controlar o numero de casa decicimais exibidas
Console.WriteLine(valorMonetario.ToString("N2"));


// para representar %
double porcentagem = .4321;
Console.WriteLine(porcentagem.ToString("P"));


// Criando formatos mais personalizados
int numero = 123456;
Console.WriteLine(numero.ToString("###-###"));


DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));


// pra pegar só a Data
Console.WriteLine(data.ToShortDateString());

// pra pegar só a hora
Console.WriteLine(data.ToShortTimeString());

// pra converter string pra dateTime
data = DateTime.Parse("25/04/2022 16:40");
Console.WriteLine(data);

// uma conversao mais segura
string dataString = "2022-08-17 15:36";
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

if (sucesso) 
{
    Console.WriteLine($"Conversao com sucesso Data: {dataConvertida}");
} 
else 
{
    Console.WriteLine($"{dataString} não é uma data valida");
}












// Pessoa p1 = new Pessoa(nome: "Mateus",sobrenome: "Perpetuo");
// Pessoa p2 = new Pessoa(nome: "Marcos",sobrenome: "Silva");
// Pessoa p3 = new Pessoa(nome: "Jessica",sobrenome: "Paiva");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();
// cursoDeIngles.ListarAlunos();









//p1.Nome = "Mateus";
//p1.Sobrenome = "Perpetuo";
//p1.Idade = 26;
//p1.Apresentar();