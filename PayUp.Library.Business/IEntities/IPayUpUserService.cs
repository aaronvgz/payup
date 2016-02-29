using System;

namespace PayUp.Library.Business
{
	public interface IPayUpUserService
	{
		#region Properties

		#endregion

		#region Methods

		IPayUpUser GetOneByUserId(int userId);

		IPayUpUser GetOneByEmailPassword(string email, string password);

		IPayUpUser CreateOne (string email, string password, string confirmPassword, string name, string createdBy);

		#endregion
	}
}