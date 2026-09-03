using UnityEngine;

public class SkillAlone2275 : SkillAloneBase
{
	public class SkillEffect2275_SyncCreatStatueVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float statueCDTime;

	private float spawnRadius;

	private float statueRadius;

	private int statueBuffId;

	private float statueDuration;

	private float callPartRate;

	private float secondPartDuration;

	private float preGenerateTime;

	private const string StatueEffPath = "Game/Aura/AuraTridentStatue";

	private const string StatueRedEffPath = "Game/Aura/AuraTridentStatue_Red";

	private const string StatueEffEndPath = "Effect/Battle/eff_tridentshenxiang01end";

	private const string StatueRedEffEndPath = "Effect/Battle/eff_tridentshenxiang01end_red";

	private const string SyncSkill2275_SyncCreatStatue = "SyncSkill2275_SyncCreatStatue";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CreatStatue()
	{
	}

	private void CreatStatueByPos(Vector3 pos, bool isSync)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncCreatStatue(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
