/* absract class*/
using payoda;
using simpleprograms;

/*MyPetsInterface myPets = new (2, 2, 4, "cat");
MyPetsInterface myPets1 = new (2, 2, 4, "dog");

Animal.Eat();
Animal.Sleep();

myPets.Aboutme();
Console.WriteLine(myPets.Name);
myPets.Sound();

myPets.Aboutme();
Console.WriteLine(myPets1.Name);
myPets.Sound();
*/

/*
//Overloading polymorphism - compiletime - static  ploymorphism
BankDetails bankDetails = new(12345, 1234567890, 2000, "kiruba", "Inactive");
Boolean cont = true;
while(cont)
{
    Console.WriteLine("Enter 1: Cusid 2: accno 3:name");
    int ch=Convert.ToInt32(Console.ReadLine());
    switch(ch)
    {
        case 1:
            int cusid=Convert.ToInt32(Console.ReadLine());
            bankDetails.FetchAccounttDetails(cusid);
            break;
        case 2:
            long accno = Convert.ToInt64(Console.ReadLine());
            bankDetails.FetchAccounttDetails(accno);
            break;
        case 3:
            String? name = Console.ReadLine();
            bankDetails.FetchAccounttDetails(name);
            break;
        default:
            break;
    }
}
*/

Book book1 = new(1001, "Revolution 2020", " chetan bhagat", true);
Book book2 = new(1002, "Calpa mia", "john", true);
Book book3 = new(1003, "WorldWarI", "genie", false);
Book book4 = new(1004, "harry potter", "suriya", true);

Library.book.Add(book1);
Library.book.Add(book2);
Library.book.Add(book3);
Library.book.Add(book4);

Library library = new Library();
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the title of the book to borrow");
        string ?title = Console.ReadLine();
        Console.WriteLine(title);
        library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the title of the book to return");
        string? title = Console.ReadLine();
        library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        library.DisplayBookDetails();
    }
    else if (choice == 4)
    {
        break;
    }


}





