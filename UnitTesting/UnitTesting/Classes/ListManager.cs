using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class ListManager
    {
        public void AddElement(List<int> list, int Number)
        {
            list.Add(Number);
        }

        public void RemoveElement(List<int> list, int Number)
        {
            list.Remove(Number);
        }

        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}
