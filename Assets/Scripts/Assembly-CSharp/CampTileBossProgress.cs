using System;
using System.Collections.Generic;
using DG.Tweening;
using TableTool;
using UnityEngine;
using XLua;

public class CampTileBossProgress : MonoBehaviour
{
	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private Transform bannerParent;

	[SerializeField]
	private CampTileBossBanner banner;

	[SerializeField]
	private Transform chestParent;

	[SerializeField]
	private CampTileChest chest;

	[SerializeField]
	private CampTileNormalProgressAni progressAni;

	private LocalUnityObjctPool pool;

	private float progressOriginWidth;

	private List<(CampID, int)> occupyData;

	private int needValue;

	private List<(int, List<Drop_DropModel.DropData>)> rewards;

	private Func<int, CampTileRewardStatus> rewardStatus;

	private BossBattleStatus bossBattleStatus;

	private (int, int) position;

	private int curValue;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshBanner;

	private static DelegateBridge __Hotfix0_RefreshChest;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh(List<(CampID, int)> occupyData, int needValue, List<(int, List<Drop_DropModel.DropData>)> rewards, Func<int, CampTileRewardStatus> rewardStatus, BossBattleStatus bossBattleStatus, (int, int) position)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshProgress()
	{
	}

	public void RefreshBanner()
	{
	}

	public void RefreshChest()
	{
	}

	public void InitObjectPool()
	{
	}

	public Sequence PlayAni(CampTileArrowDamageData damageData, CampID recordOccupyCamp, CampTileOccupyType occupyType)
	{
		return null;
	}

	public void StopAni()
	{
	}
}
