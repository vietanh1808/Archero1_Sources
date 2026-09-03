using Dxx.Util;
using UnityEngine;

public class SkillAlone1931 : SkillAlonePetBase
{
	private float skillPrevScale;

	private float skillEndScale;

	private int sendBulletCount;

	private int mainBulletID;

	private float mainBulletRadius;

	private int mainBulletBuff;

	private int bulletSplitCount;

	private float bulletSplitRadius;

	private float bulletSplitMoveDis;

	protected int childBulletID;

	private float childBulletRadius;

	private float mainBulletDmgScale;

	protected float childBulletDmgScale;

	private float bulletInheritCritRateScale;

	private float bulletExtraCritDmgScale;

	private float bulletInheritCritValueScale;

	private int bulletSplitProb;

	private SequencePool seqPool;

	private Vector3 targetPos;

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

	private void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	protected virtual void CastSkill()
	{
	}

	protected virtual void SendMainBullet()
	{
	}

	protected virtual BulletBase CreateMainBullet()
	{
		return null;
	}

	protected virtual void OnMainBulletAttack(BulletBase bullet)
	{
	}

	protected virtual void SendChildBullet(Vector3 startPos)
	{
	}

	protected virtual BulletBase CreateChildBullet(Vector3 startPos, float angle)
	{
		return null;
	}

	protected virtual void SetBulletData(BulletBase bulletBase, float bulletDmgScale)
	{
	}

	protected virtual long GetBulletDmg(float bulletDmgScale)
	{
		return 0L;
	}

	protected virtual float GetEntityBaseDmg()
	{
		return 0f;
	}

	protected virtual void HitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void RefreshPetEntityAttribute()
	{
	}

	private void SetRotate()
	{
	}

	private EntityBase GetTarget()
	{
		return null;
	}
}
