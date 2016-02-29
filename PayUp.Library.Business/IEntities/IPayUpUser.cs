using System;

namespace PayUp.Library.Business
{
	public interface IPayUpUser : IBaseEntity
	{
		#region Properties

		int UserId {get;}

		string Name {get;set;}

		string Email {get;set;}

		Common.PayUpUser.Status Status {get;set;}

		#endregion

		#region Methods

		#endregion

	}
}