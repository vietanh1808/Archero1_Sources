using Dxx.Util;

public class SkillAlone1870 : SkillAlonePetBase
{
	private float skillPrevScale;

	private float skillEndScale;

	private int circleWaveBulletID;

	private float circleWaveRadius;

	private float circleWaveProbCreateInteval;

	private float circleWaveDmgScale;

	private float circleWaveInheritCritRateScale;

	private float circleWaveExtraCritDmgScale;

	private float circleWaveInheritCritValueScale;

	private int circleWaveCreateProb;

	private SequencePool seqPool;

	public const string SkillPrev = "skill_prev";

	public const string SkillEnd = "skill_end";

	private const float OffsetTime = 0.1f;

	private const float EffectPlayTime = 0.7f;

	private float lastCastTime;

	private int canCastCount;

	private int haveCastCount;

	private bool isStartDisappear;

	protected EntityBase PlayerEntity => null;

	private float SkillPrevPlayDiffSpeed => 0f;

	private float SkillEndPlayDiffSpeed => 0f;

	private float SkillPrevPlayTime => 0f;

	private float SkillEndPlayTime => 0f;

	private float SkillAllPlayTime => 0f;

	private float TweenAllWaitTime => 0f;

	private bool AllowCastSkill => false;

	private bool CanCastSkill => false;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void RefreshPetEntityAttribute()
	{
	}

	private void AddExtraAnims()
	{
	}

	private void RemoveExtraAnims()
	{
	}

	private void OnPetAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetStartDisappear(LocalSave.PetOne petOne)
	{
	}

	private void CastSkill()
	{
	}

	protected virtual void CheckPetStatus()
	{
	}

	protected virtual void CastCircleHitWave()
	{
	}

	protected virtual BulletBase CreateBullet()
	{
		return null;
	}

	private void HitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void CheckCreateCircleHitWave()
	{
	}

	protected float GetEntityBaseDmg()
	{
		return 0f;
	}
}
