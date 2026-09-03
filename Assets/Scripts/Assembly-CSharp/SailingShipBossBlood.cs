using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipBossBlood : MonoBehaviour
{
	[SerializeField]
	private Image progress1Icon;

	[SerializeField]
	private Image progress2Icon;

	[SerializeField]
	private RectTransform progress1Rect;

	[SerializeField]
	private RectTransform progress2Rect;

	[SerializeField]
	private SailingShipBossBloodAni bloodAni;

	[SerializeField]
	private DxxText dmgScore;

	private Queue<SailingShipBossBloodData> progressData;

	private int perBloodMaxValue;

	private float progressOriginWidth;

	private bool isInit;

	private int curValue;

	private bool isPlayAni;

	private bool isJumpGame;

	private int progressActiveIndex;

	private int progressIconIndex;

	private int index;

	private bool haveJumpGame;

	private int useProgressActiveIndex;

	private int useProgressIconIndex;

	private RectTransform CurProgress => null;

	private float CurProgressValue => 0f;

	private float CurProgressRealValue => 0f;

	private RectTransform GetProgress(int activeIndex)
	{
		return null;
	}

	private void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh(int curValue, bool isPlayAni, bool isJumpGame)
	{
	}

	private void RefreshIndex()
	{
	}

	public void RefreshProgressShow(SailingShipBossBloodData data)
	{
	}

	private void RefreshProgress()
	{
	}

	public void RefreshProgressNotAni()
	{
	}

	private void RefreshFinalProgressNotAni()
	{
	}

	private void RefreshProgressWithAni()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}
}
