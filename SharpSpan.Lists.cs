using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSpan.Lists
{
    public enum MapMode { IsOdd, IsEven, IsGreaterThan, IsGreaterThanOrEqual, IsLessThan, IsLessThanOrEqual, IsEqual, IsNotEqual };

    public static class ListExpansion
    {
        public static int FindLowestNumberFast(this List<int> list)
        {
            int Lowest = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
                if (list[i] < Lowest)
                    Lowest = list[i];
            return Lowest;
        }

        public static int FindLowestNumberIndexFast(this List<int> list)
        {
            int Lowest = int.MaxValue;
            int Index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < Lowest)
                {
                    Lowest = list[i];
                    Index = i;
                }
            }
            return Index;
        }

        public static int FindHighestNumberFast(this List<int> list)
        {
            int Highest = int.MinValue;
            for (int i = 0; i < list.Count; i++)
                if (list[i] > Highest)
                    Highest = list[i];
            return Highest;
        }

        public static int FindHighestNumberIndexFast(this List<int> list)
        {
            int Highest = int.MinValue;
            int Index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > Highest)
                {
                    Highest = list[i];
                    Index = i;
                }
            }
            return Index;
        }

        public static List<bool> MapNumbers(this List<int> list, MapMode _MapMode, int Value = 0)
        {
            List<bool> NewList = new List<bool>(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                if (_MapMode == MapMode.IsOdd)
                    NewList.Add(list[i] % 2 != 0);
                if (_MapMode == MapMode.IsEven)
                    NewList.Add(list[i] % 2 == 0);
                if (_MapMode == MapMode.IsGreaterThan)
                    NewList.Add(list[i] > Value);
                if (_MapMode == MapMode.IsGreaterThanOrEqual)
                    NewList.Add(list[i] >= Value);
                if (_MapMode == MapMode.IsLessThan)
                    NewList.Add(list[i] < Value);
                if (_MapMode == MapMode.IsLessThanOrEqual)
                    NewList.Add(list[i] <= Value);
                if (_MapMode == MapMode.IsEqual)
                    NewList.Add(list[i] == Value);
                if (_MapMode == MapMode.IsNotEqual)
                    NewList.Add(list[i] != Value);
            }
            return NewList;
        }

        public static bool MapNumbersAll(this List<int> list, MapMode _MapMode, int Value = 0)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (_MapMode == MapMode.IsOdd)
                    if (!(list[i] % 2 != 0))
                        return false;
                if (_MapMode == MapMode.IsEven)
                    if (!(list[i] % 2 == 0))
                        return false;
                if (_MapMode == MapMode.IsGreaterThan)
                    if (!(list[i] > Value))
                        return false;
                if (_MapMode == MapMode.IsGreaterThanOrEqual)
                    if (!(list[i] >= Value))
                        return false;
                if (_MapMode == MapMode.IsLessThan)
                    if (!(list[i] < Value))
                        return false;
                if (_MapMode == MapMode.IsLessThanOrEqual)
                    if (!(list[i] <= Value))
                        return false;
                if (_MapMode == MapMode.IsEqual)
                    if (!(list[i] == Value))
                        return false;
                if (_MapMode == MapMode.IsNotEqual)
                    if (!(list[i] != Value))
                        return false;
            }
            return true;
        }
    }
}
