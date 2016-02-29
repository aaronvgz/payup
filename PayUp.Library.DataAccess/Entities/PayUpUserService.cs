using System;



namespace PayUp.Library.DataAccess.Entities
{
	public class PayUpUserService : IPayUpUserService
	{
		#region IPayUpUserService implementation

		public IPayUpUser InsertOne (string email, string password, string name, Common.PayUpUser.Status status, string createdBy)
		{
			// 1- validate and format data entry
			var dataEntity = Factory.PayUpUser.Instance (
				userId: 0,
				email: email,
				name: name,
				password: password,
				status: status,
				createdBy: createdBy,
				dateTimeCreated: DateTime.Now,
				modifiedBy: createdBy,
				dateTimeModified: DateTime.Now);
			
			// TODO : Implement Data Access Layer Logic here...





			// End it here

			return dataEntity;
		}

		#endregion
		
	}
}

