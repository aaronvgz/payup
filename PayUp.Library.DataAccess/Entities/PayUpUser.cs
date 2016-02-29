using System;

namespace PayUp.Library.DataAccess.Entities
{
	internal class PayUpUser : BaseEntity, IPayUpUser
	{
		public int UserId {get;set;}

		public string Name {get;set;}

		public string Email {get;set;}

		public Common.PayUpUser.Status Status {get;set;}

		#region methods

		public PayUpUser()
		{
			
		}

		#endregion

	}
}

