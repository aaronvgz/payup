using System;

namespace PayUp.Library.Business.Entities
{
	internal class PayUpUserService : IPayUpUserService
	{
		#region Methods

		public IPayUpUser GetOneByUserId (int userId)
		{
			throw new NotImplementedException ();
		}

		public IPayUpUser GetOneByEmailPassword (string email, string password)
		{
			throw new NotImplementedException ();
		}

		public IPayUpUser CreateOne (string email, string password, string confirmPassword, string name, string createdBy)
		{
			var dataEntity = DataAccess.Factory.PayUpUser.Instance ().InsertOne (email, password, name, createdBy);
			return Factory.PayUpUser.Instance (dataEntity);
		}

		#endregion


	}
}

