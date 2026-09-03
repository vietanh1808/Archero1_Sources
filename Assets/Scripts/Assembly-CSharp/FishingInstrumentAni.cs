using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingInstrumentAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform arrow;

	[SerializeField]
	private Transform goodArea;

	[SerializeField]
	private Image selectArea;

	private int curSelectAreaIndex;

	private Sequence sequence;

	private float curAngle;

	private (float, float) goodAreaRange;

	private (float, float) perfectAreaRange;

	private Tween delayedCall;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_ResetData;

	private static DelegateBridge __Hotfix0_RandomPerfectArea;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_RefreshSelectArea;

	private static DelegateBridge __Hotfix0_GetInstrumentGoodMaxAngle;

	private static DelegateBridge __Hotfix0_GetInstrumentGoodMinAngle;

	private static DelegateBridge __Hotfix0_GetInstrumentPerfectMaxAngle;

	private static DelegateBridge __Hotfix0_GetInstrumentPerfectMinAngle;

	private static DelegateBridge __Hotfix0_GetFishingUpStatus;

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

	public void PlayAni()
	{
	}

	public FishingUpStatus StopAni(bool isNeedDelay)
	{
		return FishingUpStatus.None;
	}

	private void ResetData()
	{
	}

	private void RandomPerfectArea()
	{
	}

	private void Open()
	{
	}

	private void Close()
	{
	}

	public void RefreshSelectArea(int selectAreaIndex)
	{
	}

	private float GetInstrumentGoodMaxAngle()
	{
		return 0f;
	}

	private float GetInstrumentGoodMinAngle()
	{
		return 0f;
	}

	private float GetInstrumentPerfectMaxAngle()
	{
		return 0f;
	}

	private float GetInstrumentPerfectMinAngle()
	{
		return 0f;
	}

	private FishingUpStatus GetFishingUpStatus()
	{
		return FishingUpStatus.None;
	}
}
