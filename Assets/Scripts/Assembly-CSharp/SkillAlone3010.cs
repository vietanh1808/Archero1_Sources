public class SkillAlone3010 : SkillAlone3009
{
	private int critAddBuffID;

	private const string CritAddBuffStr = "CritAddBuffStr";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void Excute(string str, bool bExcute = false)
	{
	}

	private void OnCrit(EntityBase attackTarget, long realHit, HitStruct hs)
	{
	}
}
