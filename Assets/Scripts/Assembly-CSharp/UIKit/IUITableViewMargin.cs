namespace UIKit
{
	public interface IUITableViewMargin
	{
		float ScalarForUpperMarginInTableView(UITableView tableView, int index);

		float ScalarForLowerMarginInTableView(UITableView tableView, int index);
	}
}
