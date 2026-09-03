using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BattlePetVO
{
	[Flags]
	public enum PetStatus
	{
		None = 0,
		Working = 1,
		Exist = 2,
		Dying = 4
	}

	public class SkillVO
	{
		public int PetSkillLevel;

		public int PetSkillId;

		public int InGameSkillId;

		public bool IsBattleSkill;

		public SkillVO(int petSkillId, int inGameSkillId)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	private string UPDATE_NAME;

	public EntityBase m_Entity;

	public LocalSave.PetOne PetOne;

	public List<SkillVO> SkillVOs;

	private PetStatus petStatus;

	public Pet_PetBattleSkill battleSkillMeta;

	public int curReleaseTimes;

	private PetBirthVO petBirthVO;

	private PetTriggerVO petTriggerVO;

	private PetEnergyVO petEnergyVO;

	public EntityBase BulletEnemy;

	public bool isBulletThroughWall;

	public PetStatus CurPetStatus => PetStatus.None;

	public bool IsPetWorking => false;

	public bool IsPetExist => false;

	public bool IsPetDying => false;

	public PetBirthVO PetBirthVO => null;

	public PetTriggerVO PetTriggerVO => null;

	public PetEnergyVO PetEnergyVO => null;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void onPetStartAppear(LocalSave.PetOne one)
	{
	}

	private void onPetStartDisappear(LocalSave.PetOne one)
	{
	}

	private void onPetAppear(BattlePetVO battlePetVO)
	{
	}

	private void onPetDisappear(BattlePetVO battlePetVO)
	{
	}

	private void petAppearWillDo()
	{
	}

	private void petDisappearWillDo()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onKill(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private bool isMatched(LocalSave.PetOne one)
	{
		return false;
	}

	private void initVOs()
	{
	}

	private void preloadModels()
	{
	}

	private void deinitVOs()
	{
	}

	private void initCallbacks()
	{
	}

	private void removeCallbacks()
	{
	}

	private void initHeroSkills()
	{
	}

	private void removeHeroSkills()
	{
	}

	private void initReleaseTimes()
	{
	}

	private void initPetStatus()
	{
	}

	private void initBattleSkillMeta()
	{
	}

	public bool IsPetInStatus(PetStatus status)
	{
		return false;
	}

	public void AddPetStatus(PetStatus status)
	{
	}

	public void RemovePetStatus(PetStatus status)
	{
	}

	public void ResetPetStatus()
	{
	}

	public int GetBattleSkillId()
	{
		return 0;
	}

	private void increaseReleaseTimes()
	{
	}

	private void resetReleaseTimes()
	{
	}

	private void saveReleaseTimes()
	{
	}

	public void onCreatePet()
	{
	}

	public string GetPetInfo()
	{
		return null;
	}

	public void SetBulletEnemy(EntityBase _enemy)
	{
	}

	public void SetEndCenterPos(Vector3? endPos)
	{
	}

	public SkillVO GetSkillVO(int skillId)
	{
		return null;
	}
}
