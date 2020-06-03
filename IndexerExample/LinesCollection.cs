using System.Collections.Generic;

namespace IndexerExample
{
    public class LinesCollection
    {
        protected List<string> _list;

        public string this[int index]
        {
            get
            {
                return _list[index];
            }
        }
    }
}