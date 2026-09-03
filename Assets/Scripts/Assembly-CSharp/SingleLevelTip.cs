using System;
using DG.Tweening;
using UnityEngine;

public class SingleLevelTip : MonoBehaviour
{
	public bool isFutureEvent;

	public DxxImage img_bg;

	public DxxImage img_icon;

	public DxxText txt_level;

	private float normalSize;

	private Vector2 levelSize;

	private Vector2 iconSize;

	private Vector2 bgSize;

	private float shrinkFactor;

	private Sequence seq;

	private float scaleTime;

	public void Refresh(int roomId, bool passed, string iconStr)
	{
	}

	public void PlayTxtAnim(Action callback)
	{
	}

	private void killSeq()
	{
	}

	public void DeInit()
	{
	}
}
