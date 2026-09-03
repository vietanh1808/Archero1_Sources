using UnityEngine;

public class PVPTipUIPanelCtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_title;

	public DxxText Text_desc;

	public RectTransform content;

	public MainUIScrollRectInsideCtrl mInsideCtrl;

	public PVPTipItemOneCtrl OneItem;

	private LocalUnityObjctPool mPool;

	private const float ELEMENT_DISTANCE = 10f;

	protected override void OnInit()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	private void updateList()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
