using System;

namespace Math
{
	public struct Point
	{
		public DateTimeOffset DateTimeOffset { get; }
		public double Value { get; }

		public Point(DateTimeOffset date, double value)
		{
			DateTimeOffset = date;
			Value = value;
		}
		
	}
}
