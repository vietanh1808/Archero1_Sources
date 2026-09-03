using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ThunderContinueMgr
{
	public class ThunderContinueData
	{
		public delegate Vector3 GetBulletPosDelegate(ThunderContinueReceive receiver, int cnt, int index);

		public delegate int GetBulletCntDelegate();

		public EntityBase entity;

		public int bulletid;

		public int count;

		public float delay;

		public float prev_scale;

		public string prev_effect;

		public GetBulletPosDelegate GetBulletPos;

		public GetBulletCntDelegate GetBulletCnt;
	}

	public class ThunderContinueReceive
	{
		public List<Sequence> seqs;

		public List<GameObject> prev_effects;

		public void Deinit()
		{
		}
	}

	public static ThunderContinueReceive GetThunderContinue(ThunderContinueData data)
	{
		return null;
	}
}
