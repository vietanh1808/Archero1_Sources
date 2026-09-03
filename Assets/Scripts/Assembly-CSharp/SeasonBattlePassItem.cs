using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeasonBattlePassItem : SeasonBattlePassItemBase
{
	public GameObject unLockBg;

	public GameObject lockBg;

	public GameObject Lev;

	public GameObject LevLine;

	public GameObject unLockLight;

	public Text levText;

	public BattlePass_BigPropOne freeItem;

	public BattlePass_BigPropOne buyItem;

	public Image Image_Lev;

	private SeasonBattlePassData infoData;

	private List<BattlePass_BigPropOne> itemList;

	public override void Init()
	{
	}

	public override void SetData(SeasonBattlePassData pData, int pIndex)
	{
	}

	private void OnClickItem(int pIndex, PropOneBase prop, object obj)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override bool HasReward()
	{
		return false;
	}

	public override bool IsGotPayItemReward()
	{
		return false;
	}

	private int GetMask(int pMask, int pIndex)
	{
		return 0;
	}

	private bool IsGot(int pIndex)
	{
		return false;
	}

	public override void RestUI()
	{
	}
}
