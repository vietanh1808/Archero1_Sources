using UnityEngine;

public class SkillAlone2191 : SkillAlone2194
{
	private int CONFIG_BUFF_ID;

	private bool _isSkill2230Trigger;

	protected override EntityBase Target => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnHit(EntityBase entityBase, HitStruct hs, HittedData hd)
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void OnFirstDeadRecover()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	protected override void SyncFlySword(Vector3 startPos, float angle, int uid)
	{
	}

	private void OnSkill2230Event(bool status)
	{
	}
}
