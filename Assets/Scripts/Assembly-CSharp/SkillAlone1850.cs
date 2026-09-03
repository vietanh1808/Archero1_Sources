using Dxx.Util;

public class SkillAlone1850 : SkillAlonePetBase
{
	private float skillPrevScale;

	private float skillEndScale;

	private float skillPlayScaleInheritPlayerSpeed;

	private int shotbulletID;

	private int shotBulletCount;

	private float bulletInheritAttackValueScale;

	private float shotBulletInheritPlayerCritRateScale;

	private float shotBulletCritRateExtraScale;

	private float shotBulletInheritPlayerCritValueRateScale;

	protected int addBuff1ID;

	protected int addBuff2ID;

	private int tramplingCount;

	protected float triggerInterval;

	protected float trggerRadius;

	private int createThunderArmourProb;

	protected float thunderArmourTime;

	public const string SkillPrev = "skill_prev";

	public const string SkillEnd = "skill_end";

	public const int ThunderArmourBuffID = 3153;

	private SequencePool seqPool;

	private float SkillPrevPlayDiffSpeed => 0f;

	private float SkillEndPlayDiffSpeed => 0f;

	private float SkillAllSkillPrevScale => 0f;

	private float SkillAllSkillEndScale => 0f;

	private float SkillPrevPlayTime => 0f;

	private float SkillEndPlayTime => 0f;

	private float SkillInheritPlayerAttackSpeedScale => 0f;

	private float AniAllTime => 0f;

	protected EntityBase PlayerEntity => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void RefreshPetEntityAttribute()
	{
	}

	private void OnPetAppear(BattlePetVO battlePetVo)
	{
	}

	private void OnPetDisAppear(BattlePetVO battlePetVo)
	{
	}

	private void AddExtraAnims()
	{
	}

	private void RemoveExtraAnims()
	{
	}

	private void CastSkill()
	{
	}

	protected virtual void SendBullet()
	{
	}

	private void CreateBullet()
	{
	}

	protected virtual BulletBase CreateBullet(float angle)
	{
		return null;
	}

	private void CheckCreateThunderArmour()
	{
	}

	protected virtual void CreateThunderArmour()
	{
	}

	private void SetRotate()
	{
	}

	protected float GetEntityBaseDmg()
	{
		return 0f;
	}

	private EntityBase GetTarget()
	{
		return null;
	}
}
