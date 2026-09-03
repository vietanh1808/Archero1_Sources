using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PetUpUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public Image Image_Type;

	public Image Image_Rarity;

	public Image Image_Flag;

	public PetStarShowItem starItem;

	public DxxText Text_HP;

	public DxxText Text_Attack;

	public HeroPropInfoCtrl HPItem;

	public HeroPropInfoCtrl ATKItem;

	public DxxText Text_Skill;

	public PetSkillIcon Ski_Main;

	public PetSkillIcon[] Ski_Bottom;

	public PetSkillIcon[] Ski_Right;

	public DxxText Tab_level;

	public DxxText Tab_Star;

	public GameObject Focus_Level;

	public GameObject Focus_Star;

	public DxxText Text_AttrTitle;

	public GameObject Panel_Material;

	public DxxText Text_MatTitle;

	public PropOneEquip[] propItems;

	public DxxText Text_MatTips;

	public GameObject Panel_Mat;

	public GameObject Panel_Buttons;

	public ButtonCtrl Button_Assist;

	public DxxText Text_Assist;

	public ButtonCtrl Button_Up;

	public DxxText Text_Up;

	public GameObject RedPointUp;

	public ButtonCtrl Button_Battle;

	public DxxText Text_Battle;

	public ButtonCtrl Button_Rest;

	public DxxText Text_Rest;

	public ButtonCtrl Button_Get;

	public DxxText Btn_Text_Get;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_Left;

	public ButtonCtrl Button_Right;

	public RawImage petImg;

	private HeroShow heroShow;

	private int petId;

	public ScrollRect scrollRect;

	public RectTransform RTF_Content;

	public GameObject cpAttrItem;

	private List<PetAttrData> dataList;

	public GameObject Panel_Fragment;

	public Image Icon_Fragment;

	public Slider Slider_Fragment;

	public DxxText Slider_Text;

	public DxxText Text_Fragment;

	public RedNodeCtrl unlockRed;

	private int haveMat;

	private int needMat;

	private long haveCoin;

	private int needCoin;

	private int haveMat2;

	private int needMat2;

	private int currentTab;

	private List<LocalSave.PetOne> showPetList;

	private LocalSave.PetOne curPetOne;

	private int currentIndex;

	private int showStyle;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void onButtonClose()
	{
	}

	private void Esc()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonAssist()
	{
	}

	public void Idle()
	{
	}

	private void onButtonUp()
	{
	}

	private void onButtonBattle()
	{
	}

	private void onButtonRest()
	{
	}

	private void onButtonGet()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showTab(int tab, bool isinit)
	{
	}

	private void initUI()
	{
	}

	private void freshUI()
	{
	}

	private void freshModel()
	{
	}

	private void freshBasicInfo()
	{
	}

	private void freshAttackHP()
	{
	}

	public void PlayUpgradeAni()
	{
	}

	private void freshSkill()
	{
	}

	private void freshArrow()
	{
	}

	private void initAttrList()
	{
	}

	private void freshAttrList()
	{
	}

	private void freshMaterial()
	{
	}

	private void freshBottomButton()
	{
	}

	private void onButtonLeft()
	{
	}

	private void onButtonRight()
	{
	}

	public void onButtonType()
	{
	}

	public void onButtonFlag()
	{
	}
}
