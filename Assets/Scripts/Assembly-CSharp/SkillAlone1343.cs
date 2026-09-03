using System.Collections.Generic;
using Dxx.Util;

public class SkillAlone1343 : SkillAloneMagicBookBase
{
	private List<int> m_listDebuffIds;

	private List<int> m_listBuff1Ids;

	private List<int> m_listBuff2Ids;

	private List<int> m_listBuff3Ids;

	private int m_nEndBuffId;

	private float m_fDuration;

	private float m_fInterval;

	private float m_fTime;

	private bool m_bUseSkill;

	private float m_fDebuffTime;

	private float m_fBulletSlowDownPercent;

	private SequencePool mSeqPool;

	private Dictionary<BulletBase, float> m_dicBullets;

	protected override void OnInstall()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	protected override void OnUninstall()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
