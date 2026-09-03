using System.Collections.Generic;

public class SkillAlone2130 : SkillAlone2129
{
	private string[] allElement;

	private Dictionary<EElementType, int> elementForBuffID;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseAllElement()
	{
	}

	protected override EElementType GetElementType()
	{
		return EElementType.eNone;
	}

	protected override List<int> GetBuffID()
	{
		return null;
	}

	private EElementType GetCurElement()
	{
		return EElementType.eNone;
	}
}
