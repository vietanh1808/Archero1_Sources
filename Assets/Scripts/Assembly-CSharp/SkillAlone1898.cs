using DG.Tweening;
using Dxx.Util;

public class SkillAlone1898 : SkillAlonePetBase
{
	private float skillPrevScale;

	private float skillEndScale;

	private float shieldSizeScale;

	private float rotateSpeed;

	private float shieldLastTime;

	private int shieldResistBulletCount;

	private const string SkillPrev = "skill_prev";

	private const string SkillEnd = "skill_end";

	private const string Idle = "idle";

	private Tween delayCall;

	private SkillAlone1898GoodCtrl shield;

	private int shieldHaveResistBulletCount;

	private bool allowRotate;

	private SequencePool seqPool;

	private float AllShieldLastTime => 0f;

	protected EntityBase PlayerEntity => null;

	private float SkillPrevPlayDiffSpeed => 0f;

	private float SkillEndPlayDiffSpeed => 0f;

	private float SkillPrevPlayTime => 0f;

	private float SkillEndPlayTime => 0f;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
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

	private void OnPetStartDisAppear(LocalSave.PetOne petOne)
	{
	}

	private void CastSkill()
	{
	}

	private void CreateShield()
	{
	}

	private void LoadShield()
	{
	}

	protected virtual void OnShieldResistBullet()
	{
	}

	private void RecycleShield(bool isImmediately)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void SetRotateDelta()
	{
	}

	private void SetRotateImmediately()
	{
	}

	private EntityBase GetTarget()
	{
		return null;
	}
}
