using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class SpecialEffectElement : MonoBehaviour
{
	public enum ElementPlayStyle
	{
		Once = 0,
		Loop = 1,
		Unreset = 2
	}

	[HideInInspector]
	[SerializeField]
	public float startTime;

	[HideInInspector]
	[SerializeField]
	public bool isLoop;

	[HideInInspector]
	[SerializeField]
	public ElementPlayStyle playStyle;

	[HideInInspector]
	[SerializeField]
	public float playTime;

	[NonSerialized]
	[HideInInspector]
	private bool canShow;

	protected float currPlayTime;

	[NonSerialized]
	[HideInInspector]
	private bool isPlaying;

	private float speedScale;

	public bool CanShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float SpeedScale => 0f;

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool _CopyValues(SpecialEffectElement o)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public bool IsEnable()
	{
		return false;
	}

	public void SetEnable(bool b)
	{
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void Stop()
	{
	}

	public void Reset()
	{
	}

	public void SetCurrPlayTime(float t)
	{
	}

	public void UpdateState(float elapseTime)
	{
	}

	public void UpdatePlayingState(float elapseTime)
	{
	}

	protected bool IsInPlayTimeInterval(float elapseTime)
	{
		return false;
	}

	protected float _CalcLocalTime(float elapseTime)
	{
		return 0f;
	}

	protected virtual void _Init()
	{
	}

	protected virtual void _PlayImpl()
	{
	}

	protected virtual void _PauseImpl()
	{
	}

	protected virtual void _ResetImpl()
	{
	}

	protected virtual void _OnEnableElement()
	{
	}

	protected virtual void _OnDisableElement()
	{
	}

	protected virtual void _SetCurrPlayTime(float t)
	{
	}

	protected virtual void _CustomOperate(float elapseTime)
	{
	}

	public virtual void SetSpeedScale(float scale)
	{
	}

	public virtual void UpdateSpeed()
	{
	}
}
