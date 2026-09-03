using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillButtonManager
{
	public class SkillButtonVO
	{
		public float Duration;

		public float Offset;

		public Transform Transform;

		public bool IsRunning;

		private bool isLeft;

		private RectTransform rectTrans;

		private Vector2 ScreenPos;

		private Vector2 OffScreenPos;

		private Sequence sequence;

		public SkillButtonVO(Transform transform)
		{
		}

		public void DeInit()
		{
		}

		private void checkLocation()
		{
		}

		public void OffScreen()
		{
		}

		public void OnScreen()
		{
		}

		public void PlayOffScreenAnim()
		{
		}

		public void PlayOnScreenAnim()
		{
		}

		public void KillSeq()
		{
		}
	}

	private static SkillButtonManager _instance;

	private Dictionary<Transform, SkillButtonVO> _SkillButtonVODic;

	public Dictionary<Transform, SkillButtonVO> SkillButtonVODic => null;

	public SkillButtonVO CancelDisguiseVO { get; set; }

	public static SkillButtonManager Instance => null;

	public void DeInit()
	{
	}

	public SkillButtonVO GetSkillButtonVO(Transform transform)
	{
		return null;
	}

	public Dictionary<Transform, SkillButtonVO> GetSkillButtonVODic()
	{
		return null;
	}

	public bool IsRunning()
	{
		return false;
	}

	public void Add2Dic(Transform transform)
	{
	}

	public void SetOtherSkillTransVisible(Transform activatedTrans, bool visible)
	{
	}

	public void SetAllSkillTransVisible(bool visible)
	{
	}
}
