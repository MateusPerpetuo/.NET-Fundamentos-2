namespace ESSENCIALS.Models;

public class ExemploExcecao
{
    public void Metodo1()
    {
        try
        {
            Metodo2();    
        } catch(Exception) {
            Console.WriteLine("Excecao tatada");
        }
        
    }
    public void Metodo2()
    {
        Metodo3();
    }
    public void Metodo3()
    {
        Metodo4();
    }
    public void Metodo4()
    {
        throw new Exception("Ocorreu um erros");
    }
}
