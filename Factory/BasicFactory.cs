namespace Factory
{
	public class BasicFactory
	{
		private string type;
		public BasicFactory(string type)
		{
			this.type = type;
		}
		public void SetTypeConnection(string type)
		{
			this.type = type;
		}

		public Connection CreateConnection()
		{
			if(type.Equals("ORACLE"))
				return new Oracle();
			else if(type.Equals("SQLSERVER"))
				return new SqlServer();
			else if(type.Equals("MYSQL"))
				return new MySql();
			
			return null;
		}
	}
}