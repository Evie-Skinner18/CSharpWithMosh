using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello and welcome to Evie's Workflow Engine! Let's have a weekend of fun activities.");

            var drummingActivity = new MusicalActivity();
            var scoffinActivity = new EatingActivity();
            var ultimateRelaxationActivity = new ChillinActivity();

            var workflowEngine = new WorkflowEngine();
            workflowEngine.RegisterActivity(drummingActivity);
            workflowEngine.RegisterActivity(scoffinActivity);
            workflowEngine.RegisterActivity(ultimateRelaxationActivity);

            Console.WriteLine(workflowEngine.Run());

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("F$OCIETY YEAHHHH WE GONNA GET U BITCH");
        }
    }
}
