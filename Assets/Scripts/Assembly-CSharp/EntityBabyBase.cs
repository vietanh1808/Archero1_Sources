using System;
using System.Collections.Generic;
using System.Reflection;
using TableTool;

public class EntityBabyBase : EntityCallBase
{
	protected ActionBasic action;

	private List<int> mLearnSkillList;

	protected int WeightAll;

	protected List<Skill_slotin_pet> m_SkillList;

	protected HashSet<int> removeSet;

	private MethodInfo _method;

	private string m_strUniqueID;

	public Action<EntityBase, int> OnBabyAddNewSkillEvent;

	public float ResistRateForParent { get; set; }

	public override EntityBase m_HatredTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool CanUseMeleeBabyAsShield { get; set; }

	protected sealed override string ModelPath => null;

	public Character_Baby m_BabyData { get; private set; }

	private MethodInfo method => null;

	public LocalSave.EquipOne EquipOne { get; private set; }

	public string BabyUniqueEquipId => null;

	public bool CanResistForParent()
	{
		return false;
	}

	protected override void OnInit()
	{
	}

	protected override void InitAnimations()
	{
	}

	protected override void StartInit()
	{
	}

	protected virtual void InitAttackControl()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	public override bool SetHitted(HittedData data)
	{
		return false;
	}

	protected override void UpdateProcess(float delta)
	{
	}

	public void UpdateAttributes()
	{
	}

	private void RemoveAlreadyAddAttributes()
	{
	}

	public void UpdateSkillIds()
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void resetBabyPos()
	{
	}

	public override float GetBodyScale()
	{
		return 0f;
	}

	public void ChangeAIAttackID(int _attackID)
	{
	}

	public bool IsMeleeBaby()
	{
		return false;
	}

	public bool IsFlyBaby()
	{
		return false;
	}

	protected virtual void InitSkillList()
	{
	}

	public virtual List<int> GetSkill(int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight(int skillid)
	{
	}

	public void SetBabyEquipUniqueID(string strUniqueID, LocalSave.EquipOne equipOne)
	{
	}

	private void OnLevelUpEvent(int lv)
	{
	}

	public void LearnSkill(int id)
	{
	}

	private void LearnSkillInternal(int id)
	{
	}

	public void BattleIn_RestoreSkill()
	{
	}
}
