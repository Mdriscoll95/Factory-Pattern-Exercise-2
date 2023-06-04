using System;
namespace FactoryPatternExercise2
{
	public interface IDataAccess
	{
		public List<product> loadData();
		public void saveData();
	}
}

