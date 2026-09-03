using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using XLua;

public class CampTileNormalProgress : MonoBehaviour
{
	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private CampTileNormalProgressAni progressAni;

	private float progressOriginWidth;

	private int curValue;

	private int needValue;

	private CampID occupyCamp;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh(List<(CampID, int)> occupyData, int needValue, CampID occupyCamp)
	{
	}

	public Sequence PlayAni(CampTileArrowDamageData damageData, CampID recordOccupyCamp, CampTileOccupyType occupyType)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public void OnLanguageChange()
	{
	}
}
