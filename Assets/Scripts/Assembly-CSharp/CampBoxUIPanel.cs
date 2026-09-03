using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class CampBoxUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public DxxText Text_Name;

	public DxxText Text_Cursor;

	public CampTileIcon Image_TileIcon;

	public DxxText Text_Reward;

	public RectTransform Content;

	public ButtonCtrl Button_Open;

	public DxxText Text_Open;

	public GameObject TopOpen;

	public Image Icon_Currency;

	public DxxText Text_NeedCount;

	public ButtonCtrl Button_Check;

	public GameObject CheckObj;

	public DxxText Text_Check;

	public ScrollRect scroll;

	public GameObject cpItem;

	public ButtonCtrl Button_Diamond;

	public DxxText Text_Diamond;

	public ButtonCtrl Button_Key;

	public DxxText Text_Key;

	private CampBoxTileData boxData;

	private SLG_TreasureBox slg_tsb;

	private int needType;

	private int needCount;

	private long haveCount;

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

	private void Esc()
	{
	}

	private void initUI()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonOpen()
	{
	}

	private void onButtonCheck()
	{
	}

	private void onButtonDiamond()
	{
	}

	private void onButtonKey()
	{
	}

	private void freshTopCurrency()
	{
	}
}
