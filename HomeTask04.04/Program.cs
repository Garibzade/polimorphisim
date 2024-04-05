using HomeTask04._04.Models;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace HomeTask04._04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //var result = Tuple1();
            //Console.WriteLine(result.Item1 + " " + result.Item2 + " " + result.Item3);
            //Console.WriteLine(result);

            //static (int, string, string) Tuple1()
            //{
            //    return (12, "salam", "urey");
            //}

            //static(string,string,string,double) Tuple2()
            //{
            //    return  ("ademin","valideynidi","danisan",12.3);
            //}

            //var adem = Tuple2();
            //Console.WriteLine(adem);

            //(string, int, string, int) record = ("salam", 13, "salam2", 17);
            //Console.WriteLine(record);

            //static (int, string, string) A()
            //{
            //    return (12, "defe", "salam");
            //}
            //var a = A();
            //Console.WriteLine(a);

            //( int, string) asa= ( 13, "reqem");
            //Console.WriteLine(asa);

            //Student student = new Student() { name = "Samir", surname = "Kerimov" };
            //Console.WriteLine(student);
            //Human human = new Human("Sabina ", "Katanova", 32);
            //Console.WriteLine(human);
            //human.Deconstruct(out string name, out string surname, out int age);
            //Console.WriteLine(name);


            //Student student1 = student with { name = "anar" };
            //Console.WriteLine(student1);




            //shark samir = new shark();
            //Baykush eli= new Baykush();
            //Eagle sahin = new Eagle();
            //penguin ibrahim = new penguin();

            //samir.Eat();
            //eli.Eat();
            //eli.Fly();
            //sahin.Fly();

            //Animal[] animals =  { samir,eli,sahin};
            //foreach (Animal animal in animals) {
            //    animal.Eat();
            //}
            //Bird[] birds = {eli,sahin,ibrahim};
            //foreach(Bird bird in birds)
            //{
            //    bird.Fly();
            //}


            Iswim duck = new Duck("daki");
            Iswim fish = new shark("akula");
            Iswim[] swimmers =new Iswim[] {fish,duck};
            foreach (var swimmer in swimmers)
            {
                swimmer.Swim();
            }







        }
        //internal record Student()
        //{
        //    public string name { get; init; }
        //    public string surname { get; init; }
        //}
        //internal record Human(string name, string surname, int age);

    }
}
