namespace command
{
    public abstract class ICommand
    {
        public abstract void Execute();
        public abstract void Unexecute();
        
    }
}