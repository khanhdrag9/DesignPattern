namespace Factory
{
	public abstract class ConnectionFactory
	{
		public ConnectionFactory()
		{
		}
		public abstract Connection CreateConnection(string type);
	}

	public class SecureFactory : ConnectionFactory	
	{
		public override Connection CreateConnection(string type)
		{
			if(type.Equals("ORACLE"))
				return new SecureOracle();
			else if(type.Equals("SQLSERVER"))
				return new SecureSqlServer();
			else if(type.Equals("MYSQL"))
				return new SecureMySql();
			
			return null;
		}
	}
}