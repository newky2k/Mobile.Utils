using System;

namespace System
{
	/// <summary>
	/// String extensions.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Simple call to check to see if the String is empty
		/// </summary>
		/// <returns><c>true</c> if is empty the specified str; otherwise, <c>false</c>.</returns>
		/// <param name="str">String.</param>
		public static bool IsEmpty (this String str)
		{
			return String.IsNullOrWhiteSpace (str);
		}
	}
}

