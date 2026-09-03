public class SkillAlone1733 : SkillAloneBase
{
	private int CONFIG_BUFF_ID;

	private float CONFIG_RATE;

	private float CONFIG_CD_1;

	private float CONFIG_CD_2;

	private int CONFIG_BULLET_CNT;

	private int CONFIG_BULLET_ID;

	private float CONFIG_HIT_RATIO;

	private float m_fHitTime_1;

	private float m_fHitTime_2;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void CreateDraggers(int nBulletId, int cnt)
	{
	}

	protected void DoCreateDraggers(int nBulletId, int cnt)
	{
	}
}
