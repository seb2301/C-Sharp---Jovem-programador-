using System.Net.Http.Headers;

namespace Batata {
    public class Program {
        static void Main(){
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa1 = new Pessoa();
            Cachorro cachorro = new Cachorro();

            Console.WriteLine("Informe o seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade: ");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu peso: ");
            pessoa.Peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            pessoa.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu CPF: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe o seu nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade: ");
            pessoa1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu CPF: ");
            pessoa1.CPF = Console.ReadLine();

            Console.WriteLine("Informe o seu peso: ");
            pessoa1.Peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            pessoa1.Altura = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Informe o nome do seu cachorro: ");
            cachorro.NomeCachorro = Console.ReadLine();

            Console.WriteLine("Informe idade do seu cachorro: ");
            cachorro.IdadeCachorro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do dono do cachorro: ");
            cachorro.Dono = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de brinquedos: ");
            cachorro.QtdBrinquedos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O cachorro está dormindo?: ");
            cachorro.Dormindo = Convert.ToBoolean(Console.ReadLine());



            pessoa.Apresentar();
            pessoa1.Apresentar();
            cachorro.Apresentar();
        }
    }
    
}
