using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class EventSpringFestivalDemonUICrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText texttitle;

	[SerializeField]
	private DxxText texttitle2;

	[SerializeField]
	private ButtonCtrl buttonok;

	[SerializeField]
	private DxxText textok;

	[SerializeField]
	private ButtonCtrl buttoncancel;

	[SerializeField]
	private DxxText textcancel;

	[SerializeField]
	private DxxText text_content1;

	[SerializeField]
	private DxxText text_content2;

	[SerializeField]
	private Image image_1;

	[SerializeField]
	private Image image_2;

	private int mGetid;

	private Skill_SpringFestival_119 m_SelectedBean;

	private int m_nChangeHp;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Log(string msg)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickOK()
	{
	}

	private void OnEscape()
	{
	}

	private void OnClickCanccel()
	{
	}
}
