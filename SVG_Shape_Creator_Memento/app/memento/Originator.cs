namespace app.memento
{
    class Originator
    {
        private Canvas _state;

        public Originator(Canvas state){
            this._state = state;
        }

        public Canvas getCurrentState()
        {
            return this._state;
        }

        // Saves the current state inside a memento.
        public Memento saveToMemento()
        {
            return new Memento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void restoreFromMemento(Memento memento)
        {
            this._state = memento.getState();
        }
        
    }
}
//