using UnityEngine;

public class AltarHeroUpSecondTipsUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTips;

	[SerializeField]
	private DxxText txtBtnOk;

	[SerializeField]
	private DxxText txtBtnCancel;

	[SerializeField]
	private ButtonCtrl btnOk;

	[SerializeField]
	private ButtonCtrl btnCancel;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private AltarHeroUpSecondTipsItem itemTemplate;

	[SerializeField]
	private RectTransform itemParent;

	private int _fragmentId;

	private LocalUnityObjctPool _pool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshTipsItem()
	{
	}

	public void OnBtnCloseClick()
	{
	}
}
