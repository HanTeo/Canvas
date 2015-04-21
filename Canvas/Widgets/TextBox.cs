using System;

namespace Canvas
{
	public struct TextBox : IRectangle, ITextElement, IWidget
	{
		private int height;
		private int width;
		private string text;
		private Location? location;

		public TextBox(int height, int width, string text)
		{
			this.height = height;
			this.width = width;
			this.text = text;

			location = null;
		}

		public int Height {
			get {
				return height;
			}
		}

		public int Width {
			get {
				return width;
			}
		}

		public Location? Location {
			get {
				return location;
			}
			set {
				location = value;
			}
		}
			
		public string Text {
			get {
				return text;
			}
		}

		public override string ToString ()
		{
			return string.Format ("Textbox {0} width={1} height={2} Text=\"{3}\"", location.HasValue ? location.ToString() : "N/A", width, height, text);
		}

	}
}
