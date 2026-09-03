public static class BattleSystemProfileGateway
{
	private static BattleSystemProfileConfig _assetConfig;

	public static bool CheckEggAttrs()
	{
		return false;
	}

	public static bool CheckEggAttrs(BattleSystemProfile profile)
	{
		return false;
	}

	public static BattleSystemProfileDecision CheckEggAttrsDecision()
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckEggAttrsDecision(BattleSystemProfile profile)
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckPetAttrsDecision()
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckPetAttrsDecision(BattleSystemProfile profile)
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckAttrsDecision(int systemId)
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckAttrsDecision(BattleSystemProfile profile, int systemId)
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckSkillsDecision(int systemId)
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	public static BattleSystemProfileDecision CheckSkillsDecision(BattleSystemProfile profile, int systemId)
	{
		return BattleSystemProfileDecision.NotConfigured;
	}

	private static bool HasAttrs(int systemMode)
	{
		return false;
	}

	private static bool HasSkills(int systemMode)
	{
		return false;
	}

	private static BattleSystemProfile GetCurrentAssetProfile()
	{
		return null;
	}

	private static BattleSystemProfileConfig LoadAssetConfig()
	{
		return null;
	}
}
