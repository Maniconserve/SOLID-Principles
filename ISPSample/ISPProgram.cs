using System;

namespace ISP_Compliant
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.StartWork();
            robot.StopWork();

            HumanWorker human = new HumanWorker();
            human.StartWork();
            human.StopWork();
            human.TakeBreak();  // Now only the HumanWorker has this method
        }
    }

    // Segregated interface with only essential methods
    public interface IWorker
    {
        void StartWork();
        void StopWork();
    }

    // Additional interface for workers who can take breaks
    public interface IWorkBreak
    {
        void TakeBreak();
    }

    public class Robot : IWorker
    {
        public void StartWork() { Console.WriteLine("Robot starts working..."); }
        public void StopWork() { Console.WriteLine("Robot stops working..."); }

        // No need for TakeBreak method, so it doesn't implement IWorkBreak
    }

    public class HumanWorker : IWorker, IWorkBreak
    {
        public void StartWork() { Console.WriteLine("Human starts working..."); }
        public void StopWork() { Console.WriteLine("Human stops working..."); }
        public void TakeBreak() { Console.WriteLine("Human is taking a break..."); }
    }
}
