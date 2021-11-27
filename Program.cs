using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.Clear();

            mold();//moldura

            
            Console.SetCursorPosition(20,2);
            Console.WriteLine("Escolha a Operação");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            menu();//menu

            Console.ResetColor();                             //|
            Console.SetCursorPosition(10,11);                 //|
            Console.Write("Opção desejada : ");               //|-- Entrada Opção
            Console.SetCursorPosition(27,11);                 //|
            Console.ForegroundColor = ConsoleColor.DarkCyan;  //|
            op = int.Parse(Console.ReadLine());               //|
            Console.ResetColor();

            
        }
        static void mold()//linha 1 até 12 - Moldura
        {
            int c = 1;
            while(c<=12)
            {
                if(c ==1)
                {
                    Console.SetCursorPosition(3,c);
                    Console.WriteLine("╔════════════════════════════════════════════════╗");
                }
                if(c == 12)
                {
                    Console.SetCursorPosition(3,c);
                    Console.WriteLine("╚════════════════════════════════════════════════╝");
                }
                else
                {
                    Console.SetCursorPosition(3,c+1);
                    Console.WriteLine("║                                                ║");
                }
                c++;
            }
        }
        static void menu()//linha 3 até 9 - Menu de Opções
        {
            Console.SetCursorPosition(10,3);
            Console.WriteLine("1. Soma");
            Console.SetCursorPosition(10,4);
            Console.WriteLine("2. Subtração");
            Console.SetCursorPosition(10,5);
            Console.WriteLine("3. Multipliacação");
            Console.SetCursorPosition(10,6);
            Console.WriteLine("4. Divisão");
            Console.SetCursorPosition(10,7);
            Console.WriteLine("5. Exponenciação");
            Console.SetCursorPosition(10,8);
            Console.WriteLine("6. Radiação");
            Console.SetCursorPosition(10,9);
            Console.WriteLine("7. Bháskara");
            
        }
        static double soma(double n1, double n2)
        {
            return n1 + n2;
        }
        static double sub(double n1, double n2)
        {
            return n1 - n2;
        }
        static double mult(double n1, double n2)
        {
            return n1 * n2;
        }
        static double div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
