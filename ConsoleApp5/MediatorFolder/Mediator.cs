using ConsoleApp5.EmployeeFolder;

namespace ConsoleApp5.MediatorFolder
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Employee employee);
    }
}
