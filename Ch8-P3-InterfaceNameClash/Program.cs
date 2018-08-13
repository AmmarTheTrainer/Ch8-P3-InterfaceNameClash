using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P3_InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            
            // All of these invocations call the same Draw() method!
            Octagon oct = new Octagon();

            #region Without Explicit Interface Implementation



            //IDrawToForm itfForm = (IDrawToForm)oct;
            //itfForm.Draw();

            //IDrawToPrinter itfPriner = (IDrawToPrinter)oct;
            //itfPriner.Draw();

            //IDrawToMemory itfMemory = (IDrawToMemory)oct;
            //itfMemory.Draw();

            #endregion


            // We now must use casting to access the Draw() members.

            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            
            // Shorthand notation if you don't need the interface variable for later use.
            ((IDrawToPrinter)oct).Draw();
            
            // Could also use the "is" keyword.
            if(oct is IDrawToMemory dtm)
                        dtm.Draw();

            Console.ReadLine();
        }
    }
}
