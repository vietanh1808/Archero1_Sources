using PureMVC.Interfaces;
using TableTool;
using UnityEngine.UI;
using XLua;

public class ManorCardUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText text_UseCount;

	public DxxText Text_Desc;

	public DxxText Text_Count;

	public PropOneEquip topItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Use;

	public ButtonCtrl Button_Reduce;

	public ButtonCtrl Button_Plus;

	public DxxText Text_Use;

	public Slider Slider_Count;

	public DxxText text_SliderCount;

	public DxxImage Img_Material;

	public DxxText Text_GetCount;

	private int propId;

	private int Total;

	private float crtRes;

	private Manor_Material crtData;

	private LocalSave.EquipOne propData;

	private ManorBuildingData crtBuildData;

	private int crtCount;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_InitUI;

	private static DelegateBridge __Hotfix0_OnValueChanged;

	private static DelegateBridge __Hotfix0_OnUseBtnClick;

	private static DelegateBridge __Hotfix0_OnChangeCountBtnClick;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	public void OnValueChanged()
	{
	}

	private void OnUseBtnClick()
	{
	}

	private void OnChangeCountBtnClick(int count)
	{
	}

	protected override void OnClose()
	{
	}

	private void onButtonClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
