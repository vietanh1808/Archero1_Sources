using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EquipBuyInfoUICtrl : MediatorCtrlBase
{
	private const string AniMoveName = "CharEquipInfoMove";

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Buy;

	public Transform equipparent;

	public DxxText Text_Info;

	public GoldTextCtrl mGoldTextCtrl;

	public ButtonCtrl Button_Mask;

	public DxxText Text_SkillName;

	public DxxText Text_Buy;

	public GameObject attributeParent;

	public DxxText Text_Attribute;

	private BlackItemOnectrl _itemone;

	private EquipBuyInfoProxy.Transfer mTransfer;

	private LocalUnityObjctPool mPool;

	private LocalSave.EquipOne mEquipData;

	private List<Text> mTexts;

	private BlackItemOnectrl itemone => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private void InitAttribute()
	{
	}

	private void InitButton()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void UpdateNet()
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
