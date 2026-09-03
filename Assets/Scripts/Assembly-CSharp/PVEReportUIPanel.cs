using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PVEReportUIPanel : MediatorCtrlBase
{
	public class PVEReportData
	{
		public int type;

		public string userid;

		public string name;

		public int head;

		public int headBox;

		public long headTime;

		public int vip;

		public int level;

		public int talent;

		public int soul;

		public List<int> medals;
	}

	public GameObject PanelInfo;

	public GameObject PanelReport;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public HeadItem headItem;

	public DxxText Text_Name;

	public DxxText Text_ID;

	public ButtonCtrl Button_Open;

	public DxxText Text_Open;

	public DxxRtlText Text_GuildTitle;

	public DxxRtlText Text_GuildName;

	public Image Image_GuildIconB;

	public Image Image_GuildIconT;

	public DxxRtlText Text_GuildLv;

	public DxxRtlText Text_GuildLvValue;

	public GameObject GuildLvIcon;

	public DxxRtlText Text_Level;

	public DxxRtlText Text_LevelValue;

	public DxxRtlText Text_Talent;

	public DxxRtlText Text_TalentValue;

	public DxxRtlText Text_Soul;

	public DxxRtlText Text_SoulValue;

	public DxxText Text_TitleReport;

	public DxxText Text_SubTitleReport;

	public GameObject[] check;

	public DxxText[] Text_Reports;

	public ButtonCtrl Button_Report;

	public DxxText Text_Report;

	public ButtonCtrl Button_ReportClose;

	public GameObject BattleObj;

	public GameObject SoulObj;

	public MedalItem medalItem;

	private PVEReportData reportData;

	private int chooseIndex;

	private string sdk_guildid;

	private string suserid;

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

	private void android_escape()
	{
	}

	private void onButtonOpenReport()
	{
	}

	public void onButtonChoose(int index)
	{
	}

	public void onButtonReport()
	{
	}

	public void onButtonClose()
	{
	}
}
