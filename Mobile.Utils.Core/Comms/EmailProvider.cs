using System;

namespace Mobile.Utils.Core.Comms
{
	public abstract class EmailProvider
	{
		#region Fields

		private static EmailProvider mEmailProvider;

		#endregion

		#region Properties

		/// <summary>
		/// Gets the email provider.
		/// </summary>
		/// <value>The email provider.</value>
		public static EmailProvider Provider {
			get
			{
				if (mEmailProvider == null)
					throw new Exception ("An EmailProvider has not been registered");

				return mEmailProvider;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Register an email provider
		/// </summary>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static void Register<T> () where T : EmailProvider, new()
		{
			mEmailProvider = new T ();
		}

		#endregion
	}
}

