using System;

namespace Information
{
    /// <summary>
    /// Base abstract class for book information
    /// </summary>
    public abstract class BookInfo
    {
        // Books Information:
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }

        // Initializes common book information.
        protected BookInfo(string title, string author, int year, string type, double size)
        {
            Title = title;
            Author = author;
            Year = year;
            Type = type;
            Size = size;
        }

        // Returns formatted book information as a string.
        public abstract string GetInfo();

        // Returns book information.
        public override string ToString() => GetInfo();
    }

    /// <summary>
    /// Represents a printed (physical) book.
    /// </summary>
    public class PrintedBook : BookInfo
    {
        // Number of pages
        public int Pages { get; set; }

        // Initializes a printed book.
        public PrintedBook(string title, string author, int year, string type, int pages)
            : base(title, author, year, type, pages)
        {
            Pages = pages;
        }

        // Returns formatted printed book information.
        public override string GetInfo()
        {
            return $"{Title} - {Author} ({Year}) [Printed, {Pages} pages]";
        }
    }

    /// <summary>
    /// Represents an electronic book(EBook).
    /// </summary>
    public class EBook : BookInfo
    {
        // File size in megabytes
        public double FileSize { get; set; }

        // Initializes an electronic book.
        public EBook(string title, string author, int year, string type, double fileSize)
            : base(title, author, year, type, fileSize)
        {
            FileSize = fileSize;
        }

        // Returns formatted EBook information.
        public override string GetInfo()
        {
            return $"{Title} - {Author} ({Year}) [EBook, {FileSize} MB]";
        }
    }

    /// <summary>
    /// Represents an audio book.
    /// </summary>
    public class AudioBook : BookInfo
    {
        // Duration in minutes
        public double Duration { get; set; }

        // Initializes an audio book.
        public AudioBook(string title, string author, int year, string type, double duration)
            : base(title, author, year, type, duration)
        {
            Duration = duration;
        }

        // Returns formatted audio book information.
        public override string GetInfo()
        {
            return $"{Title} - {Author} ({Year}) [AudioBook, {Duration} min]";
        }
    }

    /// <summary>
    /// Factory class responsible for creating and cloning book objects.
    /// </summary>
    public static class BookFactory
    {

        // Creates a book instance based on the specified book type.
        public static BookInfo CreateBook(string title, string author, int year, string type, double value)
        {
            return type switch
            {
                "Printed" => new PrintedBook(title, author, year, type, (int)value),
                "EBook" => new EBook(title, author, year, type, value),
                "AudioBook" => new AudioBook(title, author, year, type, value),
                _ => throw new ArgumentException("Unknown book type")
            };
        }

        // Creates a deep copy of a book object.
        public static BookInfo Clone(BookInfo book)
        {
            return CreateBook(
                book.Title,
                book.Author,
                book.Year,
                book.Type,
                book.Size
            );
        }
    }
}


