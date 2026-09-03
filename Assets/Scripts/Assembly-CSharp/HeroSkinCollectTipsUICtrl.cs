using UnityEngine;
using UnityEngine.UI;

public class HeroSkinCollectTipsUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private HeroSkinCollectTipsItem itemTemplate;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private ButtonCtrl btnClose;

	private LocalUnityObjctPool _pool;

	private int _crtTabIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void RefreshUI()
	{
	}

	private void LoadItem()
	{
	}

	private void RefreshLayout()
	{
	}

	public void OnTabClicked()
	{
	}

	public void OnBtnCloseClicked()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
