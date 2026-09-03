using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DSMBloodPart : MonoBehaviour
{
	private class TimeLineChangeDamage : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CPlayCountChange_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineChangeDamage _003C_003E4__this;

			private float _003Coffset_003E5__2;

			private float _003Cstep_003E5__3;

			private float _003Cresult_003E5__4;

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
			public _003CPlayCountChange_003Ed__5(int _003C_003E1__state)
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

		private int startNum;

		private int addNum;

		private Text m_Text;

		private Slider sliderTween;

		public TimeLineChangeDamage(Text text, int start, int add, Slider slider)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayCountChange_003Ed__5))]
		public IEnumerator PlayCountChange()
		{
			return null;
		}
	}

	public Slider sliderTween;

	public Image headImage;

	public DxxText progressTex;

	public DxxText harmTex;

	public DSMRewardItem copyone;

	private List<DSMRewardItem> items;

	private Tween tween;

	private DeepSeaMonsterManager.Stage mCurSage;

	private TimeLineContainer timeLine;

	private int curDamage;

	public void Init()
	{
	}

	public void Open(DeepSeaMonsterManager.Stage stage, bool isRefresh)
	{
	}

	private void RefreshReward()
	{
	}

	public void PlayTween()
	{
	}

	public void AddDamage(int addDamage)
	{
	}

	public void Close()
	{
	}
}
