namespace Experiments.BullsEye
{
    public sealed class AddCommand
    {
        public double FirstParam { get; }
        public double SecondParam { get; }

        public AddCommand(double first, double second)
        {
            FirstParam = first;
            SecondParam = second;
        }
    }

    public sealed class SubtractCommand
    {
        public double FirstParam { get; }
        public double SecondParam { get; }

        public SubtractCommand(double first, double second)
        {
            FirstParam = first;
            SecondParam = second;
        }
    }

    public sealed class DivideCommand
    {
        public double FirstParam { get; }
        public double SecondParam { get; }

        public DivideCommand(double first, double second)
        {
            FirstParam = first;
            SecondParam = second;
        }
    }

    public sealed class MultiplyCommand
    {
        public double FirstParam { get; }
        public double SecondParam { get; }

        public MultiplyCommand(double first, double second)
        {
            FirstParam = first;
            SecondParam = second;
        }
    }
}
