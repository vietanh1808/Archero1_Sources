using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GemInfoUICtrl : MediatorCtrlBase
{
	public UILineCtrl mTitleCtrl;

	public DxxText Text_Quality;

	public Image Image_BG;

	public Image Image_Circle;

	public Image Image_Icon;

	public DxxText Text_Level;

	public DxxText Text_Lv;

	public DxxText Text_Count;

	public DxxText Text_Desc;

	public DxxText Text_HaveMax;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Wear;

	public ButtonCtrl Button_Upgrade;

	public ButtonCtrl Button_Mask;

	public DxxText Text_Wear;

	public DxxText Text_Upgrade;

	public DxxText Text_AttributeTitle;

	public RectTransform AttrContainer;

	public DxxText cpTextAttr;

	private LocalSave.EquipOne oneEquip;

	private GemCombineData ccbd;

	private bool isGuiderRunning;

	public GameObject RedPoint;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
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

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}
}
