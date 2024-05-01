
namespace Libraries.Classes
{
    public  interface Interfaces
    {
        interface IBookList
        {
            void GetBooklist();
        }
        interface IAddBookList
        {
            void GetAddBookList(string newBook);
        }
        interface IDeleteBookList
        {
            void GetDeleteBookList(string removeBook);
        }
        interface IFindBook
        {
            void GetFindBook(string bookToFind);
        }
    }
}
