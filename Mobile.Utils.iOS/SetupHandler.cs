using System;
using Mobile.Utils.Core;
using Mobile.Utils.Core.Comms;
using Mobile.Utils.iOS.Provider;

namespace Mobile.Utils.iOS
{
	public sealed class SetupHandler : BaseSetupHandler
	{
		public override void Register ()
		{
			EmailProvider.Register<iOSEmailProvider> ();
		}
	}
}

