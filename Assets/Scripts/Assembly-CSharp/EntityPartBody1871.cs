using System;
using UnityEngine;

public class EntityPartBody1871 : EntityPartBodyBase
{
	private int _heroCharId;

	private int _heroSkinId;

	private float _duration;

	private float _maxDuration;

	private float _elapsedTime;

	private int _attackRange;

	private Vector3 _lockedPosition;

	private bool _isDying;

	public Action OnAssistHeroDied;

	public EntityTD2023_1859 BaseTower { get; private set; }

	public override string modelid => null;

	public float RemainingDuration => 0f;

	public float MaxDuration => 0f;

	public override bool IgnorePartBodyShader => false;

	public void Init(int partId, int heroCharId, int heroSkinId, float duration, EntityTD2023_1859 baseTower, int attackRange = 5)
	{
	}

	public void InitAttrs(int attackRange = 5)
	{
	}

	public void initSkills()
	{
	}

	public void LearnSkill(int skillId)
	{
	}

	protected override void InitMoveControl()
	{
	}

	protected override void OnCreateModel()
	{
	}

	protected override void StartInit()
	{
	}

	protected override void PartBodyUpdate(float delta)
	{
	}

	public void LockPosition(Vector3 pos)
	{
	}

	private void OnTimeExpired()
	{
	}

	public override void ChangeHPMust(EntityBase entity, long HP, HitStruct data = null)
	{
	}

	public override bool GetIsDead()
	{
		return false;
	}

	protected override bool IsInvincible()
	{
		return false;
	}

	protected override bool GetColliderEnabled()
	{
		return false;
	}

	protected override bool CanShowHP()
	{
		return false;
	}

	protected override bool CanPlayBirthCallEffect()
	{
		return false;
	}

	protected override bool CanPlayDisappearEffect()
	{
		return false;
	}

	protected override void OnGotoNextRooms(RoomGenerateBase.Room room)
	{
	}

	protected override void OnDeInit()
	{
	}
}
