using System;
using Canvas;

namespace Canvas
{	
	public struct Rectangle : IRectangle, IWidget
	{
		private readonly int width;
		private readonly int height;
		private Location? location;

		public Rectangle (int width, int height)
		{
			this.width = width;
			this.height = height;

			location = null;
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
			
		public int Width 
		{
			get {
				return width;
			}
		}
			
		public int Height 
		{
			get {
				return height;
			}
		}

		public override string ToString ()
		{
			return string.Format ("Rectangle {0} width={1} height={2}", location.HasValue ? location.ToString() : "N/A", width, height);
		}
	}
}

