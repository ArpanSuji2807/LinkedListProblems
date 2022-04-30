using System;
namespace LinkedListProblem;
class program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        bool check=true;
        Console.WriteLine("1.Simple Linked List");
        while(check)
        {
            Console.WriteLine("Take an option to execute");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    list.Add(30);
                    list.Add(56);
                    list.Add(70);
                    break;
            }
        }
    }
}