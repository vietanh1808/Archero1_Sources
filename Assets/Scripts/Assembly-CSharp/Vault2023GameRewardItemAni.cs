using System;
using Spine;
using Spine.Unity;
using UnityEngine;
using XLua;

public class Vault2023GameRewardItemAni : MonoBehaviour
{
	[SerializeField]
	private SkeletonGraphic gameRewardAni;

	private Action showReward;

	private Action aniCompleteAction;

	private bool isInit;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Play;

	private static DelegateBridge __Hotfix0_Complete;

	private static DelegateBridge __Hotfix0_SpineEvent;

	private static DelegateBridge __Hotfix0_Stop;

	private static DelegateBridge __Hotfix0_PlayStand2;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	private void Init()
	{
	}

	public void Play(Action showReward, Action aniCompleteAction)
	{
	}

	private void Complete(TrackEntry trackEntry)
	{
	}

	private void SpineEvent(TrackEntry trackEntry, Spine.Event e)
	{
	}

	public void Stop()
	{
	}

	public void PlayStand2()
	{
	}
}
