using System.Collections.Generic;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            if (x.Area < y.Area)
            {
                return 1;
            }
            else if(x.Area > y.Area)
            {
                return -1;
            }
            return 0;
        }
    }
}
