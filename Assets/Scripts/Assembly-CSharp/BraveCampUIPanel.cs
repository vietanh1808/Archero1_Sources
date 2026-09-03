using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BraveCampUIPanel : MediatorCtrlBase
{
	public BraveCampSeatPart braveCampSeatPart;

	public BraveCampRankPart braveCampRankPart;

	public DxxText titleTex;

	public DxxText descText;

	public DxxText taskBtnText;

	public DxxText rewardBtnText;

	public DxxText timeText;

	public DxxText nameText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl taskBtn;

	public ButtonCtrl rewardBtn;

	public GameObject guidePanel;

	public Button guideCloseBtn;

	public DxxText guideDesc;

	public DxxText guideDesc1;

	public DxxText guideDesc2;

	public DxxText guideCloseDesc;

	public PropOneEquip moveEquips;

	public RedNodeCtrl taskRedNode;

	protected override void OnInit()
	{
	}

	private void OnButtonReward()
	{
	}

	private void OnButtonTask()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ClickClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void OnClickId(int id)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void freshTime()
	{
	}

	private void RefreshTaskRed()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void StartGuide()
	{
	}

	private void ClickCloseGuide()
	{
	}
}
