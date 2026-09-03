public class SkillAlone2266 : SkillAloneBase
{
	public class Skill2266_TriggerRay : CustomJsonActionVO
	{
		public int IsTriggerRay;
	}

	private int gloryBuffId;

	private int gloryBuffNum;

	private int curBuffCount;

	private int curRecordWeaponID;

	private bool isAlreadyHaveRay;

	private const string SyncSkill2266_TriggerRay = "SyncSkill2266_TriggerRay";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private int GetWeaponID()
	{
		return 0;
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void SyncTriggerRay(int triggerRay)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
