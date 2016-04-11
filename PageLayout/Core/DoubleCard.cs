using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageLayout.Core
{
    /// <summary>
    /// Represents a double card. It consists of two cards or, in other words, of
    /// two double pages. It contains four single pages. Two on the front and
    /// two on the back.
    /// </summary>
    class DoubleCard
    {
        DoublePage topPage;
        DoublePage bottomPage;

        private int index;

        public DoubleCard(int index, int allPageNumber)
        {
            this.index = index;
            topPage = new DoublePage(index * 2, allPageNumber);
            bottomPage = new DoublePage(index * 2 + 1, allPageNumber);
        }

        public Page FirstLeftPage
        {
            get { return bottomPage.LeftPage; }
        }

        public Page SecondLeftPage
        {
            get { return topPage.LeftPage; }
        }

        public Page FirstRightPage
        {
            get { return bottomPage.RightPage; }
        }

        public Page SecondRightPage
        {
            get { return topPage.RightPage; }
        }

        internal void AddTopPageNumbers(List<int> list)
        {
            list.Add(SecondLeftPage.PageNumber);
            list.Add(SecondRightPage.PageNumber);
        }
        internal void AddBottomPageNumbers(List<int> list)
        {
            list.Add(FirstRightPage.PageNumber);
            list.Add(FirstLeftPage.PageNumber);
        }
    }
}
