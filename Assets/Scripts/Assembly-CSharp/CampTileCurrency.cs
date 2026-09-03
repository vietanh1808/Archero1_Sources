using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using XLua;

public class CampTileCurrency : MonoBehaviour
{
	[SerializeField]
	private DxxText ironArrowCount;

	[SerializeField]
	private DxxText goldArrowCount;

	[SerializeField]
	private CampTileCurrencyAni currencyAni;

	[SerializeField]
	private Transform currencyAniParent;

	private Sequence returnArrowSequence;

	private List<CampTileCurrencyAni> currencyAniList;

	private static DelegateBridge __Hotfix0_get_CampManager;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampManager CampManager => null;

	public void Init()
	{
	}

	public void Refresh(CampTileOccupyAttackType data)
	{
	}

	public Sequence PlayAni(int returnIronArrow, int returnGoldArrow, Vector3 startPos)
	{
		return null;
	}

	public void StopAni()
	{
	}
}
