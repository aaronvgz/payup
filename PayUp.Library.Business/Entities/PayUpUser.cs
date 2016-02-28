using System;

namespace PayUp.Library.Business
{
	internal class PayUpUser : IPayUpUser
	{
		public int UserId {get;set;}

		public string Name {get;set;}

		public string Email {get;set;}

		public Common.PayUpUser.Status Status {get;set;}

	}
}