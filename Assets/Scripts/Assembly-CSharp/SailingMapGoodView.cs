using System.Collections.Generic;
using UnityEngine;

public class SailingMapGoodView : MonoBehaviour
{
	private static Dictionary<SailingMapGoodCtrl.MapGoodType, Queue<SailingMapGoodItem>> goodsPool;

	private SailingMapGoodItem goodItem;

	private SailingMapGoodCtrl mCtrl;

	public static SailingMapGoodItem GetShipOne(SailingMapGoodCtrl.MapGoodType type)
	{
		return null;
	}

	public static void ClearGoodPool()
	{
	}

	public void Init(SailingMapGoodCtrl data)
	{
	}

	public void RefreshUIPositon(float mapShowPosX, float pos)
	{
	}

	public void Refresh()
	{
	}

	public void UnInit()
	{
	}

	public void PlayMonsterAttackAniTest(RectTransform target)
	{
	}
}
