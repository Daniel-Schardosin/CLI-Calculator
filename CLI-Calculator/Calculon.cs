
class Program
{
    static void Main(string[] args)
    {
        Leitor operadores = new Leitor();
        string Operador = operadores.LeitorOperacao();

        String Input0;
        String Input1;



        Console.WriteLine("#######################################");
        Console.WriteLine("# Bem vindo a calculadora de terminal #");
        Console.WriteLine("#                                     #");
        Console.WriteLine("#                                     #");
        Console.WriteLine("#                                     #");
        Console.WriteLine("# Insira um número:                   #");

        Input0 = Console.ReadLine();
        Console.WriteLine("# Insira o próximo número:             #");
        Input1 = Console.ReadLine();


        switch (Operador)
        {
            case "+":
                Console.Write("Adição selecionada");
                break;
            case "-":
                Console.Write("Subtração selecionada");
                break;
            case "/":
                Console.Write("Divisão selecionada");
                break;
            case "*":
                Console.Write("Multiplicação selecionada");
                break;
            default:
                Console.Write("Operador inválido, tente novamente! ");
                Operador = operadores.LeitorOperacao();
                break;
        }




        Console.WriteLine("Número identificado: " + Input0);
    }
}
  class Leitor
        {
        public string LeitorOperacao()
        {    
            String Operador;
            Console.WriteLine("Escolha o operador: (+)Adição, (-)Subtração, (/)Divisão, (*)Multiplicação");
             return Console.ReadLine().Trim();
        }
        }