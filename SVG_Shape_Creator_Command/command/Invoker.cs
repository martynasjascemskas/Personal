namespace command{
class Invoker
    {
        private List<ICommand> commands;
        private List<ICommand> cache;

        public Invoker()
        {
            commands = new List<ICommand>();
            cache = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
            command.Execute();
        }
        public void Undo()
        {
            if(commands.Count <= 0)
            {
                return;
            }
            var cmd = commands[^1];
            commands.Remove(cmd);
            cmd.Unexecute();
            cache.Add(cmd);
        }
        public void Redo()
        {
            if(cache.Count <= 0)
            {
                return;
            }
            var cmd = cache[^1];
            cache.Remove(cmd);
            cmd.Execute();
            commands.Add(cmd);
        }
    }
}