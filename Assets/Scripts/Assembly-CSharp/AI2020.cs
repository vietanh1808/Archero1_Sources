using System;
using UnityEngine;

public class AI2020 : AIBabyBase
{
	private float CdTime;

	private float ContinousTime;

	private float Radius;

	private int DebuffId;

	private int EffectId;

	private const string CatchingColor = "34FC00";

	private GameObject EffectObj;

	private SpriteRenderer Effect;

	private EntityBase Target;

	private float m_fTime;

	private float m_fCachedTime;

	private bool m_bStartFlag;

	private Action<AI2020> OnCatchedAction;

	private bool m_bCatched;

	public bool Catched
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void CacheEffect()
	{
	}

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	public void StartRun()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected override ActionBase GetAILogic()
	{
		return null;
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void CatchFail(bool play = true)
	{
	}

	public void Submit()
	{
	}

	private void PlayCallEffect()
	{
	}

	public void SetParams(float time, float continousTime, float radius, int debuffId, int effectId, EntityBase target, Action<AI2020> OnCatched)
	{
	}
}
