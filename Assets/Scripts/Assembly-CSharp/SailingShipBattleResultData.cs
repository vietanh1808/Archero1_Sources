using System.Collections.Generic;
using TableTool;

public class SailingShipBattleResultData
{
	public SailingShipBattleFighter Winner { get; set; }

	public List<Drop_DropModel.DropData> Rewards { get; set; }

	public int BattleScore { get; set; }

	public SailingShipBattleRequestType BattleType => SailingShipBattleRequestType.None;

	public bool IsPvp => false;

	public bool HavePveReward => false;

	public bool HaveReward => false;

	public static SailingShipBattleResultData Create(SailingShipBattleFighter winner, int battleScore, List<Drop_DropModel.DropData> dropProp)
	{
		return null;
	}
}
