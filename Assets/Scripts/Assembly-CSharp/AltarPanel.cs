using System.Collections.Generic;
using UnityEngine;

public class AltarPanel : MonoBehaviour
{
	public enum AltarTabType
	{
		Equip = 0,
		Hero = 1,
		Relics = 2
	}

	public DxxText Text_Title;

	public DxxText Text_Level;

	public DxxText Text_EffectTitle;

	public DxxText Text_LeftTime;

	public DxxText Text_Effect;

	public ButtonCtrl Button_Pray;

	public ButtonCtrl Button_Altar;

	public GameObject Cost;

	public DxxText Text_Bless;

	public DxxText Text_Free;

	public DxxText Text_Diamond;

	public DxxText Text_ButtonTime;

	public DxxText Text_Altar;

	public GameObject Guild_Bless;

	public GameObject Guild_Altar;

	public AltarBG altarBG;

	private AltarData altarData;

	public GameObject AltarTab;

	public ButtonCtrl Button_ArrowLeft;

	public ButtonCtrl Button_ArrowRight;

	private AltarTabType currentTab;

	public ButtonCtrl[] Button_Tab;

	public DxxText[] Text_Tab;

	public GameObject[] Focus_Tab;

	public GameObject RelicsTab;

	public GameObject HeroTab;

	public ButtonCtrl Button_Hero;

	public GameObject HeroEx_Icon;

	public Color color;

	private List<AltarTabType> allTabs;

	public void Awake()
	{
	}

	public void open(AltarTabType tab)
	{
	}

	private void init()
	{
	}

	public void freshUI()
	{
	}

	private void onButtonPray()
	{
	}

	private void onButtonAltar()
	{
	}

	public void onLanguage()
	{
	}

	public void onButtonTabEquip()
	{
	}

	public void onButtonTabHero()
	{
	}

	public void onButtonTabRelicsm()
	{
	}

	public void onButtonTabLeft()
	{
	}

	public void onButtonTabRight()
	{
	}

	private void setTabState(int state)
	{
	}

	private void onButtonHeroExchange()
	{
	}

	private int GetTabIndex(AltarTabType tabType)
	{
		return 0;
	}
}
