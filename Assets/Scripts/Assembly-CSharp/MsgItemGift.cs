using UnityEngine;
using UnityEngine.UI;

public class MsgItemGift : MsgItemBaseWithHeadItem
{
	public DxxText Text_Name;

	public DxxText Text_Time;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Open;

	public ButtonCtrl Button_Like;

	public Image Image_Liked;

	public Image Image_TitleBG;

	public Image Image_BG;

	public DxxText Text_Open;

	public DxxText Text_Like;

	public DxxText Text_Liked;

	public Image Image_Box;

	public Color color1;

	public Color color2;

	private ChatMsgDataGift data;

	private int ID;

	protected override void OnInit(ChatMsgDataBase d)
	{
	}

	private void onButtonOpen()
	{
	}

	private void onButtonLike()
	{
	}

	private void freshItem()
	{
	}

	private void resetGiftStateifLevel()
	{
	}
}
