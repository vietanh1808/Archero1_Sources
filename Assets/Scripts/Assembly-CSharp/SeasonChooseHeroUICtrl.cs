using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class SeasonChooseHeroUICtrl : MediatorCtrlBase
{
	[SerializeField]
	protected DxxText m_textTitle;

	[SerializeField]
	private DxxText m_textTips;

	[SerializeField]
	private DxxText m_textContent;

	[SerializeField]
	private ButtonCtrl mOkBtn;

	[SerializeField]
	private ButtonCtrl mRefreshBtn;

	[SerializeField]
	private DxxText mRefreshBtnText;

	[SerializeField]
	protected DxxText mRefreshPriceText;

	[SerializeField]
	protected DxxText mOkBtnText;

	[SerializeField]
	private Transform m_selectedHeroContainer;

	[SerializeField]
	private RectTransform mScrollContent;

	[SerializeField]
	private RectTransform mLineCopyOne;

	[SerializeField]
	private SeasonHeroCardOne CopyOne;

	[SerializeField]
	private ScrollRect mProfessionAttrScroll;

	[SerializeField]
	private ProfessionAttrOneCtrl mProfessionAttrCopyOne;

	[SerializeField]
	protected GameObject mCardPlaceholder;

	[SerializeField]
	private GameObject mProfessionAttrTips;

	[SerializeField]
	private ButtonCtrl mBtn_Close;

	[SerializeField]
	private ButtonCtrl mBtn_Mask;

	private LocalUnityObjctPool mLinePool;

	private LocalUnityObjctPool mCardPool;

	private LocalUnityObjctPool mProfessionAttrPool;

	private LocalUnityObjctPool mProfessionAttrPool2;

	private SequencePool mSeqPool;

	private SeasonHeroCardOne mSelectedOne;

	private bool m_bAnimateEnd;

	private List<SeasonHeroLineCtrl> lines;

	private SeasonChooseHeroProxy.Transfer mTransfer;

	protected virtual WindowID WindowID => WindowID.WindowID_Invaild;

	protected virtual int SelectedHero => 0;

	protected virtual int[] HeroIds => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected virtual void UpdateUI()
	{
	}

	protected virtual void OnClick(SeasonHeroCardOne card)
	{
	}

	protected virtual void SaveSeasonSelecteHero(int id)
	{
	}

	protected virtual void SetSeasonSelecteHero(int id)
	{
	}

	private void UpdateProfessionAttrPanel(SeasonHeroCardOne one)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void OnClickProfessionBtn(SeasonHeroCardOne one, Vector3 pos)
	{
	}
}
