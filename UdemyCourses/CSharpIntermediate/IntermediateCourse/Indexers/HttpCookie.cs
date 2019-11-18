using System;
using System.Collections.Generic;

namespace Indexers
{
    // need to use Dictionary for cookie
    public class HttpCookie
    {
        // key is of type string and value is the same type
        private readonly Dictionary<string, string> _dico;
        public DateTime Expiry { get; set; }


        public HttpCookie()
        {
            _dico = new Dictionary<string, string>();
        }

        // here is the indexer
        public string this[string key]
        {
            // return value of the key of the current dico
            get { return _dico[key]; }
            set { _dico[key] = value; }
        }
    }
}
