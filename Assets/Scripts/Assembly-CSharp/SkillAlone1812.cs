using UnityEngine;

public class SkillAlone1812 : SkillAloneBase
{
	private int flashBuffId;

	private int killBuffId;

	private LocalSave.HammerPassiveV0 HammerPassiveV0 => null;

	private int FlashPoint => 0;

	private EntityAttributeBase Attribute => null;

	private long HammerChangeNeedCount => 0L;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onKill(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void OnHammerChangeState(bool isFlash)
	{
	}
}
