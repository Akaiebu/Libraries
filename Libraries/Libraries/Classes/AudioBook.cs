using Libraries.Classes;

namespace Library.Classes
{
    internal class AudioBook : Interfaces
    {
        public List<string> Names = new List<string> { "Becoming", "Educated: A Memoir", "Born a Crime: Stories from a South African Childhood", "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones" };
        public void GetBookList()
        {
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        public  void GetAddBookList(string newBook)
        {
            Names.Add(newBook);
        }
        public void GetDeleteBookList(string removeBook)
        {
            foreach (var name in Names)
            {
                if (name == removeBook)
                {
                    Names.Remove(removeBook);
                    Console.WriteLine("Səsli kitab icarəyə götürüldü");
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Səsli Kitab tapılmadı");
            Console.WriteLine();
        }
        public void GetFindBook(string bookToFind)
        {
            bool found = false;
            foreach (var book in Names)
            {
                if (book.Equals(bookToFind))
                {
                    Console.WriteLine("Səsli kitab tapıldı: " + book);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Səsli kitab tapılmadı!!!");
            }
        }
    }
}
