using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolyNome.MaintenanceSystem
{
    public struct Qualification //Napr. svarec, vyskove prace,
    {
        string ID; //SV, VP, .... - melo by byt unique.
        string Name;
        string Description;
        DateTime ValidFrom;
        DateTime ValidTo;
    }
    public class Worker: User
    {
        public Qualification[] Specialization { get; set; }
        public int Salary { get; set; }

        public User EmergencyContact { get; set; }
        
        public Worker() { }


    }
}
