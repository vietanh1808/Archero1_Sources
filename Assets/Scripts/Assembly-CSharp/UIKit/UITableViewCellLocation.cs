namespace UIKit
{
	public struct UITableViewCellLocation
	{
		public int index;

		public UITableViewCellAlignment alignment;

		public bool withMargin;

		public float displacement;

		public UITableViewCellLocation(int index, UITableViewCellAlignment alignment, bool withMargin, float displacement)
		{
			this.index = 0;
			this.alignment = UITableViewCellAlignment.RightOrTop;
			this.withMargin = false;
			this.displacement = 0f;
		}
	}
}
