using System;
using System.Collections.Generic;
using UnityEngine;

public class DeadGoodCtrl
{
	private Action callback;

	private Action<FoodBase> CreateFoodAction;

	public int OneExpItems;

	public int TenExpItems;

	public int OneExpCanShow;

	public int TenExpCanShow;

	public int OneSoulPointItems;

	public int TenSoulPointItems;

	public int OneSoulPointCanShow;

	public int TenSoulPointCanShow;

	public int OnePureGoldItems;

	public int TenPureGoldItems;

	public int OnePureGoldCanShow;

	public int TenPureGoldCanShow;

	public int OneTDStoneItems;

	public int TenTDStoneItems;

	public int OneTDStoneCanShow;

	public int TenTDStoneCanShow;

	public int OneSLGTalentItems;

	public int TenSLGTalentItems;

	public int OneSLGTalentCanShow;

	public int TenSLGTalentCanShow;

	public int OneSLGCampTalentItems;

	public int TenSLGCampTalentItems;

	public int OneSLGCampTalentCanShow;

	public int TenSLGCampTalentCanShow;

	private bool bStart;

	private int currentFrame;

	private int currentindex;

	private List<BattleDropData> goodslist;

	private List<Vector2Int> Goldslist;

	private Vector2Int GoldsCenter;

	private Transform MapGoodsDrop;

	private Vector3 pos;

	private bool creating;

	public PlayerPrefsMgr.ExpDropShowType ExpShowType => PlayerPrefsMgr.ExpDropShowType.eNormal;

	private void InitExpDropShow(List<BattleDropData> goodslist)
	{
	}

	private bool UpdateExpDropCanShow(BattleDropData goodItem)
	{
		return false;
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void StartDrop(Vector3 pos, List<BattleDropData> goodslist, int radius, Transform MapGoodsDrop, Action callback, Action<FoodBase> CreateFoodAction)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private Vector3 GetRandomEndPosition(List<Vector2Int> Goldslist, Vector2Int GoldsCenter)
	{
		return default;
	}
}
