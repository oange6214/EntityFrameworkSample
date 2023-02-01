﻿namespace BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfPubliction { get; set; }
        public Author Author { get; set; }

        public override string ToString()
        {
            return $"{Title} {YearOfPubliction}";
        }
    }
}
