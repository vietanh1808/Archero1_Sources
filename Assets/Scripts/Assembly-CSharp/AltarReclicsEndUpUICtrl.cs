using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class AltarReclicsEndUpUICtrl : MediatorCtrlBase
{
	public AltarBreakEnd breakEnd;

	public AltarBG altarBG;

	public DxxText Text_Success;

	public TapToCloseCtrl mCloseCtrl;

	public Button touchScreenButton;

	public RectTransform container;

	public GameObject attrItem;

	public GameObject scroller;

	private AltarData altarData;

	private int tempId;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void second()
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

	public void OnButtonTouchScrren()
	{
	}
}
