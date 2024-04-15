
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

        /// Empty Overload
        /// Sobrecarga vazia
        public Worker()
        {

        }

        ///Overload receiving employee values
        ///Sobrecarga recendo  valores do funcionário
        public Worker(string name, WorkerLevel level, double baseSalary, Department dp)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            dept = dp;
        }

        /// Adding information to the list
        /// Adicionando informações a lista
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        /// Removing information from the list
        /// Removendo informações da lista
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        /// Calculating income based on salary, total hours and hourly rate paid
        /// Calculando a renda com base no salário, horas total e valor pago por hora
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