using System;

namespace PayUp.Library.DataAccess.Entities
{
	internal class BaseEntity
	{
		public string CreatedBy {get;set;}
		public DateTime DateTimeCreated {get;set;}

		public string ModifiedBy {get;set;}
		public DateTime DateTimeModified {get;set;}
	}
}

