using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageLayout.Core;

namespace PageLayoutTest
{
    [TestClass]
    public class BrochureTest
    {
        [TestMethod]
        public void TestGetPages()
        {
            checkPages(4, 2, 1, new int[] { 4, 1, 5, 5, 2, 3 }, false);

            checkPages(3, 2, 1, new int[] { 4, 1, 4, 4, 2, 3 }, false);

            checkPages(5, 2, 1, new int[] { 8, 1, 6, 3, 2, 7, 4, 5 }, false);

            checkPages(7, 2, 1, new int[] { 8, 1, 6, 3, 2, 7, 4, 5 }, false);

            checkPages(8, 2, 1, new int[] { 8, 1, 6, 3, 2, 7, 4, 5 }, false);

            checkPages(16, 2, 1, new int[] { 16, 1, 14, 3, 2, 15, 4, 13, 12, 5, 10, 7, 6, 11, 8, 9 }, false);
        }
        [TestMethod]
        public void TestGetPagesManyColumns()
        {
            checkPages(18, 4, 2, new int[] {
                20, 1, 18, 3, 16, 5, 14, 7, 12, 9, 19, 19, 19, 19, 19, 19,
                4, 17, 2, 19, 8, 13, 6, 15, 19, 19, 10, 11}, false);

            checkPages(5, 2, 3, new int[] {
                8, 1, 6, 3, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 4, 5, 2, 7 }, false);
        }

        [TestMethod]
        public void TestFillWithSingleCard()
        {
            checkPages(4, 2, 1, new int[] { 4, 1, 4, 1, 2, 3, 2, 3 }, true);

            checkPages(3, 2, 1, new int[] { 4, 1, 4, 1, 2, 3, 2, 3 }, true);

            checkPages(5, 2, 2, new int[] {
                8, 1, 8, 1, 8, 1, 8, 1, 2, 7, 2, 7, 2, 7, 2, 7,
                6, 3, 6, 3, 6, 3, 6, 3, 4, 5, 4, 5, 4, 5, 4, 5 }, true);
        }
        [TestMethod]
        public void TestFuzz()
        {
            Random rand = new Random();
            for (int i = 0; i < 200; i++)
            {
                checkPages(rand.Next(1, 30), rand.Next(1, 15), rand.Next(1, 15), null,
                    Convert.ToBoolean(rand.Next(2)));
            }
        }

        private void checkPages(int pages, int rows, int columns, int[] expected, bool fillWithSingleCard)
        {
            Brochure brochure;
            List<int> actual;
            brochure = new Brochure(pages, rows, columns, fillWithSingleCard);
            actual = brochure.GetPrintingPageNumbers();
            if (expected != null)
                CollectionAssert.AreEqual(expected, actual, "Page number are invalid.");

            // Checks whether all page numbers were used and whether page index
            // is not out of bound.
            int maxPages = pages;
            if (pages % 4 > 0)
                maxPages = pages + 4 - pages % 4;
            bool[] presence = new bool[maxPages];
            int distinctPages = 0;
            for (int i = 0; i < actual.Count; i++)
            {
                int pageNum = actual[i];
                Assert.IsTrue(pageNum > 0 && pageNum <= maxPages + 1, "Page number is out of bound.");
                int pageIndex = pageNum - 1;
                if (pageIndex < maxPages)
                {
                    if (!presence[pageIndex])
                        distinctPages++;
                    presence[pageIndex] = true;
                }// In other case page index indicates empty (dummy) page.
            }
            Assert.AreEqual(distinctPages, maxPages, "Incorrect number of distinct pages.");
        }
    }
}
