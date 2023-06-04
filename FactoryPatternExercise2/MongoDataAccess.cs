using System;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<product> loadData()
        {
            Console.WriteLine("I am loading from a Mongo DB");
            return new List<product>();
        }

        public void saveData()
        {
            Console.WriteLine("I am saving to a Mongo db...");
        }
    }
}

