namespace Labb4
{
    public class Program
    {
        public static List<Person> Listperson = new List<Person>();

        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("1. Lägg till person");
                Console.WriteLine("2. Skriv ut personer");
                Console.WriteLine("3. Avsluta");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPerson();
                        break;

                    case 2:
                        Listpeople();
                        break;

                    case 3:
                        Console.WriteLine("Avslutar");
                        choice = 3;
                        break;
                    default:
                        Console.WriteLine("ogiltigt val, vänligen och försök igen");
                        break;
                }

            }

        }

        static void AddPerson()
        {
            int choice = 4;
            bool wrongChoice = false;
            Gender choiceGender = Gender.Man;
            do
            {
                try
                {
                    Console.WriteLine("\n Vad är ditt kön 1. man 2. Kvinna. 3. Nonbinary. 4.Other");
                    choice = int.Parse(Console.ReadLine());
                    wrongChoice = false;
                    if  (wrongChoice == false || choice == 1 || choice == 2 || choice == 3 || choice == 4)
                    {
                         Console.WriteLine("Du kan endast välja mellan alternativen som visas");
                         choice = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    wrongChoice = true;
                }

            } while (wrongChoice == true);

            switch (choice)
            {
                case 1:
                    choiceGender = Gender.Man;
                    break;
                case 2:
                    choiceGender = Gender.Woman;
                    break;
                case 3:
                    choiceGender = Gender.nonbinary;
                    break;
                case 4:
                    choiceGender = Gender.Other;
                    break;
            }

            Hair inputhair = new Hair { };

            bool hairColorError = false;
            do
            {
                try
                {
                    Console.WriteLine("\n Skriv in hårfärg");
                    inputhair.HairColor = Console.ReadLine();
                    hairColorError = false;
                    if (inputhair.HairColor.All(Char.IsDigit)){
                        throw new Exception("Skriv med bokstävers");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    hairColorError = true;


                }
            }
            while (hairColorError == true);

            bool hairLengthError = false;
            do
            {
                try
                {
                    Console.WriteLine("\n Skriv in hårlängd");
                    inputhair.HairLenght = int.Parse(Console.ReadLine());
                    hairLengthError = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    hairLengthError = true;
                }

            } while (hairLengthError == true);

            Console.WriteLine("\n Skriv in födelsdagsdatum");
            string Birthday = Console.ReadLine();

            Console.WriteLine("\n Skriv in ögonfärg");
            string EyeColor = Console.ReadLine();

            Console.WriteLine("\n Skriv in ditt förnamn");
            string Firstname = Console.ReadLine();

            Console.WriteLine("\n Skriv in ditt efternamn");
            string Lastname = Console.ReadLine();

            Person personinput = new Person(choiceGender, inputhair, Birthday, EyeColor, Firstname, Lastname);
            Listperson.Add(personinput);

        }
            static void Listpeople()
            {
                foreach (Person person in Listperson)
                {
                    Console.WriteLine(person.ToString() + "\n");
                }
            }
           
        }
    }

