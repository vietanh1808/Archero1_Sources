using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class GuildActivityStageItem : GamePlayActivityOne_Normal
{
	[SerializeField]
	private ButtonCtrl btnInfo;

	[SerializeField]
	private ButtonCtrl btnSubmit;

	[SerializeField]
	private ButtonCtrl btnCloseInfo;

	[SerializeField]
	private ButtonCtrl btnChest;

	[SerializeField]
	private DxxText txtLvl;

	[SerializeField]
	private DxxText txtBtnSubmit;

	[SerializeField]
	private DxxText txtCurChestLevel;

	[SerializeField]
	private DxxText txtInfoTitle;

	[SerializeField]
	private DxxText txtInfo;

	[SerializeField]
	private GameObject goMaskSubmit;

	[SerializeField]
	private GameObject goInfo;

	[SerializeField]
	private GameObject goRewards;

	[SerializeField]
	private GameObject goEffect;

	[SerializeField]
	private GuildChestRewardPreview rewardPreview;

	public Image Image_Box;

	private int activityId;

	public ButtonCtrl Button_Close;

	private GuildActivityTabUICtrl tabActUI;

	private void Awake()
	{
	}

	private void OnBtnChestClick()
	{
	}

	protected override void onMaskShow(bool value)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void SetData(GuildActivityTabUICtrl ui, LocalSave.GamePlayActivityOneData localData, Daily_DailyType tData, int activityId)
	{
	}

	private void SetGuildDailySpecial()
	{
	}

	protected override void RefreshData()
	{
	}
}
