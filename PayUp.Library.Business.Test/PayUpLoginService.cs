using System;
using NUnit;
using NUnit.Framework;

namespace PayUp.Library.Business.Test
{
	[TestFixture]
	public class PayUpLoginService
	{
		[Test]
		public void LoginEmailPassword()
		{
			Assert.True (
				Factory.PayUpLogin.Instance().LoginEmailPassword("aaron.zabala@hotmail.com","test"), 
				this.GetType().ToString());
			Assert.False (
				Factory.PayUpLogin.Instance().LoginEmailPassword("xxxxxx@hotmail.com","test"), 
				this.GetType().ToString());
		}

	}
}

