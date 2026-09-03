using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;

public class SkillAlone2163 : SkillAloneMagicBookActiveSkillBase
{
	private float CONFIG_TIME;

	private List<int> CONFIG_BUFF_IDS;

	private float CONFIG_HP_RECOVER_PERCENT;

	private float CONFIG_MELEE_BULLET_SCALE;

	private bool m_bUseSkill;

	private float m_fTime;

	private SequencePool mSeqPool;

	private EntityHero m_hero;

	private float CONFIG_ATTACK_RATE;

	private float CONFIG_ATTACK_SPEED_RATE;

	protected int PART_ID;

	private const float DEMOGORGON_APPEAR_TIME = 0.15f;

	protected EntityPartBodyBase DemogorgonPart;

	protected bool m_bDemonFlag;

	private Sequence seq;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	private void OnDoubleClick()
	{
	}

	protected void CreateDemon()
	{
	}

	protected virtual void OnCreateDemon()
	{
	}

	private void End()
	{
	}

	protected virtual void OnEnd()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CreatUnrealDemogorgon()
	{
	}

	private void Attribute2DemogorgonWrapper()
	{
	}

	public void CastSkill()
	{
	}

	private void MakeFullDarkEnergy()
	{
	}

	private void playAppearAnim(EntityBase entity)
	{
	}

	private void killSeq()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private float OnBulletScale(int id)
	{
		return 0f;
	}
}
