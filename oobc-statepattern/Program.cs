using System;
using System.Collections.Generic;
using System.Text;

namespace oobc_statepattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input drawing shape type (line):");
            var shapeType = Console.ReadLine();
            var stateContext = new StateContext();
            stateContext.Input(shapeType);


            while(stateContext.GetState().GetType() != typeof(InputEndState))
            {
                Console.WriteLine("please input point for this shape (0,0):");
                var point = Console.ReadLine();
                stateContext.Input(point);
            }


            Console.WriteLine(stateContext.Draw());
            Console.ReadLine();
        }
    }
}
