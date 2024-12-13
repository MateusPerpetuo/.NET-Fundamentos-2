using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESSENCIALS.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LeituraArquivoTupla(string caminho)
        {
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return(true, linhas, linhas.Count());
            } 
            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}"); 
                return(false, new string[0], 0);
            }
        }
    }
}