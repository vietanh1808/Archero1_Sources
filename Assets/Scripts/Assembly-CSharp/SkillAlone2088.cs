using System.Collections.Generic;
using DG.Tweening;

public class SkillAlone2088 : SkillAloneNewPlay126Base
{
	private float skillRadius;

	private int buffID;

	private float skillLastTime;

	private Dictionary<EntityBase, int> triggerAllEntity;

	private SkillAlone2088GoodCtrl playerCreateSkill;

	private Tween delayCall;

	private int NeedAddBuffID => 0;

	private float BodyScale => 0f;

	private float SkillRealRadius => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void CasSkill()
	{
	}

	private void StartSkill()
	{
	}

	private void SkillEnd()
	{
	}

	private void ClearSkill()
	{
	}

	private void PlayerSkillTriggerMonster(EntityBase triggerEntity)
	{
	}

	private void PlayerSkillTriggerMonsterExit(EntityBase triggerEntity)
	{
	}

	private void OnBodyScaleEvent(float scale)
	{
	}
}
