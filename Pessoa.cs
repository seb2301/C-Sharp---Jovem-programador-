namespace Batata {
    public class Pessoa{
        public string Nome { get; set;}
        public double Altura { get; set;}
        public double Peso { get; set;}
        public string CPF { get; set;}
        public int Idade { get; set;}



        public void Apresentar(){
            Console.WriteLine($"Oi, meu nome é {Nome}, eu tenho {Idade} anos, tenho {Altura} de altura, meu CPF é: {CPF} ");

        }
        


        public void Andar(){
            Console.WriteLine("Estou andando.");       

        }
    }
}