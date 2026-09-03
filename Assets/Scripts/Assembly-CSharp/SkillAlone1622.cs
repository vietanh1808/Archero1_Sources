using UnityEngine;

public class SkillAlone1622 : SkillAloneBase
{
	public class SkillEffect1622_SyncShieldVO : CustomJsonActionVO
	{
		public long shield;
	}

	private int buffId;

	private float waterShieldRate;

	private float waterShieldRateMax;

	private int shieldFxId;

	private float shieldDurationTime;

	private float preBuffEffectTime;

	private GameObject shieldFx;

	private long shieldAdd;

	private const string SkillEffect1622_SyncShield = "SkillEffect1622_SyncShield";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnFrozen(bool isFrost, BuffAloneBase buff)
	{
	}

	private void DispatchEff()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void AddShieldFx()
	{
	}

	private void RemoveShieldFx()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncSkillEffectMsg2(long shield)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
