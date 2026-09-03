using System.Collections.Generic;
using TableTool;

public class SkillAlone2068 : SkillAloneBase
{
	private int CONFIG_ROOM_NUM;

	private List<Goods_goods.GoodData> m_listGoodDatas;

	private int m_nLastAngleRoomId;

	protected virtual WindowID WindowID => WindowID.WindowID_Invaild;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onEventNPCStartDisappear(EventWindowCtrl ctrl)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
