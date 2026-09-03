using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonChooseHeroUIPanel : MediatorCtrlBase
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
	protected DxxText mOkBtnText;

	[SerializeField]
	private ButtonCtrl mBtn_Close;

	[SerializeField]
	private ButtonCtrl mBtn_Mask;

	public ButtonCtrl Button_Info;

	public DxxText[] Text_Hero;

	public Image[] Image_Hero;

	public GameObject btnBlueObj;

	public GameObject btnGreenObj;

	public RectTransform Content;

	public GameObject cpItem;

	private int[] choosed;

	private List<SeasonChooseHeroItem> cardItemList;

	private int _cachedUnlockCount;

	protected WindowID WindowID => WindowID.WindowID_Invaild;

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

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onButtonInfo()
	{
	}

	private void freshHeroItems()
	{
	}

	private void RefreshHeroSlot(int index, int heroId)
	{
	}

	private void putHeroTop(int mid)
	{
	}

	public void onButtonTop(int index)
	{
	}

	private int GetUnlockCount()
	{
		return 0;
	}

	private int GetSelectdState()
	{
		return 0;
	}

	private void freshButtonState()
	{
	}

	private void onButtonOK()
	{
	}
}
