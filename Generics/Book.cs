namespace Generics
{
    public class Book : Product
    {
        /* we don't need a separate title for Book becuae it's inheriting title from Product
        public string Title { get; set; }
        */
        public int Isbn { get; set; }
    }
}
