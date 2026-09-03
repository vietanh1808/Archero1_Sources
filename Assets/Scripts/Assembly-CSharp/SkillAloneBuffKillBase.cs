using UnityEngine;

public class SkillAloneBuffKillBase : SkillAloneBase
{
	private int buffId;

	protected virtual EElementType CurElementType => EElementType.eNone;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onKill(EntityBase killedEntity, Vector3 hittedDir, HitStruct hs)
	{
	}
}
