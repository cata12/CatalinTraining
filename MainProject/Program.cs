using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> nameList = new List<string>();
            nameList.Add("anA");
            nameList.Add("elena");
            nameList.Add("MARIA");
            nameList.Add("cRisTiAn");

            //FirstExercise
            foreach (var nume in nameList)
                Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nume.ToLower()));
            Console.ReadLine();
        }
    }
}
