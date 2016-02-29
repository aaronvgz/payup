using System;

namespace PayUp.Library.DataAccess.Factory
{

	public static class PayUpUser
	{
		public static IPayUpUser Instance(int userId, string email, string name, Common.PayUpUser.Status status)
		{
			return new Entities.PayUpUser();
		}

		public static IPayUpUserService Instance()
		{
			return new Entities.PayUpUserService ();
		}
	}

}

