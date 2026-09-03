using UnityEngine;

public class ChooseMagicUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText m_textTitle;

	[SerializeField]
	private DxxText m_textContent;

	[SerializeField]
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private RectTransform m_rtContent;

	[SerializeField]
	private GameObject m_copyOne;

	private LocalUnityObjctPool m_pool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void createMagicItem(int skillId)
	{
	}

	protected override void OnClose()
	{
	}

	private void OnSelectOne(int id)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
