using TableTool;
using UnityEngine;
using XLua;

public class MainUIPushCtrl : MainUIButtonBase
{
	[SerializeField]
	private GameObject child;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DxxText txtTime;

	[SerializeField]
	private DxxImage IconEquip;

	[SerializeField]
	private DxxImage IconQuality;

	private int index;

	private CleverBuyType buyType;

	private float timer;

	private static DelegateBridge __Hotfix0_IsShow;

	private static DelegateBridge __Hotfix0_GetPriority;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_GetTransform;

	private static DelegateBridge __Hotfix0_GetOpenTime;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnBtnClick;

	private static DelegateBridge __Hotfix0_ShowChild;

	private static DelegateBridge __Hotfix0_UpdateCountDownTime;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_LoadData;

	private static DelegateBridge __Hotfix0_SetSprite;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override bool IsShow()
	{
		return false;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public void Open()
	{
	}

	public new void OnClose()
	{
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override void OnLanguageChange()
	{
	}

	public new void UpdateUI()
	{
	}

	private void Awake()
	{
	}

	private void OnBtnClick()
	{
	}

	private void ShowChild(bool value)
	{
	}

	private long UpdateCountDownTime()
	{
		return 0L;
	}

	private void Update()
	{
	}

	private void LoadData()
	{
	}

	private void SetSprite(Drop_DropModel.DropData dropData)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnLanguageChange()
	{
	}
}
