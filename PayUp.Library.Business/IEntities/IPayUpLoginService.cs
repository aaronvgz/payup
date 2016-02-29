using System;

namespace PayUp.Library.Business
{
	public interface IPayUpLoginService
	{
		Boolean LoginEmailPassword(string email, string password);
	}
}