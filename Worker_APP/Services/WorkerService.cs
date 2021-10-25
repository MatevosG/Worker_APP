﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP
{
   public class WorkerService : IAddBonus,IPrint,ISearch
    {
        public bool Addbonus(List<Worker> workers, string name)
        {
            bool worker =false;
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i]._name == name)
                {
                  workers[i]._salary=  workers[i]._salary + 20000;
                  worker = true;
                }
            }
            return worker;
        }
       
        public void Print(List<Worker> workers)
        {
            foreach (var item in workers)
            {
                Console.WriteLine($"id - {item._id}\n name - {item._name}\n surname - {item._surname}\n age - {item._age}\n salary - {item._salary} ");
            }
        }

        public string Search(List<Worker> workers,string name)
        {
            string worker = "there is no such employee";
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i]._name==name)
                {
                    worker = $"id - {workers[i]._id}\n name - {workers[i]._name}\n surname - {workers[i]._surname}\n age - {workers[i]._age}\n salary - {workers[i]._salary}";
                    break;
                }
            }
            return worker;
        }
       
       
    }
}
