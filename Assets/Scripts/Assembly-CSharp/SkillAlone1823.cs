using Dxx.Util;

public class SkillAlone1823 : SkillAloneBase
{
	private int thunderWaveCount;

	private int thunderPerWaveCount;

	private float CallThunderAttackPrevPlayScale;

	private float CallThunderAttackEndPlayScale;

	public const string CallThunderAttackPrev = "CallThunderAttackPrev";

	public const string CallThunderAttackEnd = "CallThunderAttackEnd";

	public const float CallThunderAttackPrevTime = 1.07f;

	public const float CallThunderAttackEndTime = 0.11f;

	private SequencePool seqPool;

	private float CallThunderAttackPrevDiffSpeed => 0f;

	private float CallThunderAttackEndDiffSpeed => 0f;

	private float AniAllTime => 0f;

	private float CallThunderAttackPrevPlayTime => 0f;

	private float CallThunderAttackEndPlayTime => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void AddExtraAnims()
	{
	}

	private void OnSuperSkill()
	{
	}

	private void CreateThunder()
	{
	}
}
