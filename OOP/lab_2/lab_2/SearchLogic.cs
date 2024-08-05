using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public static class SearchLogic
    {
        public static IEnumerable<T> CombinedSearch<T>(IEnumerable<T> collection, string input1, string input2, string input3)
        {
            foreach (var obj in collection)
            {
                string objStr = obj.ToString().ToLower();
                if (objStr.Contains(input1.ToLower()) ||
                    objStr.Contains(input2.ToLower()) ||
                    objStr.Contains(input3.ToLower()))
                {
                    yield return obj;
                }
            }
        }    }
}
