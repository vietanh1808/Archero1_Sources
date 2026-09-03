using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class BeliefPanel : MonoBehaviour, ImprintUICtrl.IPanelBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private BeliefProgressItem beliefProgressItem;

	[SerializeField]
	private ScrollRectBase scrollRect;

	[SerializeField]
	private DxxText text_Stage;

	[SerializeField]
	private BeliefTips showTips;

	[SerializeField]
	private BeliefTalentRewardsTip talentRewardsTip;

	[SerializeField]
	private GameObject go_CloseReward;

	[SerializeField]
	private GameObject go_Mask;

	private int crtShowStage;

	private float offset;

	private float delta;

	private float height;

	private float width;

	private int ShowEffectID;

	private BeliefSkillData data => null;

	private int crtUnlockStage => 0;

	private int maxStage => 0;

	public void Init()
	{
	}

	public void InitTableView()
	{
	}

	public void Open()
	{
	}

	public void RefreshStage()
	{
	}

	public void Close()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}
}
