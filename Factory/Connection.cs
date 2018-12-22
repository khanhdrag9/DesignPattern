using System;

namespace Factory
{
	public class Connection
	{
		virtual public string Connect()
		{
			return "Generic";
		}
	}	

	public class Oracle : Connection
	{
		public override string Connect()
		{
			return "Oracle";
		}
	}
	public class SqlServer : Connection
	{
		public override string Connect()
		{
			return "SqlServer";
		}
	}
	public class MySql : Connection
	{
		public override string Connect()
		{
			return "MySql";
		}
	}
	//secure
	public class SecureOracle : Connection
	{
		public override string Connect()
		{
			return "Secure Oracle";
		}
	}
	public class SecureSqlServer : Connection
	{
		public override string Connect()
		{
			return "Secure SqlServer";
		}
	}
	public class SecureMySql : Connection
	{
		public override string Connect()
		{
			return "Secure MySql";
		}
	}
}