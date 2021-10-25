﻿using System;
using System.Collections.Generic;
using System.Text;
using Worker_APP.Interfaces;

namespace Worker_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            try
            {
                WorkerService workerService = new WorkerService();
            
                List<Worker> workers = new List<Worker>();
                workers.Add(new DriverWorker(45, "aaa", "aaaaaa", 78, 400));
                workers.Add(new DriverWorker(75, "bbb", "bbbbbb", 78, 400));
                workers.Add(new OfficeWorker(25, "ccc", "cccccc", 78, 400));
                workers.Add(new OfficeWorker(47, "ddd", "dddddd", 78, 400));
                workerService.Print(workers);
                string res1 = workerService.Search(workers, "ccc");
              
                var res2 = workerService.Addbonus(workers, "ddd");
                Console.WriteLine(workers[3]._salary);
                workers[0].BreakTime();
                workers[0].Vacation();
                workers[3].BreakTime();
                workers[3].Vacation();

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Unknown error");
                string log = logger.CreateLog(ex);
                logger.Log(log);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Unknown error");
                string log = logger.CreateLog(ex);
                logger.Log(log);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                string log = logger.CreateLog(ex);
                logger.Log(log);
            }
        }
    }
}
