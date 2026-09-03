using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using UnityEngine;

namespace DG.Tweening
{
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		public float delay;

		public float duration;

		public Ease easeType;

		public AnimationCurve easeCurve;

		public LoopType loopType;

		public int loops;

		public string id;

		public bool isRelative;

		public bool isFrom;

		public bool isIndependentUpdate;

		public bool autoKill;

		public bool isActive;

		public bool isValid;

		public Component target;

		public DOTweenAnimationType animationType;

		public TargetType targetType;

		public TargetType forcedTargetType;

		public bool autoPlay;

		public bool useTargetAsV3;

		public float endValueFloat;

		public Vector3 endValueV3;

		public Vector2 endValueV2;

		public Color endValueColor;

		public string endValueString;

		public Rect endValueRect;

		public Transform endValueTransform;

		public bool optionalBool0;

		public float optionalFloat0;

		public int optionalInt0;

		public RotateMode optionalRotationMode;

		public ScrambleMode optionalScrambleMode;

		public string optionalString;

		private bool _tweenCreated;

		private int _playCount;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void CreateTween()
		{
		}

		public override void DOPlay()
		{
		}

		public override void DOPlayBackwards()
		{
		}

		public override void DOPlayForward()
		{
		}

		public override void DOPause()
		{
		}

		public override void DOTogglePause()
		{
		}

		public override void DORewind()
		{
		}

		public override void DORestart(bool fromHere = false)
		{
		}

		public override void DOComplete()
		{
		}

		public override void DOKill()
		{
		}

		public void DOPlayById(string id)
		{
		}

		public void DOPlayAllById(string id)
		{
		}

		public void DOPauseAllById(string id)
		{
		}

		public void DOPlayBackwardsById(string id)
		{
		}

		public void DOPlayBackwardsAllById(string id)
		{
		}

		public void DOPlayForwardById(string id)
		{
		}

		public void DOPlayForwardAllById(string id)
		{
		}

		public void DOPlayNext()
		{
		}

		public void DORewindAndPlayNext()
		{
		}

		public void DORestartById(string id)
		{
		}

		public void DORestartAllById(string id)
		{
		}

		public List<Tween> GetTweens()
		{
			return null;
		}

		public static TargetType TypeToDOTargetType(Type t)
		{
			return TargetType.Unset;
		}

		private void ReEvaluateRelativeTween()
		{
		}
	}
}
