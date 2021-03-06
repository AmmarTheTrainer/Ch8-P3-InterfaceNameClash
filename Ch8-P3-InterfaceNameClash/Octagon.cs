﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P3_InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //public void Draw()
        //{
        //    // Shared drawing logic.
        //    Console.WriteLine("Drawing the Octagon...");
        //}

        //// Error! No access modifier!
        //public void IDrawToForm.Draw()
        //{
        //    Console.WriteLine("Drawing to form...");
        //}

        // Explicitly bind Draw() implementations to a given interface.
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a printer...");
        }
    }
}
