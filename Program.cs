﻿using System.Globalization;
using ESSENCIALS.Models;
using Newtonsoft.Json;


// ---------- Metodos de Extensão

int numero = 15;

Console.WriteLine($"O número {numero} é " + (numero.EhPar() ? "par" : "impar"));











// //  Classes genéricas 
// MeuArrayGenerico<int> arrayInteiro = new MeuArrayGenerico<int>();

// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine($"Array : {arrayInteiro[0]}");

// MeuArrayGenerico<string> arrayString = new MeuArrayGenerico<string>();

// arrayString.AdicionarElementoArray("testando");
// Console.WriteLine($"Array : {arrayString[0]}");









// // ----- tipos dinamicos ---

// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()},  Valor: {variavelDinamica}");

// variavelDinamica = "texto";

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()},  Valor: {variavelDinamica}");

// variavelDinamica = true;

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()},  Valor: {variavelDinamica}");










// //  ------------ tipos anônimos em coleções

// string contetudoArquivoVendas =  File.ReadAllText("Arquivos/vendas.json");

// List<VendasDeserializando> listaVendas = JsonConvert.DeserializeObject
//                            <List<VendasDeserializando>>(contetudoArquivoVendas);

// var listaAnonimo = listaVendas.Select(x => new { x.Produto, x.Valor });

// foreach (var v in listaAnonimo)
// {
//     Console.WriteLine($"{v.Produto} - {v.Valor}");
    
// }










// // --------- Tipos anônimos ----

// var tipoAnonimo = new { Nome = "Mateus", Sobrenome = "Silva", Altura = 1.80m };

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");















// // ---------- Deserializacao (JSON)  EXEMPLO 2 NULL EM PROPRIEDADE  ------------

// string contetudoArquivoVendas =  File.ReadAllText("Arquivos/vendas.json");

// List<VendasDeserializando> listaVendas = JsonConvert.DeserializeObject
//                             <List<VendasDeserializando>>(contetudoArquivoVendas);

// foreach (VendasDeserializando venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Valor: {venda.Valor}," 
//                       +  $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"
//                       +  $"{(venda.Desconto.HasValue ? $", Desconto de: {venda.Desconto}%" : "" )}");
    
// }










// // ------------ Aula de tipos especiais NULL ()

// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value){
//     Console.WriteLine($"O Usuário optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }










// // ---------- Deserializacao (JSON)  EXEMPLO 1  ------------

// string contetudoArquivoVendas =  File.ReadAllText("Arquivos/vendas.json");

// List<VendasDeserializando> listaVendas = JsonConvert.DeserializeObject
//                             <List<VendasDeserializando>>(contetudoArquivoVendas);

// foreach (VendasDeserializando venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Valor: {venda.Valor}, Data: {venda.DataVenda}");
    
// }







// // ---------- Serializacao (JSON)  EXEMPLO 1  ------------

// // ISO 8601 - padroniza a representação de tava entre sistemas, por isso a data no json vai sair diferente
// DateTime dataAtual =  DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 25.0M, dataAtual);
// Venda v2 = new Venda(2, "Licença Software", 130.0M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado =  JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine($"{serializado}");
 











// //------------ if ternario -------------------------


// int numero = 14;

// bool ehPar = false;

// ehPar =  numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));












//------------ descontrutor --------


// Pessoa p1 = new Pessoa("Mateus", "Silva");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");










//------------ tupla --------

// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _ // quantidadeLinhas para discarta a informação basta por um "_" na posição dela
//                                 ) = arquivo.LeituraArquivoTupla("Arquivos/ArquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo!");
// }




// (int id, string nome, string sobrenome, decimal altura) tupla = (1, "Mateus", "Silva", 1.80m);

// //ValueTuple<int, string, string , decimal> outroExempleTupla = (1, "Mateus", "Silva", 1.80m);

// //var outroExempleTuplaCreate =  Tuple.Create(1, "Mateus", "Silva", 1.80m);


// Console.WriteLine($"id: {tupla.id}");
// Console.WriteLine($"Nome: {tupla.nome}");
// Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
// Console.WriteLine($"Altura: {tupla.altura}");












// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("---------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente {chave}");
// } 
// else
// {
//     Console.WriteLine($"Valor não existente. É seguro adicionar a chave {chave}");
// }












// Stack<int> pilha = new Stack<int>();

// pilha.Push(5);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento : {pilha.Pop()}");

// pilha.Push(1000);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }








// Queue<int> fila = new Queue<int>();


// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(2);


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento : {fila.Dequeue()}");

// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }








//new ExemploExcecao().Metodo1();









// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

//     foreach(string linha in linhas) 
//     {
//     Console.WriteLine(linha);
//     }
// } 
// catch (FileNotFoundException e)
// {
//     Console.WriteLine($"Arquivo não encontrado. {e.Message}");
// }
// catch (DirectoryNotFoundException e)
// {
//     Console.WriteLine($"Caminho da pasta não encontrado {e.Message}");
// }
// catch (Exception e)
// {
//     Console.WriteLine($"Ocorreu uma exeção genéria. {e.Message}");
// }
// finally{

// }



















// Definindo a formatação de moedas (dinheiro) para o padrão do Brasil
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.03M;
// //Exibindo dinheiro ja na formação correta
// Console.WriteLine($"{valorMonetario:C}");

// // Forcando a mostrar a moeda com fortação no padrão dos EUA
// Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));

// // Pra controlar o numero de casa decicimais exibidas
// Console.WriteLine(valorMonetario.ToString("N2"));


// // para representar %
// double porcentagem = .4321;
// Console.WriteLine(porcentagem.ToString("P"));


// // Criando formatos mais personalizados
// int numero = 123456;
// Console.WriteLine(numero.ToString("###-###"));


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));


// // pra pegar só a Data
// Console.WriteLine(data.ToShortDateString());

// // pra pegar só a hora
// Console.WriteLine(data.ToShortTimeString());

// // pra converter string pra dateTime
// data = DateTime.Parse("25/04/2022 16:40");
// Console.WriteLine(data);

// // uma conversao mais segura
// string dataString = "2022-08-17 15:36";
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

// if (sucesso) 
// {
//     Console.WriteLine($"Conversao com sucesso Data: {dataConvertida}");
// } 
// else 
// {
//     Console.WriteLine($"{dataString} não é uma data valida");
// }












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