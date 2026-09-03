using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingFishAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText distanceText;

	private FishingFishStatus fishStatus;

	private Vector2 originPos;

	private Vector3 originScale;

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

	public void PlayAni(FishingFishStatus fishStatus, float distance, float speed, FishingRodStatus rodStatus)
	{
	}

	public void StopAni()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}
}
