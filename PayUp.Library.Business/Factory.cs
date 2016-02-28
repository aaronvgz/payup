using System;



namespace PayUp.Library.Business.Factory
{

	public class PayUpUser
	{
		public static IPayUpUserService Instance()
		{
			return new PayUpUserService ();
		}
	}

}