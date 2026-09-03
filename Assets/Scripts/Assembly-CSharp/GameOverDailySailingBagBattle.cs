using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using TableTool;

public class GameOverDailySailingBagBattle : GameOverDailyNewPlay125
{
	private List<Drop_DropModel.DropData> _currencyDrops;

	private const string Tag = "GameOverDailySailingBagBattle";

	protected override int SaveDailyScore(int dailyId, int layer)
	{
		return 0;
	}

	protected override void OnClickClose()
	{
	}

	protected override bool HaveReward()
	{
		return false;
	}

	protected override int GetCurrencyCount(CurrencyType currencyType)
	{
		return 0;
	}

	protected override void AddOtherCurrency(Sequence s, ref int index)
	{
	}

	protected override void AddOtherCurrencyImmediatly(ref int index)
	{
	}

	protected override void CheckOtherCurrency(ref int index)
	{
	}

	private List<Drop_DropModel.DropData> GetResultRewards()
	{
		return null;
	}

	protected override bool CanShowPiggy()
	{
		return false;
	}

	protected override void SendGameOver()
	{
	}

	protected override void OnAddEquipOneItem(PropOneEquip item)
	{
	}

	public override void OnLanguageChange()
	{
	}

	[Conditional("EnableLog")]
	private void Log(string log)
	{
	}
}
