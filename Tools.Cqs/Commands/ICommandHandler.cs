namespace Tools.Cqs.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        IResult Execute(TCommand command);
    }
}
