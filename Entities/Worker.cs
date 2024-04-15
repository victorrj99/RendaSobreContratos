
using Contract.Entities.Enums;
using Contract.Entities;
using System;
using System.Collections.Generic;

namespace Contract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department dept {get; set;}
        public List<HourContract> Contracts = new List<HourContract>();
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department dp)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            dept = dp;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int month, int year)
        {
            double sumt = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    sumt += contract.TotalValue(); 
                }   
            }
            return sumt ;
        }
    }
}