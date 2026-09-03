public class WeaponCrossbowBase : WeaponBase
{
	protected virtual int MappingWeaponId => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected virtual void OnChargeGridEvent(long cnt)
	{
	}
}
