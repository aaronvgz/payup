using System;

namespace PayUp.Library.DataAccess
{
	public interface IBaseEntity
	{
		string CreatedBy {get;set;}
		DateTime DateTimeCreated {get;set;}

		string ModifiedBy {get;set;}
		DateTime DateTimeModified {get;set;}
	}
}

