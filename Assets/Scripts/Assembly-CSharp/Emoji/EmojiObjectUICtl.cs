using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace Emoji
{
	public class EmojiObjectUICtl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitPlayEnd_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float pAniTime;

			public EmojiObjectUICtl _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitPlayEnd_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public Transform arrowRight;

		public Transform arrowLeft;

		public Transform arrowAll;

		public Transform continer;

		public const string emojiPath = "EmojiPfb/";

		[CompilerGenerated]
		private Action<EmojiObjectUICtl> m_OnComplete;

		private EntityBase ownerEntity;

		private Transform ownerTrans;

		private EmojiObject emojiInfo;

		private Transform aniTrans;

		private SkeletonGraphic skeletonGraphic;

		private RectTransform rectTransform;

		private RectTransform windowRectTrans;

		private Vector2 size;

		private string resPath;

		private bool rightSide;

		private bool isInit;

		public bool IsUsed { get; private set; }

		public event Action<EmojiObjectUICtl> OnComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Init(EmojiObject pInfo)
		{
		}

		private void InitAnimation()
		{
		}

		public void SetOwner(EntityBase pOwner)
		{
		}

		public void Clear()
		{
		}

		public void Play()
		{
		}

		public void setTrangle(int direction)
		{
		}

		private void OnSpineComplete(TrackEntry trackEntry)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitPlayEnd_003Ed__30))]
		private IEnumerator WaitPlayEnd(float pAniTime)
		{
			return null;
		}

		private void OnAnimationComplete()
		{
		}

		private void Update()
		{
		}

		private void UpdatePostion(bool isFirst = false)
		{
		}

		private float GetPosX(float pX)
		{
			return 0f;
		}

		private bool GetPosY(float pH, out float y)
		{
			y = default;
			return false;
		}
	}
}
