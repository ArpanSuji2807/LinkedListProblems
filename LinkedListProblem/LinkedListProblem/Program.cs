using System;
namespace LinkedListProblem;
class program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        bool check=true;
        Console.WriteLine("1.Simple Linked List\n2.Add in reverse order");
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
                case 2:
                    list.AddInReverseOrder(56);
                    list.AddInReverseOrder(30);
                    list.AddInReverseOrder(70);
                    break ;
            }
        }
    }
}