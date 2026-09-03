using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class LuckyWheelRewardLight : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private LuckyWheelRewardLightItem[] lightItems;

	private float switchingInterval;

	private float cumulativeTime;

	private bool isShowOpenEvenNumber;

	private bool isNormalUpdate;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_UpdateSwitchingInterval;

	private static DelegateBridge __Hotfix0_AddSwitchingInterval;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_NormalUpdate;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

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

	public void Refresh()
	{
	}

	public void UpdateSwitchingInterval(float interval)
	{
	}

	public void AddSwitchingInterval(float interval)
	{
	}

	private void Show(bool isOpenEvenNumber)
	{
	}

	private void NormalUpdate()
	{
	}

	private void Update()
	{
	}
}
