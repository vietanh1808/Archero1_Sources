using GameProtocol;

public class TotemAtt
{
	public string AttName;

	public double Value;

	public int AttConfigID;

	public bool IsChanged;

	public int Rare => 0;

	public bool IsSkill => false;

	public string SkillName => null;

	public static TotemAtt Create(STTotemAttr attr)
	{
		return null;
	}

	public static TotemAtt Create(string attName, double value, int configID)
	{
		return null;
	}

	public void SyncChangedStatus(bool isChanged)
	{
	}
}
