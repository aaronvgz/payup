using System;
using NUnit;
using NUnit.Framework;

namespace PayUp.Library.Business.Test
{
	[TestFixture]
	public class PayUpUserService
	{
		[Test]
		public void CreateOne()
		{
			var payUpUser = Factory.PayUpUser.Instance().CreateOne(
				email: "aaron.zabala@hotmail.com",
				password: "test",
				confirmPassword: "test1" ,
				name: "aaron zabala",
				createdBy: "System Test");

			Assert.True (payUpUser == null);
			Assert.False (payUpUser == null);
		}

	}
}

