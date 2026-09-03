using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5103 : AIBase
{
	public class Action5Kills : ActionSeqWrapper
	{
		private AI5103 ai;

		private int curFrameCount;

		public float RadiusFactor;

		private bool isColliding;

		private const float deltaAngle = 30f;

		private const int count = 4;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		private ActionBase GetKillAction()
		{
			return null;
		}

		private void CheckCollision()
		{
		}

		protected void OnCollision(RaycastHit hitInfo)
		{
		}
	}

	private const int BULLET_ID = 5334;

	private List<CallData> calls;

	private float[] hplimit;

	private bool[] hpused;

	private float recoverhp;

	private WeightRandomCount weight;

	private int callid;

	private int attackcount;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	private void AddFirst()
	{
	}

	private void RecoverHPAction()
	{
	}

	private void JumpAction()
	{
	}

	private void CreateFire()
	{
	}

	protected override void OnAIDeInit()
	{
	}
}
