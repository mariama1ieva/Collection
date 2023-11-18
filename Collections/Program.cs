using Collections;

Phone phonebook = new Phone();

phonebook.AddNumber();

while (true)
{
    Console.WriteLine("Please choose the operation:");
    Console.WriteLine("1.Add New Number");
    Console.WriteLine("2.Delete Existing Number");
    Console.WriteLine("3.Update Existing Number");
    Console.WriteLine("4.List Phonebook");
    Console.WriteLine("5.Search in Phonebook");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            phonebook.AddNewNumber();
            break;
        case 2:
            phonebook.DeleteNumber();
            break;
        case 3:
            phonebook.UpdateNumber();
            break;
        case 4:
            phonebook.ListPhonebook();
            break;
        case 5:
            phonebook.Search();
            break;
        default:
            Console.WriteLine("Invalid option,Enter again:");
            break;
    }
}

