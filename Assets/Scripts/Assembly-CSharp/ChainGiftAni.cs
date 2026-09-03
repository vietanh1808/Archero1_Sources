using System.Collections.Generic;
using UnityEngine;
using XLua;

public class ChainGiftAni : CInstance<ChainGiftAni>
{
	public const float MoveTime = 0.7f;

	public const float MoveOffsetTime = 0f;

	public const float ScaleTime = 0.6f;

	public const float ScaleMinOffsetTime = 0f;

	public const float ScaleMin = 0.1f;

	public const float ScaleMax = 1f;

	public const float ArrowAlphaTime = 0.5f;

	public const float LockAlphaTime = 0.25f;

	private List<IChainGiftItemAni> items;

	private List<Vector3> points;

	private int originCount;

	private static DelegateBridge __Hotfix0_get_ShowCount;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_CheckPlayAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int ShowCount => 0;

	public void PlayAni(List<IChainGiftItemAni> items, List<Vector3> points)
	{
	}

	private void CheckPlayAni(int pointCount)
	{
	}
}
