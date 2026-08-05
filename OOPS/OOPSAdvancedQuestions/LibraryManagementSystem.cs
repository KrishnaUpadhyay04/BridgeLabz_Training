using System;

namespace LibraryManagementSystem
{
    interface IReservable
    {
        void ReserveItem();

        bool CheckAvailability();
    }

    abstract class LibraryItem
    {
        public string ItemId { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        private string BorrowerName;
        private string BorrowerPhoneNumber;
        private bool IsReserved;

        public LibraryItem()
        {
            ItemId = "";
            Title = "Unknown";
            Author = "Unknown";
            BorrowerName = "";
            BorrowerPhoneNumber = "";
            IsReserved = false;
        }

        public LibraryItem(string itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
            BorrowerName = "";
            BorrowerPhoneNumber = "";
            IsReserved = false;
        }

        public void BorrowItem(string borrowerName, string phoneNumber)
        {
            BorrowerName = borrowerName;
            BorrowerPhoneNumber = phoneNumber;
            IsReserved = true;
        }

        public void ReturnItem()
        {
            BorrowerName = "";
            BorrowerPhoneNumber = "";
            IsReserved = false;
        }

        public bool IsAvailable()
        {
            return !IsReserved;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item Id : {ItemId}");
            Console.WriteLine($"Title   : {Title}");
            Console.WriteLine($"Author  : {Author}");
            Console.WriteLine($"Available: {IsAvailable()}");
        }

        protected void MarkReserved()
        {
            IsReserved = true;
        }
    }

    class Book : LibraryItem, IReservable
    {
        public Book() : base()
        {
        }

        public Book(string itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem()
        {
            MarkReserved();
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    class Magazine : LibraryItem, IReservable
    {
        public Magazine() : base()
        {
        }

        public Magazine(string itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem()
        {
            MarkReserved();
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

    class DVD : LibraryItem, IReservable
    {
        public DVD() : base()
        {
        }

        public DVD(string itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            MarkReserved();
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }
}
