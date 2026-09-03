using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class FishingDialAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private CanvasGroup dial;

	[SerializeField]
	private RectTransform dialRect;

	[SerializeField]
	private RectTransform arrow;

	private Tweener rotateAni;

	private Tweener shakeAni;

	private float originRotateAngel;

	private Vector2 originPos;

	private Sequence curSoundSeq;

	private GameObject curSoundObj;

	private FishingSoundStatus soundStatus;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_PlayStartFishing;

	private static DelegateBridge __Hotfix0_StopStartFishing;

	private static DelegateBridge __Hotfix0_PlayArrowRotate;

	private static DelegateBridge __Hotfix0_PlayShake;

	private static DelegateBridge __Hotfix0_StopShake;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_PlayRiseSound;

	private static DelegateBridge __Hotfix0_PlayFallSound;

	private static DelegateBridge __Hotfix0_StopAllSound;

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

	public void PlayStartFishing()
	{
	}

	public void StopStartFishing()
	{
	}

	public void PlayArrowRotate(float speed, FishingRodStatus status)
	{
	}

	public void PlayShake()
	{
	}

	public void StopShake()
	{
	}

	public void StopAni()
	{
	}

	private void PlayRiseSound()
	{
	}

	private void PlayFallSound()
	{
	}

	public void StopAllSound()
	{
	}
}
