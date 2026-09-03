using System;
using Spine.Unity;
using TableTool;
using UnityEngine;

public class PyramidTreasureItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage Image_Bg;

	[SerializeField]
	private PropOneEquip propItem;

	[SerializeField]
	private SkeletonGraphic sk_Broken;

	private DxxImage image_Mask;

	private Drop_DropModel.DropData data;

	private int circleIndex;

	private int ColorType;

	private ActPyramidTreasureMgr ptMgr => null;

	private void Awake()
	{
	}

	public void Init(Drop_DropModel.DropData rData, int circleIndex)
	{
	}

	public void SetImageBgState(bool isShow)
	{
	}

	public bool GetImageBgState()
	{
		return false;
	}

	public void SetMaskState(bool state)
	{
	}

	public void PlayShuffleAni()
	{
	}

	public void PlayBrokenAni(Action aniEnd, bool isShow)
	{
	}
}
