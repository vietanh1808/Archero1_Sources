using System;
using System.Collections.Generic;
using UnityEngine;

public class GameThreeActionCtrl : ActionBasic
{
	public class ActionUp : ActionUIBase
	{
		public List<Transform> list;

		private int frame;

		private int currentframe;

		private float Speed;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void DoPosition(float speed)
		{
		}
	}

	public class ActionDown : ActionUIBase
	{
		public List<Transform> list;

		private int frame;

		private int currentframe;

		private float Speed;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void DoPosition(float speed)
		{
		}
	}

	public class ActionShowSieve : ActionUIBase
	{
		public GameObject sieve;

		public bool show;

		protected override void OnInit()
		{
		}
	}

	public class ActionRandomSieve : ActionUIBase
	{
		public List<Transform> list;

		public List<Transform> shadowlist;

		public Transform sieve;

		private Transform transform1;

		private Transform transform2;

		private Transform shadow1;

		private Transform shadow2;

		private int moveCount;

		private int currentCount;

		private int moveframe;

		private int currentframe;

		private float movestartx;

		private float moveendx;

		private int currentstate;

		private float y;

		private float yValue;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void RandomTransform(out Transform transform1, out Transform transform2, out Transform shadow1, out Transform shadow2)
		{
			transform1 = null;
			transform2 = null;
			shadow1 = null;
			shadow2 = null;
		}
	}

	public void DoAction(List<Transform> list, List<Transform> shadowlist, GameObject sieve, Action callback)
	{
	}

	public void OnClickOne(Transform transform, Transform sieve, Action<bool> callback)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}
}
