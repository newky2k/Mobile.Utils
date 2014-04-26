using System;
using Mobile.Utils.Core;
using Mobile.Utils.Core.Comms;
using Mobile.Utils.Android.Providers;

namespace Mobile.Utils.Android
{
	public sealed class SetupHandler : BaseSetupHandler
	{
		public override void Register ()
		{
			EmailProvider.Register<AndroidEmailProvider> ();
		}
	}
}

