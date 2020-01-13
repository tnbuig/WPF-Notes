 public class WeakEvent
    {
        public WeakEventHandler ValueChanged = new WeakEventHandler();
        
        public static WeakEvent operator +(WeakEvent w, EventHandler e)
        {
            w.ValueChanged.AddHandler(e);
            return w;
        }

        public static WeakEvent operator -(WeakEvent w, EventHandler e)
        {
            w.ValueChanged.RemoveHandler(e);
            return w;
        }


        /// <summary>
        /// Occurs when value of this variable is changed.
        /// </summary>
        //public event EventHandler ValueChanged
        //{
        //    add { _valueChanged.AddHandler(value); }
        //    remove { _valueChanged.RemoveHandler(value); }
        //}
    }
