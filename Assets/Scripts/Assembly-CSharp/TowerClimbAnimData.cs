public class TowerClimbAnimData
{
	private float[] dispearMonsterData;

	private float[] appearMonsterData;

	private float startTime;

	public const float TOTAL_PLAYTIME = 1f;

	public const float SCALE_TIME = 0.2f;

	public const float MONSTER_DISPPEAR_START_MAXTIME = 0.2f;

	public const float APPEAR_START_TIME = 0.5f;

	public const float MONSTER_APPEAR_START_MAXTIME = 0.7f;

	public const float CLOUD_DISPEAR_TIME = 0.5f;

	public bool isBeginAppear()
	{
		return false;
	}

	public float GetDisppearScale(int index)
	{
		return 0f;
	}

	public float GetAppearScale(int index)
	{
		return 0f;
	}

	public float GetHeroDispearScale()
	{
		return 0f;
	}

	public float GetHeroAppearScale()
	{
		return 0f;
	}

	public float GetCloudAlpha()
	{
		return 0f;
	}

	public bool isEnd()
	{
		return false;
	}
}
