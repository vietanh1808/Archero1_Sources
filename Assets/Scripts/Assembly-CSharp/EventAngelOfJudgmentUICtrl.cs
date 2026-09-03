using UnityEngine;
using UnityEngine.UI;

public class EventAngelOfJudgmentUICtrl : EventAngelUICtrl
{
	[SerializeField]
	private Image m_imgBgAngelOfJudgment;

	[SerializeField]
	private Image m_imgAngelOfJudgment;

	[SerializeField]
	private Text m_textAngelOfJudgment;

	[SerializeField]
	private ButtonCtrl buttonok3;

	private int m_nSkillId;

	protected override WindowID WindowId => WindowID.WindowID_Invaild;

	protected override void OnInit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void InitSkill()
	{
	}

	protected virtual void InitExtraSkill()
	{
	}

	protected virtual string GetExtraSkillBg(int nSkillId, LocalSave.EquipOne one)
	{
		return null;
	}

	protected void UpdateExtraSkillUI(int nSkillId, LocalSave.EquipOne one = null)
	{
	}

	private void OnClickOK3()
	{
	}
}
