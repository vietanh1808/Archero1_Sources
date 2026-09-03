using UnityEngine;

public class SkillAlone2167 : SkillAlone2166
{
	private int CONFIG_BLACK_DEBUFF_ID;

	private float CONFIG_BLACK_DEBUFF_RADIUS;

	private float CONFIG_BLACK_DEBUFF_INTERVAL;

	private float CONFIG_RECOVER_ENERGY_RATE;

	private int CONFIG_RECOVER_ENERGY_VALUE;

	private float m_fTime;

	private GameObject _effect;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnCreateDemon()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnKill(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}
}
