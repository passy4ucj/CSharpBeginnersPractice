using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //object to calculate power 
            Power MyPower = new Power();
            Console.WriteLine(MyPower.Power1(3, 2));


            //class and static method object
            UsefulTools.Welcome("SJVS"); 

            //Object to add 2 numbers
            Addittion Adding = new Addittion();
            Console.WriteLine(Adding.Add(5, 7));
           

            //object to check gp 
            gp GP = new gp()
            {
                name = "Pascal Harry",
                gpa = 4.5,
                R = ""
            };
            gp GP2 = new gp()
            {
                name = "Chisom Charles",
                gpa = 1.2,
                R = ""
            };

            Console.WriteLine(GP.R);
            Console.WriteLine(GP2.R);


            //object to lists out landlords
            Landlord VGC = new Landlord() {
                Name = "Pascal Ojinnaka",
                NoHos = 3,
                NextKin = "Amen Yalekhue",
                Estate = ""
            };

            Landlord Ajah = new Landlord()
            {
                Name = "Stanley Ojinnaka",
                NoHos = 6,
                NextKin = "Stephen Gerrald",
                Estate = ""
            };

            Landlords landlordss = new Landlords();


            landlordss.landlords.Add(VGC);
            landlordss.landlords.Add(Ajah);

            foreach (var item in landlordss.landlords)
            {
                Console.WriteLine("My name is {0} land lord with {1} " +
                    "houses and my next of kin is {2} and i am a {3}", 
                    item.Name, item.NoHos, item.NextKin, item.Estate);
            }


            //object to list of mentors
            Mentor mentor1 = new Mentor()
            {
                Location = "Canada",
                Name = "Pascal Ojinnaka",
                YearsOfExperience = 3,
                RegisteredOnZoom = true,
                Category = "UI/UX"
            };

            Mentor mentor2 = new Mentor()
            {
                Location = "United Kingdom",
                Name = "John-Paul Ojinnaka",
                YearsOfExperience = 4,
                RegisteredOnZoom = false,
                Category = "Coding"
            };

           

            Console.WriteLine(mentor2.Location);


           
            MentorsToBePaid mentorsToPay = new MentorsToBePaid();

            
            mentorsToPay.Mentors.Add(mentor1);
            mentorsToPay.Mentors.Add(mentor2);
            try
            {
                
                
                foreach (Mentor m in mentorsToPay.Mentors)
                {
                    Console.WriteLine("Our Mentor is {0}, he lives in {1} and has {2} years of experience",
                        m.Name, m.Location, m.YearsOfExperience);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            //object of chef class
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            //object of Italian Chef Inherited from Chef class
            ItalianChef ItalianChef = new ItalianChef();
            ItalianChef.MakeSpecialDish();

            ItalianChef ItalianChef1 = new ItalianChef();
            ItalianChef1.MakeItalianFoods();


            //static methods
            UsefulTools.SayHi("Pascal");
            Song phyno = new Song("So Far So Good", "Phyno", 2);
            Console.WriteLine(Song.SongCount);
            Console.WriteLine(phyno.songCount());
            Song Olamide = new Song("Pawon", "Olamide", 3);
            Console.WriteLine(Song.SongCount);


            //object of Movie class with constructor
            Movie avengers = new Movie("The Avengers", "Josh well", "dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);


            //object of Book class
            Book book1 = new Book();
            book1.author = "Pascal Ojinnaka";
            Book book2 = new Book();
            book2.author = "Stanley Ojinnaka";

            Console.WriteLine(book1.author);
            Console.WriteLine(book2.author);

            Console.WriteLine(book1.title);


            //object of Student class with constructor 
            Student student1 = new Student();
            Student student2 = new Student();
            Console.WriteLine(student1.HasHonors("Jeff Nnoli", "Csc", 3.9));
            Console.WriteLine(student2.HasHonors("Emeka Chuks", "MCB", 2.7));


            //Code to divide 2 numbers with a try and catch exception 
            try
            {
                Console.Write("Enter a num:  ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a num:  ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            

            //method object to calculate power
            Console.WriteLine(GetPow(3,3));

            //Do and While loop
            string secretWord = "Pascal";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguess = false;
            

            do
            {
                if (guesscount < guesslimit)
                {
                    Console.Write("Enter Secret Word:  ");
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofguess = true;
                }
            } while (guess != secretWord && !outofguess);
            
            if (outofguess)
            {
                Console.WriteLine("You have Lost");
            }
            else
            {
                Console.WriteLine("You have Won");
            }
            
        }


        //static method
       static int GetPow(int BaseNum, int PowNum)
        {
            int result = 1;
            for (int i = 0; i < PowNum; i++)
            {
                result = result * BaseNum;
            }
            return result;
        }

      
       
    }
}
