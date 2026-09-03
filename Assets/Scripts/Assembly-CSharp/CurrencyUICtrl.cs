using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Key;

	public ButtonCtrl Button_Gold;

	public ButtonCtrl Button_Diamond;

	public ButtonCtrl Button_Level;

	public ButtonCtrl Button_Mask;

	public CurrencyLevelCtrl mLevelCtrl;

	public DxxText Text_UseKey;

	public CanvasGroup mUseKey;

	public Transform Tran_Key;

	public Image Image_Key;

	public Image Image_Gold;

	public Image Image_Diamond;

	public DxxText Text_Gold;

	public DxxText Text_Diamond;

	public DxxText Text_Time;

	public Animation keyrotate;

	public ProgressTextCtrl mProgressCtrl;

	public StarDiamondItem starDiamondItem;

	private static Dictionary<CurrencyType, string> mCurrencyPathList;

	private long mKeyStartTime;

	private int PerKeyTime;

	private CurrencyFlyCtrl mFlyCtrl;

	private long currenttime;

	private long count;

	private int last;

	private string str;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	protected override void OnClose()
	{
	}

	private void SetUseKeyShow(bool value)
	{
	}

	private void Update()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private Vector3 GetUseStartPos(CurrencyType type)
	{
		return default;
	}

	private void UpdateCurrency()
	{
	}

	private void UpdateGold()
	{
	}

	private void UpdateDiamond()
	{
	}

	private void UpDataStarDiamond()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
