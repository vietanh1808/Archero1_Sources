public class MsgItemBattle : MsgItemBaseWithHeadItem
{
	public DxxText Text_Name;

	public DxxText Text_Time;

	public DxxText Text_Desc;

	public DxxText Text_Join;

	public ButtonCtrl Button_Join;

	private ChatMsgDataBattle data;

	private string mRoomID;

	protected override void OnInit(ChatMsgDataBase d)
	{
	}

	private void onButtonClickJoin()
	{
	}

	private void joinBattle()
	{
	}
}
