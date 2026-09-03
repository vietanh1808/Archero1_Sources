using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BadgeActUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_CountDown;

	[SerializeField]
	private DxxText Sub_Title;

	[SerializeField]
	private DxxText Text_Score;

	[SerializeField]
	private ButtonCtrl Button_Close;

	[SerializeField]
	private ButtonCtrl Button_Info;

	[SerializeField]
	private ButtonCtrl Button_Task;

	[SerializeField]
	private DxxText Text_Task;

	[SerializeField]
	private GameObject RedDot_Task;

	[SerializeField]
	private Image Image_Progress;

	[SerializeField]
	private BadgeBoxItem[] boxItems;

	[SerializeField]
	private DxxText Text_TimeUp;

	[SerializeField]
	private ButtonCtrl Button_Badge;

	[SerializeField]
	private DxxText Text_Badge;

	[SerializeField]
	private GameObject RedDot_Badge;

	[SerializeField]
	private DxxText Text_Info;

	[SerializeField]
	private DxxText Text_BagTips;

	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	public void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonBadge()
	{
	}

	private void Esc()
	{
	}

	private void initBox()
	{
	}

	private void initUI()
	{
	}

	private void freshReward()
	{
	}

	private void freshTime()
	{
	}

	private void freshProgress()
	{
	}

	private void freshRedDot()
	{
	}
}
