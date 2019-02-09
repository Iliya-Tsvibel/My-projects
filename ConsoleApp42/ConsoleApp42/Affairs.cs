using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Affairs
    {
        public string title;
        public bool isUrgentAffair;
        public bool isImportant;
        public Affairs(string title, bool isUrgentAffair, bool isImportant)
        {
            this.title = title; 
            this.isUrgentAffair = isUrgentAffair;
            this.isImportant = isImportant;
        }

        public void GetPriority()
        {
            Console.WriteLine("1");
        }

        public override string ToString()
        {
            
            return $"This affair is: {this.title} {(isUrgentAffair ? "Urgant affair" : "Not urgant affair")} {(isImportant ? "Important affair" : "Not important affair")}";
        }


    }
}
