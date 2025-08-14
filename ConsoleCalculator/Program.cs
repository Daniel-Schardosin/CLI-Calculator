
class Program
{
    static void Main(string[] args)
    {
        Leitor selecao = new Leitor();
        Calculadora operacao = new Calculadora();

        //Inputs para obtenção dos valores do tipo string do terminal
        String? strInput_0;
        String? strInput_1;
        string? Continuar;

        //Inputs do tipo decimal para a conversão dos dados lidos 
        Decimal Resultado = 0;
        Decimal Input_1;
        Decimal Input_2;

        //Booleanos
        bool Escolha = false;
        
        
        

            Console.WriteLine("# Bem vindo a calculadora de terminal #");
            Console.WriteLine("#                                     #");
            Console.WriteLine("#                                     #");
            Console.WriteLine("#                                     #");
            Console.WriteLine("# Insira um número:                   #");

            strInput_0 = Console.ReadLine();

            string Operador = selecao.Operador();

            Console.WriteLine("# Insira o próximo número:             #");
            strInput_1 = Console.ReadLine();
            Input_1 = decimal.Parse(strInput_0);
            Input_2 = decimal.Parse(strInput_1);



            switch (Operador)
            {
                case "+":
                    Resultado = operacao.Somar(Input_1, Input_2);
                    break;
                case "-":
                    Resultado = operacao.Subtracao(Input_1, Input_2);
                    break;
                case "/":
                    Resultado = operacao.Divisao(Input_1, Input_2);
                    break;
                case "*":
                    Resultado = operacao.Multiplicacao(Input_1, Input_2);
                    break;
                default:
                    Console.Write("Operador inválido, tente novamente! ");
                    return;
            }
            Console.WriteLine($"Resultado = {Resultado} ");
            Console.WriteLine("Continuar? (s) para sim ou (n) para encerrar");
            Continuar = Console.ReadLine();
            
        
    }
}

  class Leitor
        {
        public string Operador()
        {    
            Console.WriteLine("Escolha o operador: (+)Adição, (-)Subtração, (/)Divisão, (*)Multiplicação");
            return Console.ReadLine().Trim();
        }
        }
