using System;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class LuckyWheelReward : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private LuckyWheelRewardItem rewardItem;

	[SerializeField]
	private LuckyWheelRewardAni rewardAni;

	[SerializeField]
	private LuckyWheelRewardLight rewardLight;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_get_LuckyWheelRewardData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	private LuckyWheelRewardData LuckyWheelRewardData => null;

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

	private void RefreshItem()
	{
	}

	public void PlayAni(int drawID, Action done)
	{
	}
}
