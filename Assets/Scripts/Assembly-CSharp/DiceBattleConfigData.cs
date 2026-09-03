using System.Collections.Generic;
using Newtonsoft.Json;

public class DiceBattleConfigData
{
	[JsonProperty("Base")]
	public List<DBBaseConfig> baseListCfg;

	[JsonProperty("BossReward")]
	public List<DBBossRewardConfig> bossCfgList;

	[JsonProperty("WheelReward")]
	public List<DBWheelRewardConfig> wheelCfgList;

	[JsonProperty("Rule")]
	public List<DBRuleConfig> ruleCfgList;
}
