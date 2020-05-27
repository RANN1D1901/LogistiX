using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema
{
    class Asset
    {
        private string _name;
        private int _code;
        public string Name {get;set;}
        public string Code { get; set; }
        public void Print()
        {
            Console.WriteLine(this._name);
            Console.WriteLine(this._code.ToString
                ());
        }
        public Asset(string name, int code)
        {
            this._name = name;
            this._code = code;
        }
    }
}
