using PureMVC.Interfaces;
using UnityEngine;

public class ActDiamondChoiceUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private DxxText txt_Title;

	[SerializeField]
	private DxxText txt_timeCount;

	[SerializeField]
	private DiamondChoiceItem template;

	[SerializeField]
	private RectTransform rtContent;

	[SerializeField]
	private DiamondRewardSelectPanel rsPanel;

	private LocalUnityObjctPool pool;

	private ActDiamondChoiceMgr actDiamondChoiceMgr;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void Refresh()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void UpdateTime()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}
}
