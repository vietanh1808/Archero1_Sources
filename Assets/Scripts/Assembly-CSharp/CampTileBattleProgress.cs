using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileBattleProgress : MonoBehaviour
{
	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private RectTransform leftProgress;

	[SerializeField]
	private Image leftProgressImg;

	[SerializeField]
	private DxxText leftProgressText;

	[SerializeField]
	private RectTransform rightProgress;

	[SerializeField]
	private Image rightProgressImg;

	[SerializeField]
	private DxxText rightProgressText;

	[SerializeField]
	private Image leftIcon;

	[SerializeField]
	private Image rightIcon;

	[SerializeField]
	private CampTileBattleProgressAni progressAni;

	[SerializeField]
	private RectTransform battleIcon;

	private HashSet<CampID> tilePosCamp;

	private float progressOriginWidth;

	private CampID leftCampID;

	private CampID rightCampID;

	private (CampID, CampID) progressStatus;

	private CampID occupyCamp;

	private List<(CampID, int)> currencyData;

	private int needValue;

	private (CampID, int) firstData;

	private (CampID, int) lastData;

	private int curValue;

	private CampTileBattleStatus battleStatus;

	private static DelegateBridge __Hotfix0_get_IsLeftCampOccupy;

	private static DelegateBridge __Hotfix0_get_IsLeftCampAttack;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshImg;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshLeft;

	private static DelegateBridge __Hotfix0_RefreshRight;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshBattleIcon;

	private static DelegateBridge __Hotfix0_GetProgressStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool IsLeftCampOccupy => false;

	private bool IsLeftCampAttack => false;

	public void Init()
	{
	}

	public void Refresh(List<(CampID, int)> currencyData, int needValue, CampID occupyCamp, HashSet<CampID> tilePosCamp, CampTileBattleStatus battleStatus)
	{
	}

	public Sequence PlayAni(CampTileArrowDamageData damageData, CampTileOccupyType occupyType)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshImg()
	{
	}

	public void RefreshProgress()
	{
	}

	public void RefreshLeft((CampID, int) occupyData, int needValue, out float leftProgressWidth)
	{
		leftProgressWidth = default;
	}

	public void RefreshRight((CampID, int) occupyData, float leftProgressWidth)
	{
	}

	public void RefreshText((CampID, int) rightData, (CampID, int) leftData, CampID occupyCamp)
	{
	}

	public void RefreshBattleIcon(float leftProgressWidth)
	{
	}

	public (CampID, CampID) GetProgressStatus()
	{
		return default;
	}
}
