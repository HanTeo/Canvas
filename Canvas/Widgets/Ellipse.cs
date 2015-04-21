using System;

namespace Canvas
{

	public struct Ellipse : IEllipsis, IWidget
	{
		private Location? location;

		private readonly int horizontalDiameter;
		private readonly int verticalDiameter;

		public Ellipse(int diameterH, int diameterV)
		{
			horizontalDiameter = diameterH;
			verticalDiameter = diameterV;

			location = null;
		}
			
		public int HorizontalDiameter 
		{
			get {
				return horizontalDiameter;
			}
		}

		public int VerticalDiameter 
		{
			get {
				return verticalDiameter;
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
			return string.Format ("Ellipse {0} diameterH={1} diameterV ={2}", location.HasValue ? location.ToString() : "N/A", horizontalDiameter, verticalDiameter);
		}
	}
	
}
