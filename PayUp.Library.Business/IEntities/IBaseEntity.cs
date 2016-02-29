using System;

namespace PayUp.Library.Business
{
	public interface IBaseEntity
	{
		string CreatedBy {get;}
		DateTime DateTimeCreated {get;}

		string ModifiedBy {get;}
		DateTime DateTimeModified {get;}
	}
}

