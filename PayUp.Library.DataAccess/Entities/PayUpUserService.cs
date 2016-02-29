using System;

namespace PayUp.Library.DataAccess.Entities
{
	public class PayUpUserService : IPayUpUserService
	{
		#region IPayUpUserService implementation

		public IPayUpUser InsertOne (string email, string password, string name, string createdBy)
		{
			return Factory.PayUpUser.Instance (1, "aaron.zabala", "Aaron Zabala", Common.PayUpUser.Status.Active);
		}

		#endregion
		
	}
}

