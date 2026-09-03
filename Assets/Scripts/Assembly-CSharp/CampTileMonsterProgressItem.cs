using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileMonsterProgressItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private GameObject attackingIcon;

	[SerializeField]
	private CampTileNormalProgressAni progressAni;

	[SerializeField]
	private Image progressImg;

	[SerializeField]
	private Image campFlagIcon;

	[SerializeField]
	private DxxText monsterName;

	private float progressOriginWidth;

	private bool isInit;

	private int curValue;

	private int needValue;

	private CampID curMonsterCampID;

	private bool isAttacking;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshImg;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_GetMonsterIconTrans;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampID curMonsterCampID, bool isAttacking, int curValue, int needValue)
	{
	}

	public void RefreshProgress()
	{
	}

	public void RefreshImg()
	{
	}

	public void RefreshText()
	{
	}

	public Sequence PlayAni(CampTileArrowDamageData damageData, CampID recordOccupyCamp)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public RectTransform GetMonsterIconTrans()
	{
		return null;
	}
}
