using UnityEngine;
using UnityEngine.UI;

public class PopWindowInfoUICtrl : MediatorCtrlBase
{
	public static readonly float RootHeadBorder;

	public static readonly float ContentBorder;

	public static readonly float ButtonHeight;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public RectTransform RootBg;

	public RectTransform ContentBg;

	private PopWindowInfoProxy.Transfer mTransfer;

	private float contenty;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public static float GetTextHeight(Text text)
	{
		return 0f;
	}
}
