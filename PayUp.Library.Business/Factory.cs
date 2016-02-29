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
		public static IPayUpUserService Instance()
		{
			return new Entities.PayUpUserService ();
		}
	}

}