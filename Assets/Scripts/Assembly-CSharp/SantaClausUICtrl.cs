using UnityEngine;

public class SantaClausUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText m_textTitle;

	[SerializeField]
	private DxxText m_textContent;

	[SerializeField]
	private DxxText m_textContent_1;

	[SerializeField]
	private DxxText m_textContent_2;

	[SerializeField]
	private ButtonCtrl m_btnAccept;

	[SerializeField]
	private DxxText m_textBtnText;

	[SerializeField]
	private Transform m_modelContainer;

	[SerializeField]
	private Transform m_rewardContainer;

	[SerializeField]
	private GameObject m_elkCopyItem;

	private GameObject rewardcopyitem;

	private LocalUnityObjctPool mPool;

	private GameObject model;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void InitItem()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
