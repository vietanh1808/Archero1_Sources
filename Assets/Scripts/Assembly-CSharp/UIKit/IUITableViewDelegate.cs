namespace UIKit
{
	public interface IUITableViewDelegate
	{
		void CellAtIndexInTableViewWillAppear(UITableView tableView, int index);

		void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index);
	}
}
