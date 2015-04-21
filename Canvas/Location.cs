using System;

namespace Canvas
{
	public struct Location
	{
		private int x;
		private int y;

		public int X { get{ return x; } }

		public int Y { get{ return y; } }

		public Location(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public override string ToString ()
		{
			return string.Format ("({0},{1})", X, Y);
		}
	}
	
}
