using ConsoleApp5.MediatorFolder;

namespace ConsoleApp5.EmployeeFolder
{
    public abstract class Employee
    {
        Mediator mediator;

        public Employee(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}
