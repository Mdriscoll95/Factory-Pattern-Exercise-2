using System;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess


    {
        public List<product> loadData()
        {
            Console.WriteLine("iam loading from a SQL db...");
            return new List<product>();
        }


        public void saveData()
        {
            Console.WriteLine("I am saving to a SQL DB...");
        }
    }
}

