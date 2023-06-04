namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What databse do you want to use? ('sql', 'mongo', or 'List')");
            var dbType = Console.ReadLine();

            var dataAccess = DataAccesssFactory.GetDataBase(dbType);

            List<product> products = dataAccess.loadData();
            dataAccess.saveData();

        }
    }
}
