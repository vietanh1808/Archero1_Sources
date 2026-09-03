using System.Collections.Generic;

public class SkillTowerDefenseUpgradeMediator : MediatorBase
{
	public new const string NAME = "SkillTowerDefenseUpgradeMediator";

	public override List<string> OnListNotificationInterests => null;

	public SkillTowerDefenseUpgradeMediator()
		: base(null)
	{
	}
}
