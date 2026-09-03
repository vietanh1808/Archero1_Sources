using UnityEngine;

public class HitEdit : MonoBehaviour
{
	public enum EHittedScaleAnimation
	{
		eNone = 0,
		jelly_likebat = 1,
		jelly_likeflower = 2,
		jelly_likestone = 3,
		jelly_likeghost = 4,
		jelly_likestonesmall1 = 5,
		jelly_likestonesmall2 = 6
	}

	public enum EHittedPositionAnimation
	{
		eNone = 0,
		pos_likestone = 1
	}

	private EntityBase m_Entity;

	[Header("受击变白时间")]
	public float HittedWhiteTime;

	[Header("受击变白曲线")]
	public AnimationCurve HittedWhiteCurve;

	[Header("受击变白最大值")]
	public float HittedWhiteMax;

	private Animator m_AnimatorJelly;

	[Header("受击变形动画")]
	public EHittedScaleAnimation HittedScaleAnimation;

	private string mHittedScaleAnimation;

	private Animator m_AnimatorPosition;

	private EHittedPositionAnimation HittedPositionAnimation;

	private string mHittedPositionAnimation;

	private bool bPlayJelly;

	private int mPlayJellyFrame;

	private bool bPlayPosition;

	private int mPlayPositionFrame;

	public void Init(EntityBase entity)
	{
	}

	public void DeInit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void InitHittedWhiteCurve()
	{
	}

	private void MoveKey(int index, float scale, Keyframe keyframe)
	{
	}

	public float GetHittedWhiteByTime(float time)
	{
		return 0f;
	}

	public bool IsHittedWhiteEnd(float time)
	{
		return false;
	}

	private void InitHittedAnimation()
	{
	}

	public void HittedAnimationCallBack()
	{
	}

	public void HittedPosAni()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void DeInitHittedAnimation()
	{
	}
}
