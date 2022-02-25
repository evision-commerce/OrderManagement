using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Uniconta.Common;

namespace OrderManagement
{
    public static class Utils
    {
        public static Criterias CRIT => new Criterias();
        public class Criterias
        {
            private List<PropValuePair> _valuePairs;

            public List<PropValuePair> ValuePairs
            {
                get { return _valuePairs ??= new List<PropValuePair>(); }
            }
            public Criterias Add(string pKey, string pValue)
            {
                ValuePairs.Add(PropValuePair.GenereteWhereElements(pKey, typeof(string), pValue));
                Criterias that = this;
                return that;
            }
            public Criterias Add(string pKey, int pValue)
            {
                ValuePairs.Add(PropValuePair.GenereteWhereElements(pKey, typeof(int), Convert.ToString(pValue)));
                Criterias that = this;
                return that;
            }
            public Criterias Add(string pKey, bool pValue)
            {
                ValuePairs.Add(PropValuePair.GenereteWhereElements(pKey, typeof(bool), Convert.ToString(pValue)));
                Criterias that = this;
                return that;
            }
            public Criterias Add(string pKey, long pValue)
            {
                ValuePairs.Add(PropValuePair.GenereteWhereElements(pKey, typeof(long), Convert.ToString(pValue)));
                Criterias that = this;
                return that;
            }
            public Criterias AddPaging(int pFrom, int pPageSize)
            {
                ValuePairs.Add(PropValuePair.GenereteSkipN(pFrom));
                ValuePairs.Add(PropValuePair.GenereteTakeN(pPageSize));
                Criterias that = this;
                return that;
            }
            public Criterias AddSortBy(string pPropName, bool pDesc)
            {
                ValuePairs.Add(PropValuePair.GenereteOrderByElement(pPropName, pDesc));
                Criterias that = this;
                return that;
            }
        }
        public static void ShowInformation(string message, string caption)
        {
           // MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void ShowWarning(string message, string caption)
        {
            //MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void ShowError(string message, string caption)
        {
            //MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
