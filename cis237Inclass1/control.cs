using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    private class controlClass
    {

        public controlClass()
        {
            printPrompt();
        }
        public void printPrompt()
        {
            Console.WriteLine("Input Command or Type \"help\"");
            string answer = Console.ReadLine();
        }
        private void processPromptAnswer(String answer)
            {
                switch(answer)
                {
                    case "help":
                        Console.WriteLine("display wineID/all".PadRight(20) + "displays wine with wineID matching");
                        break;
                    case "exit":
                        
                }
            }

    }
}
