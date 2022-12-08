using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SVG_Shape_Creator_Memento_Factory.memento
{
    public class Memento
    {
        private Canvas _state;

        public Memento(Canvas state)
        {
            this._state = state;
        }
        public Canvas getState()
        {
            return this._state;
        }
    }
}