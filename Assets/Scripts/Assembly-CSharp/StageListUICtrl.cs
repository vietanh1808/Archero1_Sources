using PureMVC.Interfaces;
using UnityEngine;

public class StageListUICtrl : MediatorCtrlBase
{
	public RectTransform window;

	public Transform titleparent;

	public Animation titleani;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ScrollIntStageListCtrl mScrollInt;

	public Transform mScrollChild;

	public GameObject copyStage;

	public ButtonCtrl Button_Change;

	public DxxText Text_Change;

	public GameObject lockparent;

	public DxxText Text_Lock;

	public GameObject Sweepparent;

	public DxxText Sweep_desc;

	public DxxText Text_Preview;

	private int mCurrentStage;

	private int mCurrentMaxStage;

	private int MaxStage;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateOne(int index, StageListOneCtrl one)
	{
	}

	private void UpdateSize(int index, StageListOneCtrl one)
	{
	}

	private void OnScrollEnd(int index, StageListOneCtrl one)
	{
	}

	private void OnBeginDrag()
	{
	}

	private void UpdateUI()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
