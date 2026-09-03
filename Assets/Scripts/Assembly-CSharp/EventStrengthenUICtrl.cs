using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;

public class EventStrengthenUICtrl : MediatorCtrlBase
{
	private class AttributeData
	{
		public string attribute;

		public string showstring;

		public string image;

		public int effectid;
	}

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Attribute;

	public DxxText Text_Content;

	public DxxImage Image_Icon;

	public ButtonAdControl mButtonAd;

	public ButtonCtrl Button_Free;

	public DxxText Text_BattlePassEffect;

	public DxxText Text_GetFree;

	private SequencePool mSeqPool;

	private ADSource source;

	private static List<AttributeData> mAttributes;

	private int attributeindex;

	private const float attack_add_percent = 0.05f;

	private const float hpmax_add_percent = 0.05f;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void RefreshBattlePassGain()
	{
	}

	private void close_show(bool value)
	{
	}

	private void android_escape()
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
}
