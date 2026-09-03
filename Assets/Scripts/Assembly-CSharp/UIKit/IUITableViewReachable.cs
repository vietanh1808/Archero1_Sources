namespace UIKit
{
	public interface IUITableViewReachable
	{
		void TableViewReachedTopmostOrRightmost(UITableView tableView);

		void TableViewReachedBottommostOrLeftmost(UITableView tableView);

		void TableViewLeftTopmostOrRightmost(UITableView tableView);

		void TableViewLeftBottommostOrLeftmost(UITableView tableView);

		float TableViewReachableEdgeTolerance(UITableView tableView);
	}
}
