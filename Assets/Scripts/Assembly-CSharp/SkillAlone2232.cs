public class SkillAlone2232 : SkillAlone2231
{
	private int firstEnterRoomExtraOilLampCount;

	private int perOilLampAddProperty;

	protected bool firstStartSkill;

	private int needAddExtraOilLampCount;

	private int haveAddPropertyCount;

	protected override int CastSkillAddOilLampCount => 0;

	protected override void OnInstall()
	{
	}

	protected override void SkillStart()
	{
	}

	protected override void OnArtifact302ShieldCountChange(int curCount, bool isFromClear)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
