public class EntityTD2023_1830 : EntityTD2023Base
{
	private bool triggerHP_PetAtk;

	private float HP_PetAttack_Percent;

	protected override void OnDeInitLogic()
	{
	}

	protected override void OnEntityDead()
	{
	}

	private void wait2DeadAnimFinished()
	{
	}

	protected override void OnInit()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	protected override int GetDefaultHPSliderId()
	{
		return 0;
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
}
