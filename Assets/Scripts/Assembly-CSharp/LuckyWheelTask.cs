using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class LuckyWheelTask : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private LuckyWheelTaskItem taskItem;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private LuckyWheelTaskAni taskAni;

	[SerializeField]
	private ButtonCtrl clickGo;

	[SerializeField]
	private ButtonCtrl clickBack;

	[SerializeField]
	private DxxText clickGoName;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_get_LuckyWheelTaskData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	private LuckyWheelTaskData LuckyWheelTaskData => null;

	private void InitObjectPool()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshRed()
	{
	}
}
