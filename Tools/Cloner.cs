using System;
using System.Collections.Generic;
using System.Text;

namespace Cloner
{
    public interface ICloner<T>
    {
        T Clone();
    }

    public class ListCloner<T>
    {
        public static List<T> Clone(List<T> list)
        {
            List<T> ans = new List<T>();
            foreach (T item in list)
            {
                ICloner<T> clon = item as ICloner<T>;
                ans.Add(clon.Clone());
            }
            return ans;
        }
    }
}
