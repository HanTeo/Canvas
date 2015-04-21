using System;
using Canvas;

namespace Canvas.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var drawing = new Drawing ();
			drawing
				.Add (new Location (x: 10, y: 10), new Rectangle (width: 30, height: 40))
				.Add (new Location (x: 15, y: 30), new Square (size: 35))
				.Add (new Location (x: 100, y: 150), new Ellipse (diameterH: 300, diameterV: 200))
				.Add (new Location (x: 1, y: 1), new Circle (size: 300))
				.Add (new Location (x: 5, y: 5), new TextBox (width: 200, height: 100, text: "sample text"));
					
			System.Console.Write (drawing.Print());
			System.Console.ReadKey ();
		}
	}
}
