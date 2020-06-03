using System.Collections.Generic;

namespace IndexerExample
{
    public class MotionsCollection
    {
        protected List<string> _list;

        public string this[int index]
        {
            get
            {
                return _list[index];
            }
        }

        public int Count
        {
            get { return _list.Count; }
        }
    }
}