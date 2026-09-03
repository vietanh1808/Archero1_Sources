using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinCollectTipsUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private WeaponSkinCollectTipsItem itemTemplate;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTab1;

	[SerializeField]
	private DxxText txtTab2;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private GameObject goTab1Select;

	[SerializeField]
	private GameObject goTab2Select;

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

	private void LoadItem(int index)
	{
	}

	private void RefreshLayout()
	{
	}

	public void OnTabClicked(int index)
	{
	}

	public void OnBtnCloseClicked()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
