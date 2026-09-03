using System.Collections.Generic;

public class PrivilegeData : RecycleData<PrivilegeConfigData>
{
	public PrivilegeConfig PermanentConfig => null;

	public PrivilegeConfig DiamondConfig => null;

	public List<PrivilegePowerConfig> PowerConfig => null;

	public override void Clear()
	{
	}
}
