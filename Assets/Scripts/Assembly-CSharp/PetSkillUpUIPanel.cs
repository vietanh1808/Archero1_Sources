using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PetSkillUpUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Name;

	public DxxText Text_Origin;

	public Image Ski_BG;

	public Image Ski_Icon;

	public Image Img_Flag;

	public RectTransform RTF_DescContent;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Choose;

	public DxxText Text_Choose;

	public ButtonCtrl Button_Up;

	public DxxText Text_Up;

	public DxxText Text_Level;

	public GameObject Bottom;

	public DxxText Text_UnlockTips;

	public PropOneEquip propItem;

	public ScrollRect scrollRect;

	public RectTransform RTF_Content;

	public GameObject cpAttrItem;

	private List<PetAttrData> dataList;

	private PetSkillShowData pssd;

	private int skiId;

	private int skiPos;

	private int skiLv;

	private int needMatId;

	private int needMatCount;

	private int haveMatCount;

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

	private void initUI()
	{
	}

	private void freshUI()
	{
	}

	private void initInfo()
	{
	}

	private void initAttrList()
	{
	}

	private void freshAttrList()
	{
	}

	private void onButtonChoose()
	{
	}

	private void onButtonUp()
	{
	}
}
