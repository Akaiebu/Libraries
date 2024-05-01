using Libraries.Classes;

namespace Library.Classes
{
    public class Books : Interfaces
    {
        public List<string> Names = new List<string> { "Tarix", "Riyaziyyat", "Fizika", "Kimya" };
        public  void GetBookList()
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
        public  void GetDeleteBookList(string removeBook)
        {
            foreach (var name in Names)
            {
                if (name == removeBook)
                {
                    Names.Remove(removeBook);
                    Console.WriteLine("Kitab icarəyə götürüldü");
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kitab tapılmadı");
            Console.WriteLine();
        }
        public  void GetFindBook(string bookToFind)
        {
            foreach (var book in Names)
            {
                if (bookToFind == book)
                {
                    Console.WriteLine();
                    Console.WriteLine("Kitab tapıldı: " + book);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kitab tapılmadı");
            Console.WriteLine();
        }
    }
}
