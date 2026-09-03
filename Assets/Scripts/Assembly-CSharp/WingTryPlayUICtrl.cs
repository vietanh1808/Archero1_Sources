using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WingTryPlayUICtrl : MediatorCtrlBase
{
	public DxxText titleText;

	public DxxText tryText;

	public DxxText subTitleText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl btnTry;

	public WingUpModelShow wingUpModelShow;

	public HeroPropInfoCtrl hpCtrl;

	public HeroPropInfoCtrl atkCtrl;

	public TryPlayStarItem starItem;

	public TryPlayAttrItem attItem;

	public RectTransform starParent;

	public RectTransform attParent;

	public ScrollRect scroll;

	public DxxText txtName;

	private LocalSave.WingOne wing;

	private LocalUnityObjctPool _pool;

	private int _curStarLv;

	private List<TryPlayAttrItem> _attList;

	private int _selectIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ScrollAt()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshAttShow()
	{
	}

	private void OnSelectStar(int starLevel)
	{
	}

	public void RefreshStar()
	{
	}

	public void RefreshAtkAndHp()
	{
	}

	private void OnBtnTryPlayClick()
	{
	}

	public void OnCloseBtnClick()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}
}
