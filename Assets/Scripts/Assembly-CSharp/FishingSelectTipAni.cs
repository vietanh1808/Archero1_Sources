using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class FishingSelectTipAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private DxxText fishingUpName;

	[SerializeField]
	private DxxText fishingUpDesc;

	[SerializeField]
	private RectTransform tips;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private Sequence seq;

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

	public void ResetData()
	{
	}

	public void PlayAni(FishingUpStatus upStatus)
	{
	}

	public void StopAni()
	{
	}
}
