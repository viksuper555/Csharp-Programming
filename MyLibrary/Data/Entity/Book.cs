﻿namespace Data.Entity
{
    public class Book
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ISBN { get; set; }

        public int Pages { get; set; }
    }
}
