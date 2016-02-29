using System;

namespace PayUp.Library.DataAccess
{
	public interface IPayUpUserService
	{

		IPayUpUser InsertOne(string email, string password, string name, string createdBy);

	}
}

