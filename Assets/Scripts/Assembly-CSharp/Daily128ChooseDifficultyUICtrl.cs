using System;
using System.Collections.Generic;
using TableTool;
using UIKit;
using UnityEngine;

public class Daily128ChooseDifficultyUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textArtifactTitle;

	[SerializeField]
	private DxxText _textScrollViewTitle;

	[SerializeField]
	private DxxText _textDesc;

	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private ArtifactCopyOneCtrl _artifactCopyOne;

	[SerializeField]
	private Transform _artifactParent;

	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private Daily128DifficultyItemCtrl _copyOne;

	[Header("神器tips")]
	[SerializeField]
	private GameObject _goTips;

	[SerializeField]
	private Transform _tArrow;

	[SerializeField]
	private DxxText _textArtifactName;

	[SerializeField]
	private DxxText _textArtifactDesc;

	private IList<Daily_TrialDifficulty_128> _datas;

	private Daily128DifficultyItemCtrl _selectItem;

	private LocalUnityObjctPool _pool;

	private Action<int> _onSelectLevel;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
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

	private void OnSelectLevel(Daily128DifficultyItemCtrl item)
	{
	}

	private void OnClickArtifactItem(ArtifactCopyOneCtrl ctrl)
	{
	}
}
