using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageLayout.Core
{
    /// <summary>
    /// Represents a brochure with some folding cards.
    /// On a single printing card may by placed many double (folding) cards.
    /// This implemetation allows to layout cards in rows and columns.
    /// </summary>
    public class Brochure
    {
        List<DoubleCard> cards = new List<DoubleCard>();

        int allPageNumber;

        int rowsInPrintingPage;

        int columnsInPrintingPage;

        bool fillWithSingleCard;

        /// <summary>
        /// Creates and initalizes brochure pages.
        /// </summary>
        /// <param name="allPageNumber">number of all pages</param>
        /// <param name="rowsInPringingPage">number of rows in printing page for double cards</param>
        /// <param name="columnsInPrintingPage">number of columns in printing page for double cards</param>
        /// <param name="fillWithSingleCard">whether to fill printing pages with 
        /// single consecutive double cards</param>
        public Brochure(int allPageNumber, int rowsInPrintingPage, int columnsInPrintingPage,
            bool fillWithSingleCard)
        {
            this.allPageNumber = allPageNumber;
            this.rowsInPrintingPage = rowsInPrintingPage;
            this.columnsInPrintingPage = columnsInPrintingPage;
            this.fillWithSingleCard = fillWithSingleCard;
            initialize();
        }

        private void initialize()
        {
            int doubleCardNum = (int)Math.Ceiling(allPageNumber / 4.0);
            for (int i = 0; i < doubleCardNum; i++)
            {
                cards.Add(new DoubleCard(i, allPageNumber));
            }
            int pageIndex = 0;
            foreach (Page page in GetEnumerablePage())
            {
                page.SetPageIndex(pageIndex++);
            }
            if (fillWithSingleCard)
            {
                DuplicateCards();
            }
        }

        private void DuplicateCards()
        {
            int duplicateNum = rowsInPrintingPage * columnsInPrintingPage;
            List<DoubleCard> duplicates = new List<DoubleCard>();
            foreach (DoubleCard card in cards)
            {
                for (int i = 0; i < duplicateNum; i++)
                {
                    duplicates.Add(card);
                }
            }
            cards.Clear();
            cards.AddRange(duplicates);
            duplicates.Clear();
        }
        public List<int> GetPrintingPageNumbers()
        {
            List<int> list = new List<int>();
            int cardCount = cards.Count;
            int k = 0;
            while (k < cardCount)
            {
                for (int rowIdx = 0; rowIdx < rowsInPrintingPage; rowIdx++)
                {
                    for (int colIdx = 0; colIdx < columnsInPrintingPage; colIdx++)
                    {
                        int cardIdx = k + rowIdx * columnsInPrintingPage + colIdx;
                        if (cardIdx < cardCount)
                        {
                            cards[cardIdx].AddBottomPageNumbers(list);
                        }
                        else
                        {
                            // Sgingle double page has two pages.
                            AddEmptyPages(list);
                        }
                    }
                }
            
                for (int rowIdx = 0; rowIdx < rowsInPrintingPage; rowIdx++)
                {

                    if (rowIdx * columnsInPrintingPage >= cardCount)
                        break;
                    for (int colIdx = columnsInPrintingPage - 1; colIdx >= 0; colIdx--)
                    {
                        int cardIdx = k + rowIdx * columnsInPrintingPage + colIdx;
                        if (cardIdx < cardCount)
                            cards[cardIdx].AddTopPageNumbers(list);
                        else
                        {
                            AddEmptyPages(list);
                        }
                    }
                }
                k += rowsInPrintingPage * columnsInPrintingPage;
            }
            return list;
        }

        private void AddEmptyPages(List<int> list)
        {
            list.Add(allPageNumber + 1);
            list.Add(allPageNumber + 1);
        }
        public IEnumerable<Page> GetEnumerablePage()
        {
            foreach (DoubleCard card in cards)
            {
                yield return card.FirstLeftPage;
                yield return card.SecondLeftPage;
            }
            int len = cards.Count;
            for (int i = len - 1; i >= 0; i--)
            {
                DoubleCard card = cards[i];
                yield return card.SecondRightPage;
                yield return card.FirstRightPage;
            }
        }
    }
}
