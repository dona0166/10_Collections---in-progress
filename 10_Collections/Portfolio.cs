using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class Portfolio 
    {
        
        public Portfolio()
        {

        }
        public List<Asset> a = new List<Asset>();
        public Portfolio(List<Asset> alist)
        {
           a = alist;
        }
        public double result;
        public double GetTotalValue()
        {
            foreach(Asset element in a)
            {
                result += element.GetValue();
            }
            return result;
        }

        public void AddAsset(Asset anobject)
        {

            a.Add(anobject);

        }

        List<Asset> alist = new List<Asset>();
        public IList<Asset> GetAssets()
        {
            return a;
        }

        public string GetAssetByName(string v)
        {
            string result = "";
            foreach (Asset someasset in a)
            {

                //if ((object)someasset.ToString() == v)
                //{
                //    result = someasset.GetType().Name;
                //}
                result = someasset.GetType().Name;
                
            }
            return result;
        }

        //public string GetName(Asset someassetname)
        //{
        //    return someassetname.ToString();
        //}
    }
}