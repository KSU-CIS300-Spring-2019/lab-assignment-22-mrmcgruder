using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{

    class TrieWithOneChild : ITrie
    {
        private bool _hasEmptyString;
        private ITrie _children;
        private char _childLabel;

        public TrieWithOneChild(string s, bool b)
        {
            throw new ArgumentException();
        }
      
        
        public ITrie Add(string s)
        {
            if (s.Length == 0)
            {
                _hasEmptyString = true;
                return this;
            }
            else if (s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            else if(s[0]== _childLabel)
            {
              _children = _children.Add(s.Substring(1));
            }
            else
            {
                return new TrieWithOneChild(s,_hasEmptyString).Add(s.Substring(1));
            }
            return this;
        }

        public bool Contains(string s)
        {
            if (s.Length == 0)
            {
                return _hasEmptyString;
            }
            else if(s[0] == _childLabel)
            {
                return _children.Contains(s.Substring(1));
            }
            else
            {
                return false;
            }
            
        }
        
    }
}
