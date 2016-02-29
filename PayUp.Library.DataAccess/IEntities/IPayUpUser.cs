using System;

namespace PayUp.Library.DataAccess
{
	public interface IPayUpUser : IBaseEntity
	{
		#region Properties

		int UserId {get;set;}

		string Name {get;set;}

		string Email {get;set;}

		Common.PayUpUser.Status Status {get;set;}

		#endregion

		#region Methods

		#endregion
	}
}

