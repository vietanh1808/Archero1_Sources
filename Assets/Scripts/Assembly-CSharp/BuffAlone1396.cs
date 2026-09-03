public class BuffAlone1396 : BuffAloneBase
{
	private float m_fHittedTime;

	private int m_nHittedTimes;

	private int m_nConfigTimes;

	private float m_fConfigTime;

	protected override void OnStart()
	{
	}

	protected override void OnRemove()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}
}
