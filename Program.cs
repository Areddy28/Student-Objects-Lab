using System;

namespace StudentsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {
                string input = GetInput("Press any key to see array of names, hometowns and favorite food");
                

                Student[] names = new Student[9];

                Student student1 = new Student("Huy Phan");
                Student student2 = new Student("Calyn Greene");
                Student student3 = new Student("Marjorie Patton");
                Student student4 = new Student("Ramone Lynch");
                Student student5 = new Student("Cullin Flynn");
                Student student6 = new Student("Cordero Ebberhart");
                Student student7 = new Student("Rick Magdeleno");
                Student student8 = new Student("James Mitchell");
                Student student9 = new Student("Richard Moss");

                names[0] = student1;
                names[1] = student2;
                names[2] = student3;
                names[3] = student4;
                names[4] = student5;
                names[5] = student6;
                names[6] = student7;
                names[7] = student8;
                names[8] = student9;

                HomeTown[] hometowns = new HomeTown[9];

                HomeTown hometown1 = new HomeTown("Lansing, MI");
                HomeTown hometown2 = new HomeTown("Raleigh, NC");
                HomeTown hometown3 = new HomeTown("Portage, MI");
                HomeTown hometown4 = new HomeTown("Detroit, MI");
                HomeTown hometown5 = new HomeTown("Fort Lauderdale, FL");
                HomeTown hometown6 = new HomeTown("Fowlerville, MI");
                HomeTown hometown7 = new HomeTown("Berkley, Michigan");
                HomeTown hometown8 = new HomeTown("Gilbert, AZ");
                HomeTown hometown9 = new HomeTown("Yap, FSM");

                hometowns[0] = hometown1;
                hometowns[1] = hometown2;
                hometowns[2] = hometown3;
                hometowns[3] = hometown4;
                hometowns[4] = hometown5;
                hometowns[5] = hometown6;
                hometowns[6] = hometown7;
                hometowns[7] = hometown8;
                hometowns[8] = hometown9;

                FavoirteFoods[] favoirtefoods = new FavoirteFoods[9];

                FavoirteFoods favoirtefoods1 = new FavoirteFoods("Korean BBQ");
                FavoirteFoods favoirtefoods2 = new FavoirteFoods("Curry");
                FavoirteFoods favoirtefoods3 = new FavoirteFoods("Mac and Cheese");
                FavoirteFoods favoirtefoods4 = new FavoirteFoods("Lasagna");
                FavoirteFoods favoirtefoods5 = new FavoirteFoods("Chicken Soup");
                FavoirteFoods favoirtefoods6 = new FavoirteFoods("Pad Thai");
                FavoirteFoods favoirtefoods7 = new FavoirteFoods("(Any type of) BBQ");
                FavoirteFoods favoirtefoods8 = new FavoirteFoods("Hamburger");
                FavoirteFoods favoirtefoods9 = new FavoirteFoods("Katsu");


                favoirtefoods[0] = favoirtefoods1;
                favoirtefoods[1] = favoirtefoods2;
                favoirtefoods[2] = favoirtefoods3;
                favoirtefoods[3] = favoirtefoods4;
                favoirtefoods[4] = favoirtefoods5;
                favoirtefoods[5] = favoirtefoods6;
                favoirtefoods[6] = favoirtefoods7;
                favoirtefoods[7] = favoirtefoods8;
                favoirtefoods[8] = favoirtefoods9;




                //Console.WriteLine(names[0].name);
                //Console.WriteLine(names[1].name);
                //Console.WriteLine(names[2].name);

                Console.WriteLine("Array of student names\n");
                foreach (Student student in names)
                {
                    Console.WriteLine(student.name);
                }

                Console.WriteLine("\nArray of student hometowns\n");
                foreach (HomeTown hometown in hometowns)
                {
                    Console.WriteLine(hometown.homeTown);
                }

                Console.WriteLine("\nArray of student favorite foods\n");
                foreach (FavoirteFoods favoirtefood in favoirtefoods)
                {
                    Console.WriteLine(favoirtefood.favoriteFoods);
                }
 
 

                 goOn = Continue();


            }
           
        }

        public static string GetInput (string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public static bool Continue()
        {
            string answer = GetInput("\nWould you like to learn about another student? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye and thanks!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                // This is recursion, calling a method inside itself
                return Continue();
            }
        }
    }
}
