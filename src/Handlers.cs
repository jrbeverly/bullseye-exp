namespace Experiments.BullsEye
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }

    public sealed class AddCommandHandler : ICommandHandler<AddCommand>
    {
        private readonly Store _store;

        public AddCommandHandler(Store store)
        {
            _store = store;
        }

        public void Handle(AddCommand command)
        {
            _store.Result = command.FirstParam + command.SecondParam;
        }
    }

    public sealed class SubtractCommandHandler : ICommandHandler<SubtractCommand>
    {
        private readonly Store _store;

        public SubtractCommandHandler(Store store)
        {
            _store = store;
        }

        public void Handle(SubtractCommand command)
        {
            _store.Result = command.FirstParam + command.SecondParam;
        }
    }

    public sealed class MultiplyCommandHandler : ICommandHandler<MultiplyCommand>
    {
        private readonly Store _store;

        public MultiplyCommandHandler(Store store)
        {
            _store = store;
        }

        public void Handle(MultiplyCommand command)
        {
            _store.Result = command.FirstParam + command.SecondParam;
        }
    }

    public sealed class DivideCommandHandler : ICommandHandler<DivideCommand>
    {
        private readonly Store _store;

        public DivideCommandHandler(Store store)
        {
            _store = store;
        }

        public void Handle(DivideCommand command)
        {
            _store.Result = command.FirstParam + command.SecondParam;
        }
    }
}
