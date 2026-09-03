using System;
using GameProtocol;

[Serializable]
public class CampTalent : LocalSave.ICloneable<CampTalent>
{
	public int id;

	public int level;

	public static CampTalent Create(CCampTalent talent)
	{
		return null;
	}

	public void Clone(CampTalent source)
	{
	}

	public static CampTalent Create(CShipBattleTalent talent)
	{
		return null;
	}
}
