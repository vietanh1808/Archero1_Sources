using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class FishingResultAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform weightBg;

	[SerializeField]
	private RectTransform weight;

	private Sequence seq;

	private Sequence weightBgSeq;

	private Sequence weightSeq;

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

	private void ResetWeightBgData()
	{
	}

	private void ResetWeightData()
	{
	}

	public void SetData()
	{
	}

	public void PlayAni()
	{
	}

	public void StopAni()
	{
	}
}
