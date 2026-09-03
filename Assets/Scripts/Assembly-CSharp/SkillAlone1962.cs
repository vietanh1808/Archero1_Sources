using UnityEngine;

public class SkillAlone1962 : SkillAloneBase
{
	private float triggerHPPercent;

	private int critImprove;

	private int triggerSkillProb;

	private float skillDmgScale;

	private float skillRadius;

	private bool haveAddProperty;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnEnterGame()
	{
	}

	private void OnCreatePlayer()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void CheckProperty(float percent)
	{
	}

	private void AddProperty()
	{
	}

	private void RemoveProperty()
	{
	}

	private void HitEnemy(EntityBase attackedTarget, HitStruct arg2, HittedData arg3)
	{
	}

	private void CheckCastSkill(EntityBase attackedTarget)
	{
	}

	private void CastSkill(EntityBase entity, Vector3 targetPos)
	{
	}

	private void SendCasSkillMsg(Vector3 targetPos)
	{
	}

	private void SyncCastSkillMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
