using System.Collections.Generic;
using Dxx.Util;

public class SkillAlone2240 : SkillAlonePetBase
{
	private float skill1PrevScale;

	private float skill1EndScale;

	private float skill2PrevScale;

	private float skill2EndScale;

	private float baseDmgScale;

	private float triggerHP;

	private float attackSkillLastTime;

	private float attackSkillInterval;

	private float attackSkillTriggerRadius;

	private float attackSkillBulletCallRadius;

	private float attackSkillBulletInnerRadius;

	private float attackSkillBulletInnerHitRatio;

	private float attackSkillBulletOutRadius;

	private float attackSkillBulletOutHitRatio;

	private int attackSkillPerEnemeyCreateMaxCount;

	private float defenceSkillLastTime;

	private float defenceSkillRadius;

	private int defenceSkillRadiusAddSelfBuffID;

	private float attackSkillDmgScale;

	private float defenceSkillBeHitReduce;

	private float defenceSkillAttackDmgIncrease;

	private const int AttackSkillBulletID = 5381;

	private const int DefenceSkillEffectID = 2240;

	private SkillAlone2240GoodCtrl createDefenceSkill;

	private SequencePool sequencePool;

	private Dictionary<int, int> hitEnemyNum;

	protected Dictionary<EntityBase, int> triggerAllEntity;

	protected EntityBase PlayerEntity => null;

	private float Skill1PrevPlayDiffSpeed => 0f;

	private float Skill1EndPlayDiffSpeed => 0f;

	private float Skill1PrevPlayTime => 0f;

	private float Skill1EndPlayTime => 0f;

	private float Skill2PrevPlayDiffSpeed => 0f;

	private float Skill2EndPlayDiffSpeed => 0f;

	private float Skill2PrevPlayTime => 0f;

	private float Skill2EndPlayTime => 0f;

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

	protected virtual void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	protected virtual void OnPetStartDisappear(LocalSave.PetOne petOne)
	{
	}

	private void CastSkill()
	{
	}

	protected virtual void SkillEnd()
	{
	}

	protected float GetEntityBaseDmg()
	{
		return 0f;
	}

	private void SKillClear()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void CreateAttackSkill()
	{
	}

	private void CreateAttackPerSkill()
	{
	}

	protected List<EntityBase> GetAllCanAttackEntity(float radius)
	{
		return null;
	}

	protected virtual float GetAttackSkillDmgScale()
	{
		return 0f;
	}

	private void ClearAttackSkill()
	{
	}

	private void CreateDefenceSkill()
	{
	}

	protected virtual void SkillTriggerEntityEnter(EntityBase triggerEntity)
	{
	}

	protected virtual void SkillTriggerEntityExit(EntityBase triggerEntity)
	{
	}

	private void ClearDefenceSkill()
	{
	}
}
