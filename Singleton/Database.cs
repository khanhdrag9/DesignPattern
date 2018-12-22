namespace Singleton
{
	public class Database
	{
		public string name{get;set;}
		private static Database obj = null;

		private Database(string n)
		{
			name = n;
		}
		public static Database GetInstance(string n = "")
		{
			if(obj == null)
			{
				obj = new Database(n);
			}
			else
			{
				if(n != "")obj.name = n;
			}

			return obj;
		}
	}
	public class Databasev2
	{
		public string name{get;set;}
		private static Databasev2 obj = new Databasev2("khanhv2");

		private Databasev2(string n)
		{
			name = n;
		}
		public static Databasev2 GetInstance()
		{
			return obj;
		}
	}
}