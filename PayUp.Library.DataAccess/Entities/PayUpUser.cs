using System;

using System.

namespace PayUp.Library.DataAccess.Entities
{
	internal class PayUpUser : BaseEntity, IPayUpUser
	{
		public int UserId {get;set;}

		public string Name {get;set;}

		public string Email {get;set;}

		public string Passowrd {get;set;}

		public Common.PayUpUser.Status Status {get;set;}

		#region methods

		/// <summary>
		/// Initializes a new instance of the <see cref="PayUp.Library.DataAccess.Entities.PayUpUser"/> class.
		/// </summary>
		public PayUpUser(int userId, string email, string name, Common.PayUpUser.Status status, string password,
			string createdBy, DateTime dateTimeCreated, string modifiedBy, DateTime dateTimeModified)
		{
			this.UserId = userId;
			this.Email = email.ToLower ();
			this.Name = email.ToLower ();
			this.Status = status;
			this.Passowrd = password;

			this.CreatedBy = createdBy.ToLower ();
			this.DateTimeCreated = dateTimeCreated;
			this.ModifiedBy = modifiedBy.ToLower ();
			this.DateTimeModified = dateTimeModified;
		}



		#endregion

	}
}

