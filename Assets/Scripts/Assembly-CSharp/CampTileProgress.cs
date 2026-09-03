using System;
using System.Collections.Generic;
using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileProgress : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private CampTileNormalProgress normalProgress;

	[SerializeField]
	private CampTileBattleProgress battleProgress;

	[SerializeField]
	private CampTileBossProgress bossProgress;

	private CampTileOccupyType occupyType;

	private CampID occupyCamp;

	private HashSet<CampID> tilePosCamp;

	private int[] occupyValue;

	private int needValue;

	private List<(int, List<Drop_DropModel.DropData>)> rewards;

	private Func<int, CampTileRewardStatus> rewardStatus;

	private ProgressType progressType;

	private string tipTitleKey;

	private string tipContentKey;

	private CampTileBattleStatus battleStatus;

	private BossBattleStatus bossBattleStatus;

	private (int, int) position;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_SetTipData;

	private static DelegateBridge __Hotfix0_SetBattleStatus;

	private static DelegateBridge __Hotfix0_SetBossBattleStatus;

	private static DelegateBridge __Hotfix0_PlayNormalAni;

	private static DelegateBridge __Hotfix0_PlayBattleAni;

	private static DelegateBridge __Hotfix0_PlayBossAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_CalcNeedValue;

	private static DelegateBridge __Hotfix0_GetProgressType;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public CampTileProgress Refresh(CampTileOccupyType occupyType, CampID occupyCamp, HashSet<CampID> tilePosCamp, int[] occupyValue, int needValue, List<(int, List<Drop_DropModel.DropData>)> rewards, Func<int, CampTileRewardStatus> rewardStatus)
	{
		return null;
	}

	public CampTileProgress SetTipData(string tipTitleKey, string tipContentKey)
	{
		return null;
	}

	public CampTileProgress SetBattleStatus(CampTileBattleStatus battleStatus)
	{
		return null;
	}

	public CampTileProgress SetBossBattleStatus(BossBattleStatus bossBattleStatus, (int, int) position)
	{
		return null;
	}

	public Sequence PlayNormalAni(CampTileArrowDamageData damageData, CampID recordOccupyCamp)
	{
		return null;
	}

	public Sequence PlayBattleAni(CampTileArrowDamageData damageData)
	{
		return null;
	}

	public Sequence PlayBossAni(CampTileArrowDamageData damageData, CampID recordOccupyCamp)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshProgress()
	{
	}

	private void ClickInfo()
	{
	}

	public int CalcNeedValue(int defaultNeedValue)
	{
		return 0;
	}

	public ProgressType GetProgressType()
	{
		return ProgressType.None;
	}
}
