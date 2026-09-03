using UnityEngine;

public class ChooseHeroSkillUICtrl : MediatorCtrlBase
{
	public Transform m_HeroContainer;

	public ButtonCtrl m_btnAccept;

	public DxxText m_textAccept;

	public ButtonCtrl m_btnClose;

	public GameObject m_mask;

	public SkillButtonCtrl m_skill;

	public DxxText m_textTitle;

	public DxxText m_textContent;

	public DxxText m_textSkillName;

	private ChooseHeroSkillProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnClickAcceptBtn()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void UpdateUI()
	{
	}
}
