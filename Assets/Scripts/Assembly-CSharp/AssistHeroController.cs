using System;
using System.Collections.Generic;
using UnityEngine;

public class AssistHeroController
{
	public enum State
	{
		Ready = 0,
		Active = 1,
		Cooldown = 2,
		Disabled = 3
	}

	private const string LOG_TAG = "[AssistHero]";

	private const int PART_ID = 1871;

	private const int TOWER_ID = 1859;

	private State _state;

	private float _cooldownTimer;

	private float _cooldownDuration;

	private float _summonDuration;

	private int _attackRange;

	private int _assistHeroCharId;

	private int _assistHeroSkinId;

	private List<int> _learnedSkillIds;

	private EntityTD2023_1859 _towerEntity;

	private EntityPartBody1871 _assistBody;

	public Action<State> OnStateChanged;

	public int assistCount;

	public State CurrentState => State.Ready;

	public float CooldownRemaining => 0f;

	public float CooldownDuration => 0f;

	public EntityPartBody1871 AssistBody => null;

	public void Init(int heroCharId, int skinId)
	{
	}

	public bool TrySummon(Vector2Int gridPos)
	{
		return false;
	}

	private void CreateAssistBody(Vector3 worldPos)
	{
	}

	private void SetupTauntTrigger()
	{
	}

	private void OnAssistHeroDied()
	{
	}

	private void RemoveAssistHero()
	{
	}

	private void EnterCooldown()
	{
	}

	public void Update(float delta)
	{
	}

	public void OnMainHeroLearnSkill(int skillId)
	{
	}

	private bool IsSkillInTDPool(int skillId)
	{
		return false;
	}

	public void OnBattleRestore()
	{
	}

	public void Destroy()
	{
	}

	private void ClearMonstersTargetingAssist(EntityBase assistEntity)
	{
	}
}
