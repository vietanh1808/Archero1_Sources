using System;
using UnityEngine;

public class PushPillarChoiceItem : MonoBehaviour
{
	public Transform equipRoot;

	public GameObject selectedMark;

	public DxxText remainText;

	public GameObject grayMask;

	public ButtonCtrl clickBtn;

	public GameObject lockObj;

	private PushPillarChoiceRewardData itemData;

	private PropOneEquip propOneEquip;

	private Action clickAction;

	private Action doubleClickAction;

	private float lastDownTime;

	private int remainCount;

	private static readonly float DoubleTapInterval;

	public int RewardId => 0;

	public void Init()
	{
	}

	private void OnBtnDown()
	{
	}

	public void SetData(PushPillarChoiceRewardData data)
	{
	}

	public void SetRemainCount(int remain, int max)
	{
	}

	public void SetLockCount(int remain)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void SetGray(bool gray)
	{
	}

	public void SetClickAction(Action action, Action doubleClick = null)
	{
	}

	private void OnDestroy()
	{
	}
}
