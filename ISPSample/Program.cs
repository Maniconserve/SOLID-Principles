using System;

namespace ISP_Violation
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
            human.TakeBreak();  // Robot doesn't need this, but it's forced to implement
        }
    }

    // Large interface with more methods than necessary
    public interface IWorker
    {
        void StartWork();
        void StopWork();
        void TakeBreak();  // Not relevant for all workers, like robots
    }

    public class Robot : IWorker
    {
        public void StartWork() { Console.WriteLine("Robot starts working..."); }
        public void StopWork() { Console.WriteLine("Robot stops working..."); }

        // Irrelevant for Robot, but forced to implement
        public void TakeBreak()
        {
            throw new NotImplementedException("Robot doesn't need breaks.");
        }
    }

    public class HumanWorker : IWorker
    {
        public void StartWork() { Console.WriteLine("Human starts working..."); }
        public void StopWork() { Console.WriteLine("Human stops working..."); }
        public void TakeBreak() { Console.WriteLine("Human is taking a break..."); }
    }
}
