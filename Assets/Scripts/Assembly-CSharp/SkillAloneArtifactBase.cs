using UnityEngine;

public abstract class SkillAloneArtifactBase : SkillAloneBase
{
	protected bool allowCondAccumulateCondNum;

	protected ArtifactItemData artifactItemData;

	protected ArtifactSkillCondType condType;

	protected float originCondNum;

	private bool needAutoShowNextRoom;

	protected Vector3 castSkillArtifactPos;

	protected bool isSelfCast;

	private float _condAccumulateTime;

	private float _condAccumulateHitEnemyCount;

	protected bool isStartSkill;

	protected ArtifactType ArtifactType => ArtifactType.None;

	protected virtual float RealCondNum => 0f;

	protected virtual bool AllowSyncSkill => false;

	protected virtual float ModelLegalPositionOffset => 0f;

	protected float CondAccumulateTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected float CondAccumulateHitEnemyCount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void SetEntityArtifactActive(bool isShow, bool needUpdateRotate = false)
	{
	}

	protected ArtifactShowItem ChangeArtifactItemModel(string modelID)
	{
		return null;
	}

	protected void InitCallBack()
	{
	}

	protected void DeInitCallBack()
	{
	}

	protected void InitCond()
	{
	}

	protected void ResetCondAccumulateNum(float timeOffset = 0f)
	{
	}

	protected void ParseCond()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	protected virtual void OnHitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected virtual void CheckCastSKill()
	{
	}

	protected virtual void StartCastSkill()
	{
	}

	protected abstract void CastSkill();

	protected virtual void SkillStart()
	{
	}

	protected virtual void SkillEnd()
	{
	}

	protected virtual void SkillClear()
	{
	}

	private void OnSkillPropertyChange()
	{
	}

	protected float GetRealCondNum(float origin)
	{
		return 0f;
	}

	protected float GetArtifactSkillDmg()
	{
		return 0f;
	}

	protected float GetArtifactSkillCrit()
	{
		return 0f;
	}

	protected float GetArtifactSkillSuperCrit()
	{
		return 0f;
	}

	protected float GetArtifactSkillCritValue()
	{
		return 0f;
	}

	protected void SendCastSkillMsg()
	{
	}

	protected void SendCastSkillMsg(Vector3 skillCastArtifactPos)
	{
	}

	private void CastSkillMsg(bool isSelfCast, Vector3 skillCastArtifactPos)
	{
	}

	private void SyncCastSkillMsg(Vector3 castSkillArtifactPos)
	{
	}

	protected void SendEndSkillMsg()
	{
	}

	private void SyncEndSkillMsg()
	{
	}

	protected virtual void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
