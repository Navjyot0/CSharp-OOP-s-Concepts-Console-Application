using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPs
{
    class Tasks
    {
        #region Tasks
        /*
         * Task: It is class (System.Threading.Task -> Namespace) to let you create threads and run them asynchronously.
         * Queing a work in Thread pool is useful 
         * but there is no way to know when the operations has finished and what is return value 
         * Therefore Microsoft introduced concept of Task
         * Task is an object that represents some work that should be done.
         * The Task can tell you if the work is completed and if the operation returns a result, the Task gives you the result.
         * 
         * Task vs Threads
         * When we work with multiple threads it's not sure that threads are seperated over multiple processors.
         * Task is a lightweight object for managing a parallelizable unit of work.
         * If system has multiple tasks then it make use of the CLR thread pool internally.
         * Task can return a result. 
         * Wait on a set of tasks.
         * We can chain tasks
         * Establish a parent/child relationship when one task is started from another task.
         * Task support cancellation through the use of cancellation tokens.
         * Asynchronous implementation is easy in task, using 'async' and 'await' keywords.
         */
        #endregion

        #region start New Task
        public static void StartNewTask() 
        {
            Task Task1 = new Task(() => {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine("Task 1 : " + i);
            });
            Task1.Start();
            Task1.Wait();
        }
        #endregion

        #region Using Task that Returns Value
        public static void taskWithValueReturn()
        {
            Task<int> task1 = new Task<int>(() => {
                return 23;
            });
            task1.Start();
            Console.WriteLine("Result:"+ task1.Result);
            task1.Wait();
        }
        #endregion
        
        #region Addding Continuation to task

        public static void addContnuationToTask()
        {
            Task<int> t1 = new Task<int>(() =>
            {
                return 20;
            }).ContinueWith((i) => { //ContinueWith has couple of overloads can use accordingly
                return i.Result * 2;
            });

            #region ContinueWith has couple of overloads can use accordingly
            t1.ContinueWith((i) => {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t1.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t1.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            #endregion

            completedTask.Wait();

            Console.WriteLine(t1.Result); //Should display 40
        }
        #endregion

        #region Attaching child tasks to a parent task
        //Task can also have child Tasks the parent task finishes when all child tasks are ready
        public static void childParent()
        {
            Task<Int32[]> parent = new Task<Int32[]>(() => { 
                var results=new Int32[3];
                new Task((i) => results[0] = 0, TaskContinuationOptions.AttachedToParent).Start();
                new Task((i) => results[1] = 1, TaskContinuationOptions.AttachedToParent).Start();
                new Task((i) => results[2] = 2, TaskContinuationOptions.AttachedToParent).Start();
                return results;
            });
        }
        #endregion

        public static void Main()
        {
            addContnuationToTask();
            Console.ReadKey();
        }
    }
}
