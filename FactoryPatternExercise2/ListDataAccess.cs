using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess 
	{
		
         public List<product> loadData()
        {
            Console.WriteLine("i am loading data from a list...");
            return new List<product>();
        }
        public void saveData()
        {
            Console.WriteLine("I am saving data toa list db...");
        }

		
			
		

    }
}

