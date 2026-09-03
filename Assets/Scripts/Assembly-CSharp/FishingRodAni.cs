using System;
using PureMVC.Interfaces;
using Spine;
using Spine.Unity;
using UnityEngine;
using XLua;

public class FishingRodAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private SkeletonGraphic rodAni;

	private Action aniCompleteAction;

	private bool isFirstComplete;

	private string curAniName;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_FishingRodData;

	private static DelegateBridge __Hotfix0_get_DefaultAniData;

	private static DelegateBridge __Hotfix0_get_State;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateSkin;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_Complete;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private FishingRodData FishingRodData => null;

	private (string, bool) DefaultAniData => default;

	private Spine.AnimationState State => null;

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

	public void UpdateSkin()
	{
	}

	public void PlayAni((string, bool) aniData, Action aniCompleteAction)
	{
	}

	public void StopAni()
	{
	}

	private void Complete(TrackEntry trackEntry)
	{
	}
}
