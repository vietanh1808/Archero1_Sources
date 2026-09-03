using DG.Tweening;
using UnityEngine;

public class SailingTurnWheel : MonoBehaviour
{
	public int showCount;

	public float wheelTime;

	public bool isClockwise;

	public AnimationCurve CurveRotate;

	private Tween wheelTween;

	protected int CurWheelIndex;

	[HideInInspector]
	public bool isComplete;

	private int m_CurRateIndex;

	public virtual void Init()
	{
	}

	public virtual void Open(int wheelIndex)
	{
	}

	public void StartWheel(int index)
	{
	}

	public virtual void Close()
	{
	}

	public virtual void Stop(bool isComplete = false)
	{
	}
}
