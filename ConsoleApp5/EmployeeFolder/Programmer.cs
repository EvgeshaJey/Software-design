using ConsoleApp5.MediatorFolder;

namespace ConsoleApp5.EmployeeFolder
{
    public class Programmer : Employee
    {
        public Programmer(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение для программиста: {message}");
        }
    }
}
