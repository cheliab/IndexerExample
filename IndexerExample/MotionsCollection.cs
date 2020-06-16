using System.Collections.Generic;
using System.Net.Sockets;

namespace IndexerExample
{
    public class MotionsCollection
    {
        protected List<string> _list;

        public MotionsCollection()
        {
            _list = new List<string>();
        }

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

        public void Add(string motion)
        {
            _list.Add(motion);
        }
    }
}