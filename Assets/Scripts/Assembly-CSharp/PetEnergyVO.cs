using System;

public class PetEnergyVO : PetVOBase
{
	public enum PetSaveEnergy
	{
		ReleaseDoNothing = 0,
		ReleaseSave = 1
	}

	public enum PetSkillStatus
	{
		None = 0,
		Ban = 1,
		Charge = 2,
		Ready = 3,
		Cast = 4
	}

	private const string LOG_TAG = "[PetEnergyVO]";

	public Action<float> OnEnergyChange;

	public Action<PetSkillStatus> OnPetSkillStatusChange;

	public float curEnergy;

	private float deltaMaxEnergy;

	private PetSkillStatus skillStatus;

	private FirstEnemyCheck firstEnemyCheck;

	private bool isSKill1900ReduceMaxEnergy;

	private float curRoomEnergy;

	private int maxRoomEnergyLimit;

	private int castSkillCount;

	private float CastSkillAddMaxEnergyScale => 0f;

	private float CastSkillAddMaxEnergyScaleLimit => 0f;

	public PetEnergyVO(BattlePetVO battlePetVO)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private bool canRecoverEnergyByCD()
	{
		return false;
	}

	private void recoverEnergy(float delta)
	{
	}

	private int getMaxRoomEnergyLimit()
	{
		return 0;
	}

	private void updateCurRoomEnergy(float delta)
	{
	}

	private void resetCurRoomEnergy()
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onTDWaveFinished()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public void UpdateEnergy(float delta)
	{
	}

	public void foreSetCurrentEnergyMax()
	{
	}

	public float GetCurEnergyCount()
	{
		return 0f;
	}

	public float GetMaxEnergy()
	{
		return 0f;
	}

	private float getAllPetEnergyChargeSpeedPercent()
	{
		return 0f;
	}

	private float getPetEnergyChargeSpeedPercent()
	{
		return 0f;
	}

	private void checkSkillStatus()
	{
	}

	private void saveEnergy()
	{
	}

	public void OnCreatePet()
	{
	}

	public void updateSkillStatus(PetSkillStatus skillStatus)
	{
	}

	public bool isFullEnergy()
	{
		return false;
	}

	public PetSkillStatus GetPetSkillStatus()
	{
		return PetSkillStatus.None;
	}

	public void UpdateMaxEnergy(float deltaMaxEnergy)
	{
	}

	public void Skill1900UpdateMaxEnergy(float deltaMaxEnergy)
	{
	}

	public void AddCastSkillCount(int count)
	{
	}

	private float CastSkillAddExtraMaxEnergyScale()
	{
		return 0f;
	}
}
