using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlay
{
    class DrawAtPosition
    {
        public static void WriteAt(int col, int row, string stringToWrite, ConsoleColor colorText = ConsoleColor.White)
        {
            //try
            //{
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = colorText;
            Console.Write(stringToWrite);
            //}
            //catch (ArgumentOutOfRangeException outOfRange)
            //{
            //    Console.Error.WriteLine(outOfRange.Message);
            //}
            //catch (SecurityException security)
            //{
            //    Console.Error.WriteLine(security.Message);
            //}
            //catch (IOException IO)
            //{
            //    Console.Error.WriteLine(IO.Message);
            //}
            //catch (Exception unknown)
            //{
            //    Console.Error.WriteLine(unknown.Message);
            //}
        }
    }
}
