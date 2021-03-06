﻿using System;
using System.Collections.Generic;

namespace VNPost.Utility
{
    public class Pagination<T>
    {
        public Pagination() { }

        //Easy Pagination
        Pagination(int begin, int end, int index)
        {
            Begin = begin;
            End = end;
            Index = index;
        }

        //Complex Pagination
        public Pagination(List<T> list, int index, int numberTInPage)
        {
            ListT = new List<T>();
            Index = index;
            int pageEnd = index * numberTInPage;
            int pageBegin = pageEnd - numberTInPage + 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 >= pageBegin && i + 1 <= pageEnd)
                {
                    ListT.Add(list[i]);
                }
            }
            if (list.Count > numberTInPage)
            {
                int numberPage;
                if (list.Count % numberTInPage == 0)
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
                Begin = 1;
                End = 0;
            }
        }

        public List<T> ListT { get; }
        public int Begin { get; set; }
        public int End { get; set; }
        public int Index { get; set; }
        public Pagination<T> SortPagination()
        {
            return new Pagination<T>(Begin, End, Index);
        }
    }
}
