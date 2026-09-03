public class SkillAlone2288 : SkillAloneBase
{
	private float m_rate;

	private float m_pvehp;

	private float m_pvphp;

	private int m_buffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void onHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void onKillEnd(EntityBase entity)
	{
	}

	private bool isBuffState(EntityBase entity)
	{
		return false;
	}
}
