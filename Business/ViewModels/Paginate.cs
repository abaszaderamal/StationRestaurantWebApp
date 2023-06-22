﻿using System.Collections.Generic;

namespace Business.ViewModels
{
    public class Paginate<T>
    {
        public Paginate()
        {
            
        }
        public Paginate(List<T> items, int currentPage, int pageCount, int allPageCount)
        {
            Items = items;
            CurrentPage = currentPage;
            PageCount = pageCount;
            AllPageCount=allPageCount;
        }

        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int AllPageCount { get; set; }
        //for post some data
        public  T Item { get; set; }


    }
}
