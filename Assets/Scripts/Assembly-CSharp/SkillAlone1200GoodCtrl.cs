using Dxx.Util;
using UnityEngine;

public class SkillAlone1200GoodCtrl : SkillAloneGoodCtrlBase
{
	private SequencePool mSeqPool;

	private float m_fStartTime;

	private float m_fTime;

	private SphereCollider mCollider;

	public ParticleSystem[] particles;

	private float _time;

	public void Init(EntityBase entity, int[] debuffs, float time, float radius)
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected override void SendBuffs()
	{
	}

	protected override void OnDeInit()
	{
	}
}
