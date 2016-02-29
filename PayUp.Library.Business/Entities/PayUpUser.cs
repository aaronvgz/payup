using System;

namespace PayUp.Library.Business.Entities
{
	internal class PayUpUser : BaseEntity, IPayUpUser
	{
		public int UserId {get; private set;}

		public string Name {get;set;}

		public string Email {get;set;}

		public Common.PayUpUser.Status Status {get;set;}

		public PayUpUser(DataAccess.IPayUpUser dataEntity)
		{
			if (dataEntity == null)
				throw new ArgumentNullException ("dataEntity is null", this.GetType ().ToString ());

			this.UserId = dataEntity.UserId;
			this.Name = dataEntity.Name;
			this.Email = dataEntity.Email;
			this.Status = dataEntity.Status;

			this.CreatedBy = dataEntity.CreatedBy;
			this.DateTimeCreated = dataEntity.DateTimeCreated;
			this.ModifiedBy = dataEntity.ModifiedBy;
			this.DateTimeModified = dataEntity.DateTimeModified;
		}

	}
}