
namespace Contract.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double  ValuePerHour { get; set; }
        public int Hours { get; set; }

        /// Empty Overload
        /// Sobrecarga vazia
        public HourContract()
        {

        }

        ///Overload receiving employee values
        ///Sobrecarga recendo  valores do funcionário
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        /// Calculating the total amount
        /// Calculando o valor total
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}