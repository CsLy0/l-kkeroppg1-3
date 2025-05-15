using System;
using static System.Net.Mime.MediaTypeNames;

namespace loops
{

    class program
    {
        static void Main(string[] args)
        {
            program forLoopProgram = new program();
            forLoopProgram.ForLoop();
            forLoopProgram.ForeachLoop();
            forLoopProgram.WhileLoop();
        }

        private void ForLoop()
        {
           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }

            Console.WriteLine(); //vil ha mellomrom, ser bedre ut :D
        }
        private void ForeachLoop()
        {
            string text = "Terje er kul";
            char[] charArray = text.ToCharArray();

            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
        }
        private void WhileLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Dette er runde nr. " + counter);
                counter++;
            }
        }
    }
    
}
