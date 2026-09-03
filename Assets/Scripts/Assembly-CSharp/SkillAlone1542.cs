using System.Collections.Generic;

public class SkillAlone1542 : SkillAlone1344
{
	private Dictionary<int, int> m_dicMappingFarDueSwords;

	private int m_nMax;

	private int m_nCnt;

	protected override void OnInstall()
	{
	}

	protected override bool ContainsMappingFarDueSword(int nCurWeaponId)
	{
		return false;
	}

	protected override int GetMappingFarDueSword(int nCurWeaponId)
	{
		return 0;
	}

	protected override void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}
}
