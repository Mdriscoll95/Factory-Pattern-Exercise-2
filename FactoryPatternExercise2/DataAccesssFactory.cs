using System;
namespace FactoryPatternExercise2
{
	public static class DataAccesssFactory
	{
			public static IDataAccess GetDataBase(string dbType)
		{
            switch (dbType.ToLower())
			{
				case "list":
					return new ListDataAccess();
				case "mysql":
					return new SQLDataAccess();
				case "mongo":
					return new MongoDataAccess();
				default:
					return new SQLDataAccess();
			}

        }
			
		
		

		
	}
}

