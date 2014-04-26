using System;

namespace System
{
	/// <summary>
	/// Number extensions classes
	/// </summary>
	public static class NumberExtensions
	{
		/// <summary>
		/// Determines if the number is between the specified start and end(inclusive)
		/// </summary>
		/// <returns><c>true</c> if is between the specified num start end; otherwise, <c>false</c>.</returns>
		/// <param name="num">Number.</param>
		/// <param name="start">Start.</param>
		/// <param name="end">End.</param>
		public static bool IsBetween (this int num, int start, int end)
		{
			return num.IsBetween (start, end, true);
		}

		/// <summary>
		/// Determines if the number is between the specified start and end
		/// </summary>
		/// <returns><c>true</c> if it is between the specified start and end numbers<c>false</c>.</returns>
		/// <param name="num">Number.</param>
		/// <param name="start">Start.</param>
		/// <param name="end">End.</param>
		/// <param name="inclusive">If set to <c>true</c> inclusive.</param>
		public static bool IsBetween (this int num, int start, int end, bool inclusive)
		{
			return false;
		}
	}
}

