using System;

namespace PayUp.Library.Business.Factory
{
	public static class PayUpLogin
	{
		public static IPayUpLoginService Instance()
		{
			return new Entities.PayUpLoginService ();
		}
	}

	public static class PayUpUser
	{
		internal static IPayUpUser Instance(DataAccess.IPayUpUser dataEntity)
		{
			return new Entities.PayUpUser (dataEntity);
		}

		public static IPayUpUserService Instance()
		{
			return new Entities.PayUpUserService ();
		}
	}

}