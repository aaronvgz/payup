using System;

namespace PayUp.Library.Business.Entities
{
	internal class PayUpLoginService : IPayUpLoginService
	{
		#region IPayUpLoginService implementation

		public bool LoginEmailPassword (string email, string password)
		{
			if (email == "aaron.zabala@hotmail.com" && password == "test")
				return true;

			return false;
		}

		#endregion
		
	}
}

