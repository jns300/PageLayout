using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageLayout.Core
{
    /// <summary>
    /// Represents a single page which can by placed on a card. Page contains
    /// 1 based number representing page number.
    /// </summary>
    public class Page
    {
        private int pageIndex;
        private bool isPresent;
        private int allPageNumber;

        public Page(int allPageNumber)
        {
            this.allPageNumber = allPageNumber;
        }

        public void SetPageIndex(int index)
        {
            pageIndex = index;
            isPresent = index < allPageNumber;
        }
        public int PageNumber
        {
            get
            {
                if (IsPresent)
                    return pageIndex + 1;
                else
                    // Empty page index.
                    // When pages are numbered then it must by unique.
                    return pageIndex + 1;
            }
        }
        public bool IsPresent
        {
            get
            {
                return isPresent;
            }
        }
    }
}
