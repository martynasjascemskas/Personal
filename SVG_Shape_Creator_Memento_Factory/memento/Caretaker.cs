namespace SVG_Shape_Creator_Memento_Factory.memento
{
    class Caretaker
    {
        private List<Memento> savedCanvases = new List<Memento>();
        private List<Memento> removedCanvasesCache = new List<Memento>();
        
        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Backup(){
            this.savedCanvases.Add(this._originator.saveToMemento());
        }
        
        public void Undo()
        {
            if(this.savedCanvases.Count == 1)
            {
                Console.WriteLine("Nothing to undo! Please redo something first!");
                return;
            }
            var newstate = this.savedCanvases.Last();
            removedCanvasesCache.Add(newstate);
            this.savedCanvases.Remove(this.savedCanvases.Last());
            this._originator.restoreFromMemento(this.savedCanvases.Last());
        }
        public void Redo()
        {
            if(this.removedCanvasesCache.Count == 0)
            {
                Console.WriteLine("Nothing to redo! Please undo something first!");
                return;
            }
            var newstate = this.removedCanvasesCache.Last();
            savedCanvases.Add(newstate);
            this.removedCanvasesCache.Remove(this.removedCanvasesCache.Last());
            this._originator.restoreFromMemento(this.savedCanvases.Last());
        }
        // public Canvas getCurrentState()
        // {
        //     Console.WriteLine("From Caretaker: Getting Momento...");
        //     return this._originator.Canvas;
        // }
    }
}