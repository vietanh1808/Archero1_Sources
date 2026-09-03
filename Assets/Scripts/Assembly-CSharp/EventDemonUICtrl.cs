using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EventDemonUICtrl : MediatorCtrlBase
{
	public DxxText texttitle;

	public DxxText texttitle2;

	public ButtonCtrl buttonok;

	public DxxText textok;

	public ButtonCtrl buttoncancel;

	public DxxText textcancel;

	public DxxText text_content2;

	public Image image_1;

	public Image image_2;

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private FitContentText text_content1;

	private int mLoseid;

	private int mGetid;

	private int mFormid;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void OnEscape()
	{
	}

	private void OnClickOK()
	{
	}

	private void OnClickCanccel()
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
