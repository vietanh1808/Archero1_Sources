using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class FarmMinigameIntroUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_Play;

	public DxxText Text_Play;

	public Image Image_Banner;

	public DxxText Text_Desc;

	public DxxText Text_Rewards;

	public RectTransform rewardParent;

	public PropOneEquip copyReward;

	private LocalUnityObjctPool mPool;

	private FarmMinigameData data;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void CreateReward(Drop_DropModel.DropData[] rewards)
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

	public override void OnLanguageChange()
	{
	}
}
