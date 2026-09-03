public class EventAngelOfLightUICtrl : EventAngelOfJudgmentUICtrl
{
	protected override WindowID WindowId => WindowID.WindowID_Invaild;

	public override void OnLanguageChange()
	{
	}

	protected override void InitExtraSkill()
	{
	}

	protected override string GetExtraSkillBg(int nSkillId, LocalSave.EquipOne one)
	{
		return null;
	}
}
