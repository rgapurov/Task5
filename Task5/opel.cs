using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class opel
    {
        private string model;
        public static string Mmodel = "Astra";

        public void SetModel()
        { model = Mmodel; }
        public string GetModel()
        { return model; }
        public static void ModelYaz()
        {
            Console.WriteLine("Araba modeli: " + Mmodel);
        }
    }
}
