using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CampTileOccupyBtn : MonoBehaviour
{
	[SerializeField]
	private CampTileOccupyBtnItem campTileBtnItem;

	[SerializeField]
	private Transform parent;

	private List<CampTileOccupyBtnItem> createList;

	private LocalUnityObjctPool clickBtnPool;

	private CampTileOccupyAttackType data;

	private (int, int) position;

	private int[] occupyValue;

	private CampID recordOccupyCamp;

	private int needValue;

	private bool isPass;

	private CampTileType tileType;

	private CampTileResourceType resourceType;

	private CampID attackBossDefenderCamp;

	private BossBattleStatus bossBattleStatus;

	private int[] bossMonsterOccupyValue;

	private int bossBattleStatusCode;

	private int[] bossCampRank;

	private int[] bossCampScore;

	private Func<bool> isBtnEnableExtra;

	private Func<bool> clickBtnDisableExtra;

	private Func<bool> clickBtnExtra;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_SetResourceType;

	private static DelegateBridge __Hotfix0_SetAttackBossData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshClickBtn;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public CampTileOccupyBtn Refresh(CampTileOccupyAttackType data, (int, int) position, int[] occupyValue, CampID recordOccupyCamp, int needValue, bool isPass, CampTileType tileType, Func<bool> isBtnEnableExtra, Func<bool> clickBtnDisableExtra, Func<bool> clickBtnExtra)
	{
		return null;
	}

	public void PlayAni(int allArrowCount)
	{
	}

	public void StopAni()
	{
	}

	public void OnLanguageChange()
	{
	}

	public CampTileOccupyBtn SetResourceType(CampTileResourceType resourceType)
	{
		return null;
	}

	public CampTileOccupyBtn SetAttackBossData(CampID attackBossDefenderCamp, BossBattleStatus bossBattleStatus, int bossBattleStatusCode, int[] bossMonsterOccupyValue, int[] bossCampRank, int[] bossCampScore)
	{
		return null;
	}

	public void InitObjectPool()
	{
	}

	private void RefreshClickBtn()
	{
	}
}
