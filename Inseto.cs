namespace Batata {
    public class Inseto{
        public string NomeInseto { get; set;}
        public string Tamanho { get; set;}
        public int Qtd { get; set;}
        public bool Voador { get; set;}
        public int QtdDias { get; set;}


        public void Apresentar(){
            Console.WriteLine($"O Nome do inseto é {NomeInseto}, Eles foram vistos há {QtdDias} dias, o número deles são de:  {Qtd} , é positivo para voadores?: {Voador} ");
        }

        public void Dormir(){
            Console.WriteLine("Está dormindo?.");    


        }
    }
}

    
