using SkolyNome.MaintenanceSystem;
namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pro testovani knihovny skolyNome");
            Worker user = new Worker();
            user.FirstName = "TestFirstName";
            user.LastName = "TestLastName";
            user.Status = Status.active;
            user.UserRole = Role.admin;
            user.Salary = 40000;
            //user.UserName = ""; //Nejde je nastaven jako private
            user.ChangeUserName("userName001");
            User copiedUser = user.CreateCopy();
            Console.WriteLine(user.ToString());
            Console.WriteLine(copiedUser.ToString());
            WorkOrder wo = new WorkOrder();
            wo.AddWorkerToOrder(user);
            //wo.AddWorkerToOrder(copiedUser); //Tady spadne musime poresit
            Console.WriteLine(wo.PrintAssignedWorkers());

        }
    }
}
