using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PVERankRewardDetailScrollAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private CanvasGroup canvasGroup;

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

	public void PlayAni(int targetIndex, int allCount, float viewHeight)
	{
	}

	public void StopAni()
	{
	}
}
