using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWheelForms.Extensions
{
    public static class ListExtensions
    {
        public static void MoveElement<T>(this IList<T> list, T element, int positions)
        {
            int index = list.IndexOf(element);
            list.RemoveAt(index);
            list.Insert(index + positions, element);
        }
    }
}
