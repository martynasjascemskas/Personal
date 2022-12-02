namespace command
{
    public class AddShapeCommand : ICommand
    {
        private assignment4.Canvas _receiver;
        private assignment4.AbstractShape _shape;

        public AddShapeCommand(assignment4.Canvas receiver, assignment4.AbstractShape shape)
        {
            this._receiver = receiver;
            this._shape = shape;
        }

        public override void Execute()
        {
            this._receiver.AddShape(_shape);
        }

        public override void Unexecute()
        {
            this._receiver.RemoveShape(_shape);
        }
    }
}