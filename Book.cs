using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabase
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool GoodCondition { get; set; }
        public bool IsCheckedOut { get; set; }


        public Book(string title, string author, string genre, bool goodCondition, bool isCheckedOut)
        {
            //Setting attributes to user provided values
            Title = title;
            Author = author;
            Genre = genre;
            GoodCondition = goodCondition;
            IsCheckedOut = isCheckedOut;
        }
    }

    //Derived class (child)
    class CoverType : Book
    {
        public bool HardCover { get; set; } = false; //New attribute: hard cover or paperback

        public CoverType(string title, string author, string genre, bool goodCondition, bool isCheckedOut, bool hardCover): 
            base (title, author, genre, goodCondition, isCheckedOut)
        {
            HardCover = hardCover;
        }
    }

    //Derived class
    class EBook : Book 
    {
        public int AudioLength { get; set; } //New attribute: length of audio book in hours
        public string NarratorName { get; set; }

        public EBook(string title, string author, string genre, bool goodCondition, bool isCheckedOut, int audioLength, string narratorName): 
            base(title, author, genre, goodCondition, isCheckedOut)
        {
            AudioLength = audioLength;
            NarratorName = narratorName;
        }
    }

    class Magazine : Book
    {
        public int IssueNumber { get; set; } //New attribute: issue number of magazine
        public string MonthIssue { get; set; } //New attribute: month of magazine issue
        public string Publisher { get; set; } //New attribute: publisher of magazine

        public Magazine(string title, string publisher, int issueNumber, string monthIssue,bool goodCondition, bool isCheckedOut):
            base(title, publisher, "Magazine", goodCondition, isCheckedOut)
        {
            Publisher = publisher;
            IssueNumber = issueNumber;
            MonthIssue = monthIssue;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Issue Number: {IssueNumber}, Month: {MonthIssue}, Publisher: {Publisher}");
        }
    }
}
