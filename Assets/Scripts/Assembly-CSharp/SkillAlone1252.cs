using System.Collections.Generic;

public class SkillAlone1252 : SkillAloneBase
{
	private class BuffData
	{
		public int id;

		public int weight;
	}

	private const float Interval = 5f;

	private float m_fTime;

	private int m_nIndex;

	private bool m_bTiming;

	private List<BuffData> m_listBuffDatas;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void SendBuff()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
