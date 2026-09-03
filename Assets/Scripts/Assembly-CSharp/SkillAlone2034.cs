using System.Collections.Generic;
using Dxx.Util;

public class SkillAlone2034 : SkillAlonePetBase
{
	private float skillPrevScale;

	private float skillEndScale;

	protected float skillRadius;

	private float skillLastTime;

	protected int attackEnemyBuffID;

	private float dmgScale;

	protected float MoistBuffAddDmgPercent;

	protected const int MoistBuffID = 3155;

	private SequencePool seqPool;

	private const string SkillPrevAni = "skill_prev";

	private const string SkillLastAni = "skill_last";

	private const string SkillEndAni = "skill_end";

	private SkillAlone2034GoodCtrl createSkill;

	private List<EntityBase> _listAddedBuffEnemies;

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

	protected virtual void SkillStart()
	{
	}

	protected virtual void SkillEnd()
	{
	}

	protected virtual void RecycleSkillEffect()
	{
	}

	protected virtual void SkillTriggerEntity(EntityBase triggerEntity)
	{
	}

	protected float GetEntityBaseDmg()
	{
		return 0f;
	}

	private void PlayerSkillTriggerEntityExit(EntityBase triggerEntity)
	{
	}

	private void OnEnemyWillDead(EntityBase entity)
	{
	}
}
