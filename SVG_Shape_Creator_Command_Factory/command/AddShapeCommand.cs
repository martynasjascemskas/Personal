namespace command
{
    public class AddShapeCommand : ICommand
    {
        private SVG_Shape_Creator_Command_Factory.Canvas _receiver;
        private SVG_Shape_Creator_Command_Factory.AbstractShape _shape;

        public AddShapeCommand(SVG_Shape_Creator_Command_Factory.Canvas receiver, SVG_Shape_Creator_Command_Factory.AbstractShape shape)
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