using System;

namespace PayUp.Library.Business
{
	internal class BaseEntity
	{
		public string CreatedBy {get;protected set;}
		public DateTime DateTimeCreated {get;protected set;}

		public string ModifiedBy {get;protected set;}
		public DateTime DateTimeModified {get;protected set;}
	}
}

