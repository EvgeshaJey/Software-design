using ConsoleApp5.MediatorFolder;

namespace ConsoleApp5.EmployeeFolder
{
    public class TeamLead : Employee
    {
        public TeamLead(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение для Team lead: {message}");
        }
    }
}
