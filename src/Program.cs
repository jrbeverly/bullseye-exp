using static Bullseye.Targets;


namespace Experiments.BullsEye
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = App.Create();

            Target("default", () => System.Console.WriteLine("Hello, world!"));
            Target("add", () =>
            {
                double numFirst = 5.0;
                double numSecond = 2.5;
                var result = app.Add(numFirst, numSecond);
                System.Console.WriteLine($"add({numFirst},{numSecond}) = {result}");
            });
            Target("sub", () =>
            {
                double numFirst = 5.0;
                double numSecond = 2.5;
                var result = app.Subtract(numFirst, numSecond);
                System.Console.WriteLine($"add({numFirst},{numSecond}) = {result}");
            });
            Target("ans", DependsOn("add", "sub"));
            Target("mul", () =>
            {
                double numFirst = 5.0;
                double numSecond = 2.5;
                var result = app.Multiply(numFirst, numSecond);
                System.Console.WriteLine($"add({numFirst},{numSecond}) = {result}");
            });
            Target("div", () =>
            {
                double numFirst = 5.0;
                double numSecond = 2.5;
                var result = app.Divide(numFirst, numSecond);
                System.Console.WriteLine($"add({numFirst},{numSecond}) = {result}");
            });

            RunTargetsAndExit(args);
        }
    }
}
