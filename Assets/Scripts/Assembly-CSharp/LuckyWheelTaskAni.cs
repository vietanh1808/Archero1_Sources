using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class LuckyWheelTaskAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform aniContent;

	[SerializeField]
	private CanvasGroup mask;

	private Vector2 originPos;

	private Vector2 targetPos;

	private Tweener ani;

	private Tweener maskAni;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ReSet;

	private static DelegateBridge __Hotfix0_ResetAni;

	private static DelegateBridge __Hotfix0_PlayAniGo;

	private static DelegateBridge __Hotfix0_PlayAniBack;

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

	private void ReSet()
	{
	}

	private void ResetAni()
	{
	}

	public void PlayAniGo()
	{
	}

	public void PlayAniBack()
	{
	}
}
