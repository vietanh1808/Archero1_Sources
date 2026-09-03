using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNpcInBattleUICtrl : MediatorCtrlBase
{
	public NpcCardOneInBattleCtrl mCopyCard;

	private LocalUnityObjctPool heroCardPool;

	public GameObject heroCardCache;

	public ScrollRectBase mScrollRect;

	public RectTransform mContent;

	public SelectedNpcCardOneCtrl[] SelectedCards;

	public ButtonCtrl BtnBattle;

	public Image BattleBtnImg;

	public DxxText TextBattle;

	public ButtonCtrl BtnDesc;

	public DxxText TextDesc;

	public DxxText TextTile;

	public DxxText TextAttrs;

	public DxxText TextTips_2;

	private ChooseNpcInBattleProxy.Transfer mTransfer;

	private List<NpcCardOneInBattleCtrl> heroCardList;

	private List<PlayerCharacter_Character> m_aryDatas;

	private int count;

	protected override void OnInit()
	{
	}

	private List<int> GetSelectedIds()
	{
		return null;
	}

	private void GoToBattle(List<int> ids)
	{
	}

	private void SetGray()
	{
	}

	private void InitNpcCard()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnEscape()
	{
	}

	protected override void OnClose()
	{
	}

	private void init_herolist()
	{
	}

	private void InitHeroCardInfo()
	{
	}

	private void OnClickSelectedCard(int index)
	{
	}

	private int OnClickScrollItem(NpcCardOneInBattleCtrl card)
	{
		return 0;
	}

	private void CalculateAffinityAttributesCnt()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
