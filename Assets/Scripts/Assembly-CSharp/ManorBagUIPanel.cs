using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ManorBagUIPanel : ManorPanelBase
{
	public ScrollRectBase scroll;

	public RectTransform WorkersParent;

	public RectTransform PropParent;

	public ManorBagItem template;

	public DxxText Text_Worker;

	public DxxText Text_Prop;

	public GameObject go_workerTitle;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_RefreshBagProps;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public override void OnInit()
	{
	}

	public override void Open()
	{
	}

	public void RefreshBagProps()
	{
	}

	public override void Close()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_Open()
	{
	}

	private void _003C_003ExLuaBaseProxy_Close()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
