using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using homepage;

public class EquipStoragePagePanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txt_title;

	[SerializeField]
	private EquipStorageCharUICtrl CharUICtrl;

	[SerializeField]
	private ButtonCtrl btn_close;

	[SerializeField]
	private ButtonCtrl btn_Click;

	[SerializeField]
	private DxxText text_ClickButton;

	[SerializeField]
	private DxxText text_Save;

	[SerializeField]
	private DxxText text_Wear;

	[SerializeField]
	private GameObject go_tab1Unselect;

	[SerializeField]
	private GameObject go_tab1Select;

	[SerializeField]
	private GameObject go_tab2Unselect;

	[SerializeField]
	private GameObject go_tab2Select;

	[SerializeField]
	private ButtonCtrl[] btn_Pages;

	[SerializeField]
	private GameObject go_Page3Lock;

	[SerializeField]
	private GameObject go_Page3Unlock;

	[SerializeField]
	private DxxText[] text_Page;

	[SerializeField]
	private DxxImage[] Image_Page;

	[SerializeField]
	private DxxText text_BtnClickDesc;

	[SerializeField]
	private RectTransform rect_TipsParent;

	[SerializeField]
	private EquipStorageTipsItemCtrl tipsItem;

	[SerializeField]
	private GameObject go_Tips;

	[SerializeField]
	private Image image_Click;

	[SerializeField]
	private DxxImage[] imprints;

	[SerializeField]
	private DxxImage wingIcon;

	[SerializeField]
	private DxxImage wingSkillIcon1;

	[SerializeField]
	private DxxImage wingSkillIcon2;

	[SerializeField]
	private DxxImage wingBg;

	[SerializeField]
	private DxxImage wingRareIcon;

	[SerializeField]
	private DxxImage skill1Bg;

	[SerializeField]
	private DxxImage skill2Bg;

	[SerializeField]
	private EquipStorageShowItemOne[] dragons;

	[SerializeField]
	private EquipStorageShowItemOne[] totems;

	[SerializeField]
	private EquipStorageTotemTipsItem totemTips;

	private StorageHeroVO heroVO;

	[SerializeField]
	private HeroAssistLine heroLine;

	private StorageTab crtTab;

	private WaitForSeconds wait;

	private LocalUnityObjctPool pool;

	private int crtPage => 0;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnSetArgs(object o)
	{
	}

	protected override void OnOpen()
	{
	}

	public void CheckData()
	{
	}

	public void RefreshUI()
	{
	}

	public void Check()
	{
	}

	private string CheckWear()
	{
		return null;
	}

	private string CheckSave()
	{
		return null;
	}

	public void RefreshPageStatus()
	{
	}

	public void RefreshTabStatus()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void OnTabBtnClick(int index)
	{
	}

	public void OnBtnConfirmClick()
	{
	}

	private void RefreshImprint()
	{
	}

	private void RefreshWingAssist()
	{
	}

	private void RefreshDragons()
	{
	}

	private void RefreshTotems()
	{
	}

	private void OnTotemBtnClick(ulong rowID, Vector2 pos)
	{
	}
}
