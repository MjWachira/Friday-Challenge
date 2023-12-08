
using Friday_Challenge.MyClasses;

bool exit = false;

do
{
    Console.WriteLine("");
    Console.WriteLine("SELECT AN OPTION FOR THE FOLLOWING");
    Console.WriteLine("1: REMOVE ARRAY SPACE");
    Console.WriteLine("2: ADD A STUDENT");
    Console.WriteLine("3: REMOVE A STUDENT");
    Console.WriteLine("4: SEARCH FOR A STUDENT");
    Console.WriteLine("5: FINDING ARRAY CHUNKS");
    Console.WriteLine("6: CAPITALIZE FIRST LETTERS IN WORDS USING A PROGRAM");
    Console.WriteLine("7: CAPITALIZE USING A METHOD");
    Console.WriteLine("8: FIND THE MOST APPEARING CHARACTERS");
    Console.WriteLine("9: COUNT VOWELS IN A WORD");
    Console.WriteLine("10: REVERSE A NUMBER");
    Console.WriteLine("11: TEST PALINDROME WORDS");
    Console.WriteLine("q: QUIT");
    Console.WriteLine("");
    Console.WriteLine("OPTION:");

    string option = Console.ReadLine();

    switch (option.ToLower())
    {
        case "1":
            Console.WriteLine("");
            RemoveArraySpaces removeArraySpaces = new RemoveArraySpaces();
            removeArraySpaces.RemoveArraySpace();
            break;
        case "2":
            Console.WriteLine("");
            Trainee trainee = new Trainee();
            string student = Console.ReadLine();
            trainee.addStudent(student);
            break;
        case "3":
            Console.WriteLine("");
            Trainee traineeRemove = new Trainee();
            string student1 = Console.ReadLine();
            traineeRemove.removeStudent(student1);
            break;
        case "4":
            Console.WriteLine("");
            Trainee traineeSearch = new Trainee();
            string student2 = Console.ReadLine();
            traineeSearch.SearchStudent(student2);
            break;
        case "5":
            Console.WriteLine("");
            ArrayChunks arrayChunks = new ArrayChunks();
            int[] source = { 1, 2, 3,4,5,5,6 };
            arrayChunks.ArrayChunk(source, 3);
            break;
        case "6":
            Console.WriteLine("");
            CapitalizeWordsProgram capitalizeWordsProgram = new CapitalizeWordsProgram();
            capitalizeWordsProgram.CapitalizeWordsProg();
            break;
        case "7":
            Console.WriteLine("");
            Console.WriteLine("Enter a string to capitalize the first letter of each word:");
            string inputString = Console.ReadLine();
            string capitalizedString = CapitalizeWordsMethod.CapitalizeWords(inputString);
            Console.WriteLine(capitalizedString);
            break;
        case "8":
            Console.WriteLine("");
            MostAppearingCharacter mostAppearingCharacter = new MostAppearingCharacter();
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            mostAppearingCharacter.MostAppearing(input);
            break;
        case "9":
            Console.WriteLine("");
            CountVowels countVowels = new CountVowels();
            Console.WriteLine("enter a string");
            string inputstring = Console.ReadLine();
            countVowels.CountVowel(inputstring);
            break;
        case "10":
            Console.WriteLine("");
            ReverseNumber reverseNumber = new ReverseNumber();
            
            Console.WriteLine(reverseNumber.ReverseNumbers(500));
            break;
        case "11":
            Console.WriteLine("");
            Palidrome palidrome = new Palidrome();
            Console.WriteLine("Enter a string:");
            string inputStrng = Console.ReadLine();
            palidrome.Palid(inputStrng);
            break;
        case ("q"):
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

} while (!exit);
    

