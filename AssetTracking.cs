using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema
{
    class AssetTracking
    {
        public List<AssetTracking> _trackingHistory=new List<AssetTracking>();
        string from, to;
        Asset a;
        public AssetTracking(string loc1,string loc2, Asset A)
        {
            this.from = loc1;
            this.to = loc2;
            this.a = A;

        }
        private List<Asset> _assets;
        private List<Asset> Assets { get; set; }

        public void Print()
        {
            for(int i=0;i<this._trackingHistory.Count;i++)
            {
                Console.Write("From :" + _trackingHistory[i].from + " To: " + _trackingHistory[i].to);
                Console.WriteLine();
                _trackingHistory[i].a.Print();
            }
        }

        public void AddAsset(Asset a)
        {
            this._assets.Add(a);
        }
        public void RemoveAsset(Asset a)
        {
        }
        public void Tracker(AssetTracking A) { this._trackingHistory.Add((A)); }
    }
}
