using System;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipWarningAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private GameObject warning;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private RectTransform leftTipRect;

	[SerializeField]
	private RectTransform rightTipRect;

	[SerializeField]
	private RectTransform leftMiddlePos;

	[SerializeField]
	private RectTransform rightMiddlePos;

	[SerializeField]
	private RectTransform leftEndPos;

	[SerializeField]
	private RectTransform rightEndPos;

	[Header("动画入场时间")]
	[SerializeField]
	private float aniEnterTime;

	[Header("动画悬停时间")]
	[SerializeField]
	private float aniHoldingTime;

	[Header("动画退场时间")]
	[SerializeField]
	private float aniExitTime;

	private SequencePool aniPool;

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

	public void PlayAni(Action completeAction)
	{
	}

	public void StopAni()
	{
	}
}
