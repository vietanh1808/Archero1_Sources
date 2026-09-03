using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class FishingAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private CanvasGroup bottomGroup;

	[SerializeField]
	private CanvasGroup leftGroup;

	[SerializeField]
	private CanvasGroup rightGroup;

	[SerializeField]
	private GameObject lureFeatureGroup;

	[SerializeField]
	private GameObject rodName;

	[SerializeField]
	private GameObject lureShowGroup;

	private Vector2 bottomOriginPos;

	private Vector2 bottomTargetPos;

	private Vector2 leftOriginPos;

	private Vector2 leftTargetPos;

	private Vector2 rightOriginPos;

	private Vector2 rightTargetPos;

	private Sequence sequence;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ResetAni;

	private static DelegateBridge __Hotfix0_PlayAniOut;

	private static DelegateBridge __Hotfix0_PlayAniIn;

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

	public void ResetAni()
	{
	}

	public void PlayAniOut()
	{
	}

	public void PlayAniIn()
	{
	}
}
