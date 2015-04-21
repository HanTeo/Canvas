using System;
using Canvas;

namespace Canvas
{
	public struct Circle : IEllipsis, IWidget
	{
		private Location? location;
		private readonly int size;

		public Circle(int size)
		{
			this.size = size;

			location = null;
		}

		public int HorizontalDiameter 
		{
			get {
				return size;
			}
		}

		public int VerticalDiameter 
		{
			get {
				return size;
			}
		}

		public Location? Location
		{
			get {
				return location;
			}
			set {
				location = value;
			}
		}

		public override string ToString ()
		{
			return string.Format ("Circle {0} size={1}", location.HasValue ? location.ToString() : "N/A", size);
		}
	}
	
}
