using System;
using System.Linq;

namespace Math
{
	public class QuadraticInterpolation
	{
		private Point[] _sourcePoints;
		public QuadraticInterpolation(Point[] points)
		{
			_sourcePoints = points.ToArray();
		}

		public Point[] Interpolate(DateTimeOffset[] dates)
		{
			return new Point[0];
		}
	}
}
