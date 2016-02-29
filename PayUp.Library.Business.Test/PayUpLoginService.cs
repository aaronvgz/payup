using System;
using NUnit;
using NUnit.Framework;

using PayUp.Library.Business;

namespace PayUp.Library.Business.Test
{
	[TestFixture]
	public class PayUpLoginService
	{
		[Test]
		public void LoginEmailPassword()
		{
			Assert.True (
				Business.Factory.PayUpLogin.Instance().LoginEmailPassword("aaron.zabala@hotmail.com","test"), 
				this.GetType().ToString());
			Assert.False (
				Business.Factory.PayUpLogin.Instance().LoginEmailPassword("xxxxxx@hotmail.com","test"), 
				this.GetType().ToString());
		}

	}
}

