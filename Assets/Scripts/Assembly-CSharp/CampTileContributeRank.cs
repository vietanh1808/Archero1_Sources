using System;
using UnityEngine;
using XLua;

public class CampTileContributeRank : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private Transform content;

	[SerializeField]
	private CampTileContributeRankItem item;

	private LocalUnityObjctPool rankItemPool;

	private ulong[] scores;

	private int[] ranks;

	private ulong maxValue;

	private Action<int> chestClick;

	private int rankIconStyle;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshRankItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh(ulong[] scores, int[] ranks, string titleStr, int rankIconStyle, Action<int> chestClick)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void InitObjectPool()
	{
	}

	public void RefreshRankItem()
	{
	}
}
