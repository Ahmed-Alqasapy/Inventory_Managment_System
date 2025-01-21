namespace TaskTracker
{
    internal class Program
    {
        static string[] Task = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Task Tracker");
            Console.WriteLine("-----------------------------");


            while (true)
            {

                Console.WriteLine("Please Choose From 1 to 5");
                Console.WriteLine("1. Add Tasks");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Tasks");
                Console.WriteLine("4. Remove Tasks");
                Console.WriteLine("5. Exit");



                string Tasktrack = Console.ReadLine();
                int taskNumber = Convert.ToInt32(Tasktrack);

                switch (taskNumber)
                {
                    case 1:
                        //Add New Task
                        AddTask();
                        break;

                    case 2:
                        //view my tasks
                        ViewTasks();
                        break;

                    case 3:
                        //Mark Task
                        MarkTask();
                        break;

                    case 4:
                        //Remove Task
                        RemoveTask();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please Enter Task between 1 to 5");
                        break;

                }

            }





        }


        private static void AddTask()
        {
            Console.WriteLine("What`s up ... What is New Task You Would like to Add");

            Task[TaskIndex] = Console.ReadLine();

            Console.WriteLine("Task Added");

            TaskIndex++;

        }


        static void ViewTasks()
        {
           for(int i = 0;i<=TaskIndex;i++)
            {
                Console.WriteLine(Task[i]);
            }
        }


        static void MarkTask()
        {
            Console.WriteLine("Please Enter No. Of Task That Completed");
            int taskNo = int.Parse(Console.ReadLine());
            Task[taskNo] += "-----compleated";
        }

        static void RemoveTask()
        {
            Console.WriteLine("Please Enter No Of Task You Want To Remove");
            int taskNoToRemove = int.Parse(Console.ReadLine());
            Task[taskNoToRemove] = "";
            Console.WriteLine($"Task {taskNoToRemove+1} is Removed");
            
        }
    }
}
