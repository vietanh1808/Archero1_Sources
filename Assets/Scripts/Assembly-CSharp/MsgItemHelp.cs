using UnityEngine;
using UnityEngine.UI;

public class MsgItemHelp : MsgItemBase
{
	public Image Icon;

	public EquipOneCtrl equipOne;

	public GameObject Left;

	public DxxText Left_Title;

	public DxxText Left_Count;

	public DxxText Right_Count;

	public DxxText Text_Name;

	public DxxText Text_SubTitle;

	public DxxText Text_Time;

	public DxxText Text_Desc;

	public Slider slider;

	public DxxText Text_Slider;

	public DxxText Text_Progress;

	public DxxText Text_Button;

	public ButtonCtrl Button_Help;

	private int equipId;

	private int haveCount;

	private int needCount;

	private int addScore;

	private int sdkType;

	private int sdkId;

	private bool isBadge;

	private ChatMsgDataHelp data;

	protected override void OnInit(ChatMsgDataBase d)
	{
	}

	private void onClickHelp()
	{
	}

	private void freshItem()
	{
	}
}
