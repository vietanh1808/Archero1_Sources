using UnityEngine;

public class EquipRefineInfoUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private UILineCtrl mTitleCtrl;

	[SerializeField]
	private DxxText m_textQuality;

	[SerializeField]
	private Transform m_tIconParent;

	[SerializeField]
	private DxxText m_textInfo;

	[SerializeField]
	private DxxText m_textAttrTitle;

	[SerializeField]
	private DxxText m_textAttrCopyOne;

	[SerializeField]
	private RectTransform m_rtAttrParent;

	[SerializeField]
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private GameObject m_attparent;

	private EquipInfoModuleProxy.Transfer mTransfer;

	private LocalSave.EquipOne mEquipData;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool mEquipOnePool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private string GetAttributeBase(int index)
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
