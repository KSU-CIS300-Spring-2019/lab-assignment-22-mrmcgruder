using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    
    public class TrieWithNoChildren : ITrie
    {
        private bool _hasEmptyString;
        private ITrie _children;
        private char _childLabel;
        public ITrie Add(string s)
        {
            if (s.Length == 0)
            {
                _hasEmptyString = true;
            }
            else if (s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            else
            {
                return new TrieWithOneChild(s, _hasEmptyString);
            }
            return this;
        }

        public bool Contains(string s)
        {
            if (s.Length == 0)
            {
                return _hasEmptyString;
            }
            return false;
        }
    }
}
