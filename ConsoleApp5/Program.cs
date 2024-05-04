using ConsoleApp5.MediatorFolder;
using ConsoleApp5.EmployeeFolder;

namespace ConsloApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMideator mediator = new ManagerMideator();
            TeamLead teamLead = new TeamLead(mediator);
            Programmer programmer = new Programmer(mediator);
            Tester tester = new Tester(mediator);

            mediator.TeamLead = teamLead;
            mediator.Programmer = programmer;
            mediator.Tester = tester;

            teamLead.Send("Нужно сделать программу для паттерна ПОСРЕДНИК");
            programmer.Send("Программа для паттерна ПОСРЕДНИК готова! Нужно протестрировать");
            tester.Send("Программа для паттерна ПОСРЕДНИК протестрирована успешно!");

            //test for Github
            Console.Read();
        }
    }
}
