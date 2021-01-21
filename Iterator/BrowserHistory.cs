namespace Edgias.DesignPatterns.Iterator
{
    using System;
    using System.Collections.Generic;

    public class BrowserHistory
    {
        private List<string> _urls = new List<string>();
        public void Push(string url)
        {
            _urls.Add(url);
        }

        public string Pop()
        {
            int lastIndex = _urls.Count - 1;
            string lastUrl = _urls[lastIndex];
            _urls.Remove(lastUrl);

            return lastUrl;
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator
        {
            private readonly BrowserHistory _browserHistory;
            private int _index;

            public ListIterator(BrowserHistory browserHistory)
            {
                _browserHistory = browserHistory;
            }

            public string Current()
            {
                return _browserHistory._urls[_index];
            }

            public bool HasNext()
            {
                return (_index < _browserHistory._urls.Count);
            }

            public void Next()
            {
                _index++;
            }
        }
    }

}