using UnityEngine.UI;

public class SeasonBattlePassEndItem : SeasonBattlePassItemBase
{
	public BattlePass_BigPropOne item1;

	public Text moreContext;

	public Text gotCount;

	public Text moreText;

	private SeasonBattlePassEndData infoData;

	public override void Init()
	{
	}

	public override void SetData(SeasonBattlePassData pData, int pIndex)
	{
	}

	public void SetAllRewardState(bool pgot)
	{
	}

	private int CanRewardCount()
	{
		return 0;
	}

	public override void RestUI()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickItemEnd(PropOneBase prop, object obj)
	{
	}
}
