using System;
using DG.Tweening;
using UnityEngine;

public class MainUIGoldAddCtrl : MonoBehaviour
{
	public DxxText text;

	public RectTransform imageRect;

	public Transform child;

	public CanvasGroup mCanvasGroup;

	public Action<MainUIGoldAddCtrl> OnFinish;

	private Sequence seq;

	private void KillSequence()
	{
	}

	public void SetGold(long gold)
	{
	}
}
