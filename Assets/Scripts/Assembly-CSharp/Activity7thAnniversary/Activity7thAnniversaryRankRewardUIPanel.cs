using UIKit;
using UnityEngine;
using UnityEngine.UI;

namespace Activity7thAnniversary
{
	public class Activity7thAnniversaryRankRewardUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
	{
		[SerializeField]
		private UITableView _tableView;

		[SerializeField]
		private DxxText _textTitle;

		[SerializeField]
		private DxxText _textTabSelect1;

		[SerializeField]
		private DxxText _textTabSelect2;

		[SerializeField]
		private DxxText _textTabUnSelect1;

		[SerializeField]
		private DxxText _textTabUnSelect2;

		[SerializeField]
		private ButtonCtrl _btnClose;

		[SerializeField]
		private ButtonCtrl _btnHelp;

		[SerializeField]
		private Image[] _imgSelecteds;

		[SerializeField]
		private Image[] _imgUnSelecteds;

		[SerializeField]
		private RankRewardDetailItem _copy;

		[SerializeField]
		private PlayInfoCtrl _playInfoCtrl;

		private int _curTab;

		private Activity7thAnniversaryMgr _mgr;

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		protected override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
		{
			return null;
		}

		public int NumberOfCellsInTableView(UITableView tableView)
		{
			return 0;
		}

		public float ScalarForCellInTableView(UITableView tableView, int index)
		{
			return 0f;
		}

		public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
		{
		}

		public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
		{
		}

		public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
		{
			return 0f;
		}

		public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
		{
			return 0f;
		}

		private void InitTableView()
		{
		}

		public void OnClickTab(int index)
		{
		}
	}
}
