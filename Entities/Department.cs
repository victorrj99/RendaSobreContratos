namespace Contract.Entities
{
    class Department
    {
        public string name { get; set; } 

        /// Empty Overload
        /// Sobrecarga vazia
        public Department(){

        }
        /// Overhead receiving employee name
        /// Sobrecarga recebendo o nome do funcionário
        public Department(string Name){
            name = Name;
        }

    }
}