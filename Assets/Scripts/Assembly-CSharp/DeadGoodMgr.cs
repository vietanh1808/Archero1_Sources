using System.Collections.Generic;
using UnityEngine;

public class DeadGoodMgr
{
	private List<DeadGoodCtrl> mList;

	private List<FoodEquipBase> m_listDropEquips;

	private List<FoodEquipStyleBase> m_listDropEquipStyleEquips;

	private int m_nTotalCoin;

	private const int MaxShowNum = 10;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public void OnGotoNextRound()
	{
	}

	public void StartDrop(Vector3 pos, List<BattleDropData> goodslist, int radius, Transform MapGoodsDrop)
	{
	}

	public int GetGoldNum()
	{
		return 0;
	}
}
