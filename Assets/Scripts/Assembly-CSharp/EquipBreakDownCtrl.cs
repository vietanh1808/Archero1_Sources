using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public sealed class EquipBreakDownCtrl : MediatorCtrlBase
{
	public DxxText textTitle;

	public DxxText textTips;

	public DxxText textBreakDown;

	public ButtonCtrl btnBreakDown;

	public ButtonCtrl btnClose;

	public ScrollRectBase equipScrollRect;

	public EquipOneCtrl equipMain;

	public GameObject templateRoot;

	public PropOneEquip templateItem;

	public GridLayoutGroup layoutGroup;

	public EquipBreakDownData breakDownData;

	private LocalUnityObjctPool itemPool;

	private int defaultItemSize;

	private int defaultMinSize;

	private int defaultMaxSize;

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

	private void SendBreakDownReq()
	{
	}

	private void OnBreakSuccess(CRespEquipDecompose servData)
	{
	}

	public static string ColorToHex(Color color)
	{
		return null;
	}
}
