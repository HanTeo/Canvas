using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Canvas
{
	public class Drawing
	{
		private ICollection<IWidget> widgets = new List<IWidget>();

		public Drawing Add(Location location, IWidget widget)
		{
			widget.Location = location;
			widgets.Add (widget);

			return this;
		}

		public string Print()
		{
			var sb = new StringBuilder ();
			sb.AppendLine ("------------------------------------------------------");
			sb.AppendLine ("Current Drawing");
			sb.AppendLine ("------------------------------------------------------");
			foreach (var w in widgets) 
			{
				sb.AppendLine (w.ToString());
			}
			sb.AppendLine ("------------------------------------------------------");
				
			return sb.ToString();
		}
	}
}
