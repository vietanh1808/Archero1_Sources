using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class AltarReclicsPopUICtrl : MediatorCtrlBase
{
	public AltarBG altarBG;

	public DxxText Text_Title;

	public DxxText Text_Level;

	public DxxText Attr_Title;

	public DxxText Equip_Title;

	public DxxText Text_LevelMax;

	public Slider slider;

	public DxxText Text_Slider;

	public DxxText Slider_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Altar;

	public ButtonCtrl Button_AltarUp;

	public DxxText Text_ButtonAltar;

	public DxxText Text_ButtonUp;

	public GameObject EquipNode;

	public EquipOneCtrl equipLeft;

	public EquipOneCtrl equipRight;

	public RectTransform container;

	public GameObject attrItem;

	private AltarData altarData;

	private int maxLevel;

	private List<AltarAttrItemOne> attrItemList;

	public RectTransform Window;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	private void init()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonAltar()
	{
	}

	private void onButtonAltarUp()
	{
	}

	public void PlayLevelUp()
	{
	}

	private void setTopLevel()
	{
	}

	private void setBottomEquip()
	{
	}
}
