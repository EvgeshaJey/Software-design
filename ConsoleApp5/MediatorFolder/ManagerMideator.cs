using ConsoleApp5.EmployeeFolder;

namespace ConsoleApp5.MediatorFolder
{
    public class ManagerMideator : Mediator
    {
        public Programmer Programmer { get; set; }
        public TeamLead TeamLead { get; set; }
        public Tester Tester { get; set; }

        public override void Send(string msg, Employee employee)
        {
            if (TeamLead == employee)
                TeamLead.Notify(msg);
            else if (Programmer == employee)
                Programmer.Notify(msg);
            else if (Tester == employee)
                Tester.Notify(msg);
        }
    }
}
