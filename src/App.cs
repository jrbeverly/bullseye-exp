
namespace Experiments.BullsEye
{
    public class App
    {
        private readonly Store _store;
        private readonly ICommandHandler<AddCommand> _addHandler;
        private readonly ICommandHandler<SubtractCommand> _subtractHandler;
        private readonly ICommandHandler<MultiplyCommand> _multiplyHandler;
    
        private readonly ICommandHandler<DivideCommand> _divideHandler;

        public App(
            Store store,
            ICommandHandler<AddCommand> add,
            ICommandHandler<SubtractCommand> subtract,
            ICommandHandler<MultiplyCommand> multiply,
            ICommandHandler<DivideCommand> divide
            )
        {
            _store = store;
            _addHandler = add;
            _subtractHandler = subtract;
            _divideHandler = divide;
            _multiplyHandler = multiply;
        }

        public static App Create()
        {
            var store = new Store();
            var app = new App(
                store,
                new AddCommandHandler(store),
                new SubtractCommandHandler(store),
                new MultiplyCommandHandler(store),
                new DivideCommandHandler(store)
            );
            return app;
        }

        public double Add(double first, double second)
        {
            var cmd = new AddCommand(first, second);
            _addHandler.Handle(cmd);

            return _store.Result;
        }

        public double Subtract(double first, double second)
        {
            var cmd = new SubtractCommand(first, second);
            _subtractHandler.Handle(cmd);

            return _store.Result;
        }

        public double Multiply(double first, double second)
        {
            var cmd = new MultiplyCommand(first, second);
            _multiplyHandler.Handle(cmd);

            return _store.Result;
        }

        public double Divide(double first, double second)
        {
            var cmd = new DivideCommand(first, second);
            _divideHandler.Handle(cmd);

            return _store.Result;
        }
    }
}

