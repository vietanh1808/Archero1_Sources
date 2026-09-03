using Spine;
using Spine.Unity;
using UnityEngine;
using XLua;

public class CampTileBossSpineAni : MonoBehaviour
{
	[SerializeField]
	private GameObject protectPar;

	[SerializeField]
	private GameObject spineAni;

	[SerializeField]
	private GameObject bossPar;

	[SerializeField]
	private SkeletonGraphic bossSpine;

	private Spine.AnimationState animationState;

	private BossBattleStatus battleStatus;

	private BossBattleStatus recordBattleStatus;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshSpine;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh(BossBattleStatus battleStatus)
	{
	}

	public void RefreshSpine()
	{
	}

	public void RefreshStatus()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Close()
	{
	}
}
