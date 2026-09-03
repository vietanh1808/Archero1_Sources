using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class FishingRodBloodAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform progress;

	private float progressOriginWidth;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

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

	public void PlayAni(float curProgress, float maxProgress)
	{
	}

	public void StopAni()
	{
	}

	private void Open()
	{
	}

	private void Close()
	{
	}
}
