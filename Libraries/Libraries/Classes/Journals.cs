using Libraries.Classes;

namespace Library.Classes
{
    internal class Journals : Interfaces
    {
        public List<string> Names = new List<string> { "National Geographic", "Time Magazine", "The New Yorker", "Vogue" };
        public  void GetBookList()
        {
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        public void GetAddBookList(string newBook)
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
                    Console.WriteLine("Jurnal icarəyə götürüldü");
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Jurnal tapılmadı");
            Console.WriteLine();
        }
        public void GetFindBook(string bookToFind)
        {
            bool found = false;
            foreach (var book in Names)
            {
                if (book.Equals(bookToFind))
                {
                    Console.WriteLine("Jurnal tapıldı: " + book);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Jurnal tapılmadı!!!");
            }
        }
    }
}
