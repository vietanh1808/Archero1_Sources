using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePartnerInBattleUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private PartnerCardOne mCopyCard;

	private LocalUnityObjctPool heroCardPool;

	[SerializeField]
	private GameObject heroCardCache;

	[SerializeField]
	private ScrollRectBase mScrollRect;

	[SerializeField]
	private RectTransform mContent;

	[SerializeField]
	private ButtonCtrl BtnGiveUp;

	[SerializeField]
	private DxxText TextGiveUp;

	[SerializeField]
	private DxxText TextTile;

	[SerializeField]
	private DxxText TextContent;

	[SerializeField]
	private DxxText TextGainTitle;

	[SerializeField]
	private Image ImgGainType;

	[SerializeField]
	private DxxText TextGainAttr;

	private List<PlayerCharacter_Character> m_aryDatas;

	private int m_nGainId;

	protected override void OnInit()
	{
	}

	private void InitPartnerCard()
	{
	}

	private void OnClickGiveUpBtn()
	{
	}

	private void OnEscape()
	{
	}

	protected override void OnOpen()
	{
	}

	private void init_herolist()
	{
	}

	private void InitHeroCardInfo()
	{
	}

	private void OnClickScrollItem(PartnerCardOne card)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
