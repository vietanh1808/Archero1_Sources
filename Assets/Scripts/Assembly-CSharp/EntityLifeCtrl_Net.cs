public class EntityLifeCtrl_Net : EntityLifeCtrl
{
	private bool foundHpCheat;

	protected override void OnEntityHittedOnce(HitStruct data)
	{
	}

	public override void OnCheckDataOver(HitStruct data)
	{
	}

	protected override void StartChangeHP(HitStruct data)
	{
	}

	protected override void OnHPChanged(HitStruct data)
	{
	}

	private void PushCommand(EntityBase source, long hp)
	{
	}

	public override void ExecCommand(BaseCommand cmd)
	{
	}

	private void onAntiCheatHp(long beforeCurHp, ChangeHpCommand chCmd)
	{
	}

	private void onAntiCheatHpChange(long hpChange)
	{
	}

	private void onAntiCheatHit(long realHit)
	{
	}
}
