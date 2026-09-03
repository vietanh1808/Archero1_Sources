using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;

public class ProgressAniManager
{
	public class ProgressTransfer
	{
		private ObscuredFloat _currentvalue;

		public ObscuredFloat changevalue;

		public ObscuredFloat maxvalue;

		public ObscuredInt currentlevel;

		public bool islevelup;

		public bool isend;

		public Dictionary<int, float> levellist;

		public float currentvalue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float percent => 0f;

		public ProgressTransfer(int currentlevel, float currentvalue)
		{
		}

		public void init(int currentlevel, float currentvalue)
		{
		}

		public void init()
		{
		}

		public void clear()
		{
		}

		public void levelup()
		{
		}

		private float getcurrentmax()
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}

	private ObscuredInt _currentlevel;

	private ObscuredFloat _currentvalue;

	public Dictionary<int, float> levellist;

	public float progresstime;

	private float addvalue;

	private float currentaddvalue;

	private ProgressTransfer mTransfer;

	private Sequence seq;

	private Action<ProgressTransfer> updatecallback;

	public int currentlevel
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public float currentvalue
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public void Init(int currentlevel, float currentvalue, Dictionary<int, float> levellist)
	{
	}

	public void Deinit()
	{
	}

	public void SetUpdate(Action<ProgressTransfer> updatecallback)
	{
	}

	public Sequence Play(float add)
	{
		return null;
	}

	private void KillSequence()
	{
	}

	private float getcurrentmax()
	{
		return 0f;
	}
}
