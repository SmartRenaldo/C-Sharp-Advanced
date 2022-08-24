namespace _11_GenericCovarianceAndContravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People()
            {
                Id = 1,
                Name = "Christina"
            };

            People people2 = new Teacher()
            {
                Id = 2,
                Name = "Jobs"
            };

            //List<People> people3 = new List<Teacher>(); error

            //Covariance
            IListOut<People> listOut1 = new ListOut<People>();
            IListOut<People> listOut2 = new ListOut<Teacher>();

            //Contravariance
            IListIN<Teacher> listIN1 = new ListIN<Teacher>();
            IListIN<Teacher> listIN2 = new ListIN<People>();
        }
    }
}