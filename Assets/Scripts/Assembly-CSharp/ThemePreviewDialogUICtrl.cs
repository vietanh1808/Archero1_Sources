using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class ThemePreviewDialogUICtrl : MediatorCtrlBase
{
	public Image TitleIcon;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Title_Line;

	public DxxText Text_Title;

	public DxxText Text_Des;

	public UILineCtrlOne UILineOne;

	public ScrollRectBase ScrollView;

	public RectTransform ContentTrans;

	public GridLayoutGroup GridGroup;

	private LocalUnityObjctPool mPool;

	private CBoxGemActivityInfo Data;

	private string[] PreviewItems;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}
}
