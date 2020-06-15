using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace IndexerExample
{
    public class LinesCollection
    {
        protected List<string> _list;

        public LinesCollection()
        {
            _list = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                if (index > (_list.Count - 1))
                {
                    throw new Exception("Нету столько строк брат!");
                }
                
                return _list[index];
            }
        }

        public void Add(string newLine)
        {
            _list.Add(newLine);
        }
    }
}