using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileOccupyBtnItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private new DxxText name;

	[SerializeField]
	private DxxText count;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image btnIcon;

	private CampTileOccupyAttackType type;

	private (int, int) position;

	private CampTileType tileType;

	private CampTileResourceType resourceType;

	private CampID attackBossDefenderCamp;

	private Func<bool> isBtnEnableExtra;

	private Func<bool> clickBtnDisableExtra;

	private Func<bool> clickBtnExtra;

	private int[] recordOccupyValue;

	private int needValue;

	private CampID occupyCamp;

	private int bossBattleStatus;

	private int[] bossMonsterOccupyValue;

	private int[] bossCampRank;

	private int[] bossCampScore;

	private static DelegateBridge __Hotfix0_get_CampTileManager;

	private static DelegateBridge __Hotfix0_get_BattleNeedActionPower;

	private static DelegateBridge __Hotfix0_get_TileID;

	private static DelegateBridge __Hotfix0_get_TileIndex;

	private static DelegateBridge __Hotfix0_get_BattleInfo;

	private static DelegateBridge __Hotfix0_get_BattleType;

	private static DelegateBridge __Hotfix0_get_BattleValue;

	private static DelegateBridge __Hotfix0_get_BattleTransID;

	private static DelegateBridge __Hotfix0_set_BattleTransID;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshInfo;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_Disable;

	private static DelegateBridge __Hotfix0_RequestBattle;

	private static DelegateBridge __Hotfix0_Battle;

	private static DelegateBridge __Hotfix0_RequestSweep;

	private static DelegateBridge __Hotfix0_IsBtnEnableExtra;

	private static DelegateBridge __Hotfix0_ClickBtnDisableExtra;

	private static DelegateBridge __Hotfix0_ClickBtnExtra;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTileManager CampTileManager => null;

	private int BattleNeedActionPower => 0;

	private int TileID => 0;

	private int TileIndex => 0;

	private (BattleType, int) BattleInfo => default;

	private BattleType BattleType => BattleType.None;

	private int BattleValue => 0;

	private uint BattleTransID { get; set; }

	public void Refresh(CampTileOccupyAttackType type, (int, int) position, int[] occupyValue, CampID occupyCamp, int needValue, CampTileType tileType, CampTileResourceType resourceType, CampID attackBossDefenderCamp, int bossBattleStatus, int[] bossMonsterOccupyValue, int[] bossCampRank, int[] bossCampScore, Func<bool> isBtnEnableExtra, Func<bool> clickBtnDisableExtra, Func<bool> clickBtnExtra)
	{
	}

	public void RefreshInfo()
	{
	}

	public void RefreshStatus()
	{
	}

	private void Click()
	{
	}

	public void Disable()
	{
	}

	public void RequestBattle()
	{
	}

	public void Battle()
	{
	}

	public void RequestSweep()
	{
	}

	public bool IsBtnEnableExtra()
	{
		return false;
	}

	public bool ClickBtnDisableExtra()
	{
		return false;
	}

	public bool ClickBtnExtra()
	{
		return false;
	}

	public void PlayAni(int allArrowCount)
	{
	}

	public void StopAni()
	{
	}
}
