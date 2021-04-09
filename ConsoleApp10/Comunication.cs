using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace GAMEOFTHRONES
{
    static  class Comunication
    {
        static public void lettersender(this string author, string addrees, string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(addrees))
            {
                streamWriter.WriteLine(message);
                streamWriter.Write("from" + author);
            }
        }
    } 
}
