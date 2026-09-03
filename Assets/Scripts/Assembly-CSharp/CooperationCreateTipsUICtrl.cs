using UnityEngine;

public class CooperationCreateTipsUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl btnLeft;

	[SerializeField]
	private ButtonCtrl btnRight;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxImage imgGuideIcon;

	[SerializeField]
	private CooperationCreateTipsTabItem[] allTabs;

	private int _curIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshTabItems()
	{
	}

	private void RefreshGuideInfo()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void OnBtnTabClick(int index)
	{
	}

	public void OnBtnCloseClick()
	{
	}
}
