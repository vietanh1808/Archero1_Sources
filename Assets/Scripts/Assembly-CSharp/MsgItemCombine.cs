using UnityEngine;

public class MsgItemCombine : MsgItemBaseWithHeadItem
{
	public PropOneEquip equipOne;

	public GameObject defaultIcon;

	public DxxText Text_Name;

	public DxxText Text_Time;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Like;

	public GameObject Liked;

	public DxxText Text_Like;

	public DxxText Text_Liked;

	private ChatMsgDataCombine data;

	protected override void OnInit(ChatMsgDataBase d)
	{
	}

	private void onButtonLike()
	{
	}

	public void freshItem()
	{
	}
}
