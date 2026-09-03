using System.Collections.Generic;

public class SkillAlone2273 : SkillAloneBase
{
	private float lifeRate;

	private string GodPunishEffPath;

	private bool isPVPHit;

	private List<int> punishGuidList;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private string InitGodPunishEffPath()
	{
		return null;
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void CastTridentDivinePunish(EntityBase enemy, HitStruct hs)
	{
	}

	private void OnHitByGodPunish(HitStruct hs)
	{
	}
}
