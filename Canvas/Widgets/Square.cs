using System;

namespace Canvas
{

	public struct Square : IRectangle, IWidget
	{
		private Location? location;
		private readonly int size;

		public Square(int size)
		{
			this.size = size;

			location = null;
		}

		public int Width 
		{
			get 
			{
				return size;
			}
		}

		public int Height
		{
			get 
			{
				return size;
			}
		}

		public Location? Location 
		{
			get 
			{
				return location;
			}

			set 
			{
				location = value;
			}
		}

		public override string ToString ()
		{
			return string.Format ("Square {0} size={1}", location.HasValue ? location.ToString() : "N/A", size);
		}
	}
	
}
