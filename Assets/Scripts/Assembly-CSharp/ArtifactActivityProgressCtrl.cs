using System.Collections.Generic;
using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityProgressCtrl : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private ArtifactActivityProgressBoxCtrl _copyOne;

	[SerializeField]
	private Image _imgProgress;

	private IList<STActivityArtifactProgressRewardData> _datas;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private void InitTableView()
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
}
