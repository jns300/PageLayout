using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageLayout.Core
{
    /// <summary>
    /// Represents a double page, which consists of two pages 
    /// (<see cref="PageLayout.Core.Page"/>).
    /// It is used to reflect one side of folding pages.
    /// </summary>
    class DoublePage
    {
        private int index;
        private int allPageNumber;
        public DoublePage(int index, int allPageNumber)
        {
            this.index = index;
            this.allPageNumber = allPageNumber;
            LeftPage = new Page(allPageNumber);
            RightPage = new Page(allPageNumber);
        }
        public Page LeftPage
        {
            get;
            private set;
        }
        public Page RightPage
        {
            get;
            private set;
        }
    }
}
