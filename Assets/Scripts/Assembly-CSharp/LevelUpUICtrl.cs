using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpUICtrl : MediatorCtrlBase
{
	public DxxText Text_LevelUp;

	public DxxText Text_ReachLevel;

	public Transform LevelUpItem;

	public Transform LevelItem;

	public DxxText Text_Level;

	public UILineCtrl mLineCtrl;

	public RectTransform rewardparent;

	public TapToCloseCtrl mCloseCtrl;

	public GameObject copyitems;

	public GameObject copyreward;

	public Image Img_Exp;

	private const float ShowScale = 1.5f;

	private const float playTime = 0.3f;

	private static int oldlevel;

	private LevelUpProxy.Transfer mTransfer;

	private int levelType;

	private LocalUnityObjctPool mPool;

	private List<GoldTextCtrl> mRewards;

	private List<Character_Level> mlevel;

	private List<Manor_ManorLV> manorLevel;

	private int adddiamond;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void InitUI()
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

	public static void SetOldLevel(int level)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void TryUpdateRuneInfo(int level)
	{
	}
}
