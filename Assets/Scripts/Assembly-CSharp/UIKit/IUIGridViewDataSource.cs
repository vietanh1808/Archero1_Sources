namespace UIKit
{
	public interface IUIGridViewDataSource : IUITableViewDataSource
	{
		int NumberOfCellsAtRowOrColumnInGrid(UITableView grid);

		UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid);
	}
}
