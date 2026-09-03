using UnityEngine;
using XLua;

public class CampTileMonsterProgress : MonoBehaviour
{
	[SerializeField]
	private GameObject content;

	[SerializeField]
	private RectTransform bg;

	[SerializeField]
	private CampTileMonsterProgressItem campLT;

	[SerializeField]
	private CampTileMonsterProgressItem CampRT;

	[SerializeField]
	private CampTileMonsterProgressItem CampLB;

	[SerializeField]
	private CampTileMonsterProgressItem CampRB;

	private int[] monsterScore;

	private int monsterNeedValue;

	private CampID attackMonsterCamp;

	private BossBattleStatus bossBattleStatus;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshClickBtn;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh(CampID attackMonsterCamp, int[] monsterScore, int monsterNeedValue, BossBattleStatus bossBattleStatus)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshClickBtn()
	{
	}

	public void RefreshStatus()
	{
	}
}
