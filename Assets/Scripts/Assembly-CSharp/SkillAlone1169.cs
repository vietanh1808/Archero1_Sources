public class SkillAlone1169 : SkillAloneBase
{
	private float m_fTime;

	private float m_fInterval;

	private float m_fRate;

	private float m_fRange;

	private int m_nDebuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected virtual EntityBase GetTarget()
	{
		return null;
	}

	protected virtual bool Random()
	{
		return false;
	}
}
