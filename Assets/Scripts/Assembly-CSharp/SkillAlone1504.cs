using System.Collections.Generic;

public class SkillAlone1504 : SkillAloneBase
{
	private string attrName;

	private float delayTime;

	private long maxPercentage;

	private long cumulatedMaxPercentage;

	private float power;

	private long minValue;

	private long maxValue;

	private long cumulatedMaxValue;

	private Queue<long> deltaValueQueue;

	private long oldMaxHP;

	private string AttrKey => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHpMaxUpdate(long value)
	{
	}

	private void onCreatePlayer()
	{
	}

	private string getDeltaHPMaxStr(long deltaValue)
	{
		return null;
	}

	private void onHitted(EntityBase enemy, long deltaHp)
	{
	}

	private long getDeltaHPMax(long maxHp, long deltaHp)
	{
		return 0L;
	}

	private void addAttr2Entity(long deltaValue)
	{
	}
}
