public class SkillAloneBuffHitBase : SkillAloneBase
{
	private int buffId;

	protected virtual EElementType CurElementType => EElementType.eNone;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onElementHit(EntityBase hittedEntity, HitStruct hs, HittedData hd)
	{
	}
}
