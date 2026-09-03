using System;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class LuckyWheelRewardAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform wheel;

	[SerializeField]
	private ButtonCtrl mastBtn;

	[SerializeField]
	private GameObject normalPar;

	[SerializeField]
	private GameObject playPar;

	[SerializeField]
	private GameObject resultPar;

	[SerializeField]
	private LuckyWheelRewardLight rewardLight;

	private Tweener rotateAni;

	private Sequence aniSqe;

	private Action done;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Play;

	private static DelegateBridge __Hotfix0_Stop;

	private static DelegateBridge __Hotfix0_RotateAni;

	private static DelegateBridge __Hotfix0_WaitCallBack;

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

	private void RefreshStatus()
	{
	}

	public void Play(int selectPosition, Action done)
	{
	}

	private void Stop()
	{
	}

	private Tweener RotateAni(float targetAngle)
	{
		return null;
	}

	private void WaitCallBack()
	{
	}
}
