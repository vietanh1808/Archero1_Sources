public class WeaponFlashBase : WeaponBase
{
	protected virtual int ConfigId => 0;

	protected virtual int ConfigIndex => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected override void CalChargeRatio()
	{
	}

	protected void updateAtkModify(float factor)
	{
	}
}
