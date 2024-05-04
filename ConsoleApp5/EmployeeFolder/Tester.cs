using ConsoleApp5.MediatorFolder;

namespace ConsoleApp5.EmployeeFolder
{
    public class Tester : Employee
    {
        public Tester(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение для тестировощика: {message}");
        }
    }
}
