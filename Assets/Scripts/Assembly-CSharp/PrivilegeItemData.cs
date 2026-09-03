public class PrivilegeItemData
{
	private PrivilegeItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public PrivilegePowerConfig Config => null;

	public PrivilegeType PrivilegeType => PrivilegeType.None;

	public PrivilegeValueType ValueType => PrivilegeValueType.Int;

	public float Value => 0f;

	public string DescValue => null;

	public string Desc => null;

	public static PrivilegeItemData Create(PrivilegeItemConfigData configData)
	{
		return null;
	}

	private float GetValue()
	{
		return 0f;
	}

	private PrivilegeValueType GetValueType()
	{
		return PrivilegeValueType.Int;
	}

	private string GetDescValue()
	{
		return null;
	}

	private bool IsValueShowFuncDesc()
	{
		return false;
	}

	private bool IsNeedAddSymbol()
	{
		return false;
	}

	private string GetDesc()
	{
		return null;
	}

	private string GetSymbol(bool isCheckNeedAddSymbol = false)
	{
		return null;
	}
}
