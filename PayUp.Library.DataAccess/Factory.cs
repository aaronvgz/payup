using System;

namespace PayUp.Library.DataAccess.Factory
{

	public static class PayUpUser
	{
		public static IPayUpUserService Instance()
		{
			return new Entities.PayUpUserService ();
		}

		internal static IPayUpUser Instance(int userId, string email, string name, Common.PayUpUser.Status status, string password,
			string createdBy, DateTime dateTimeCreated, string modifiedBy, DateTime dateTimeModified)
		{
			return new Entities.PayUpUser (
				userId: userId,
				email: email,
				name: name,
				status: status,
				password: password,
				createdBy: createdBy,
				dateTimeCreated: dateTimeCreated,
				modifiedBy: modifiedBy,
				dateTimeModified: dateTimeModified);
		}

	}

}

