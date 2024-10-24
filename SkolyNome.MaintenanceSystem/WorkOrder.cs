using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolyNome.MaintenanceSystem
{
    public class WorkOrder //Prikaz k praci
    {
        //cislo prikazu, jmeno prikazu, kdyZalozen, 
        private const int maxNumberOfWorkers = 20; //promenna oznacena jako konstanta - nemuze se menit!
        public Worker[] assignedWorkersArray = new Worker[maxNumberOfWorkers]; //Maximalne 20 delniku, brzy nahradime strukturou co umozni dynamicke pridani, odebrani..
        public int NumberOfAssignedWorkers {  get; private set; }
        public string WorkDescription { get; set; }
        public string ID { get; private set; }
        public DateTime ExecutionDate { get; set; }
        public DateTime PlannedDate { get; set; }
        public void AddWorkerToOrder(Worker worker)
        {
            if (NumberOfAssignedWorkers < maxNumberOfWorkers)
            {
                //projdi pole a zjisti jestli neexistuje na nejake pozici worker se stejnym UserName
                // pokud ne tak Do pole assignedWorkersArray pridej na pozici numberOfAssignedWorkers - 1 worker
                // pricti do NumberOfAssignedWorkers 1
                
                // pokud uz existuje tak nedelej nic, uz tam je.
            }
            else
            {
                // udelej Exception throw new Ex....
            }
        }
        public void RemoveWorkerFromOrder(string userName)
        {
            //projdi cele pole a zjisti jestli na nejake pozici neni worker s UserName = userName
            //Pokud ano tak si oznac pozici (dej ji to localni promenne)
            //Vsechny uzivatele vpravo od teto pozice posun o jednu pozici doleva.
            //odecti 1 z NumberOfAssignedWorkers
        }
        public string PrintAssignedWorkers()
        {
            string textOut = "";
            //projde pole AssignedWorkers a prida je do carkou oddelene promenne textOut
            return textOut;
        }

    }
}
