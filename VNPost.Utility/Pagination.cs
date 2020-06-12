using System;
using System.Collections.Generic;

namespace VNPost.Utility
{
    public class Pagination<T>
    {
        public Pagination(List<T> list, int index, int numberTInPage)
        {
            ListT = new List<T>();
            int pageBegin = index * numberTInPage;
            int pageEnd = pageBegin - numberTInPage + 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 >= pageBegin && i + 1 <= pageEnd)
                {
                    ListT.Add(list[i]);
                }
            }
            if (!(list.Count < numberTInPage))
            {
                int numberPage;
                if (list.Count / numberTInPage == 0)
                {
                    numberPage = list.Count / numberTInPage;
                }
                else
                {
                    numberPage = list.Count / numberTInPage + 1;

                }
                Begin = 1;
                End = numberPage;
            }
            else
            {
                Begin = 0;
                End = 0;
            }
        }

        public List<T> ListT { get; }
        public int Begin { get; }
        public int End { get; }
    }
}
