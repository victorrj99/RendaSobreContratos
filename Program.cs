using System;
using System.Globalization;
using Contract.Entities;
using Contract.Entities.Enums;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Collecting employee data
            /// Coletando dados do funcionário
            /// 
            string nameDepartment,nameEmployee;
            double baseSalary;
            System.Console.Write("Entre com o nome do seu departamente: ");
            nameDepartment = Console.ReadLine();
            Department dept = new Department(nameDepartment);
            System.Console.WriteLine("Insira abaixo os dados do trabalho.");
            System.Console.Write("Nome: ");
            nameEmployee = Console.ReadLine();
            System.Console.Write("Qual seu level? (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.Write("Qual seu salário base? ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantos contratos este trabalhador possui? ");
            int contract = int.Parse(Console.ReadLine());

            /// Security checks
            /// Verificações de segurança
            ///
            if (nameDepartment.Length <= 0 || nameEmployee.Length <= 0 || baseSalary < 0.0 || contract < 0){
                System.Console.WriteLine("Dados digitados Incorretos, verifique os dados inseridos e tente novamente.");
                return;
            }

            /// Inserting the received data into the overload
            /// Inserindo os dados recebidos na sobrecarga
            ///
            Worker worker = new Worker(nameEmployee, level, baseSalary, dept);

            /// Inserting the received data into the list
            /// Inserindo os dados recebidos na lista
            for (int i = 0; i < contract; i++)
            {   
                System.Console.WriteLine($"Insira os dados do contrato # {i+1}");            
                System.Console.Write("Data: (Dia/Mês/Ano): ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Duração (Horas trabalhadas): ");
                int workedHours = int.Parse(Console.ReadLine());
                HourContract contract1 = new HourContract(dateTime,valuePerHour, workedHours);
                worker.addContract(contract1);
            }

            /// Checking data indicated by the user and showing the desired income
            /// Verificando dados indicados pelo usuário e mostrando a renda desejada
            ///
            System.Console.Write("Insira o mês e o ano que deseja calcular a renda. (Mês/Ano) ");
            string newDate = Console.ReadLine();
            int month = int.Parse(newDate.Substring(0,2));
            int year = int.Parse(newDate.Substring(3));
            System.Console.WriteLine($"{month}/{year}");
            System.Console.WriteLine($"Nome: {worker.Name}\nDepartamento: {worker.dept.name}\nRenda para {month}/{year}: {worker.income(month,year):F2} R$");

        }
    }
}