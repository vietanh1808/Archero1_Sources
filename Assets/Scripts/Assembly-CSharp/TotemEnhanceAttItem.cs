using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class TotemEnhanceAttItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRefreshAtt_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TotemEnhanceAttItem _003C_003E4__this;

		public TotemAtt crtAtt;

		public bool isMain;

		public TotemAtt targetAtt;

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
		public _003CRefreshAtt_003Ed__16(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRefreshLevel_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TotemEnhanceAttItem _003C_003E4__this;

		public int targetLevel;

		public string totemName;

		public Color rareColor;

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
		public _003CRefreshLevel_003Ed__21(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRefreshSkill_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TotemEnhanceAttItem _003C_003E4__this;

		public TotemAtt skillAtt;

		public bool isMain;

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
		public _003CRefreshSkill_003Ed__18(int _003C_003E1__state)
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

	[SerializeField]
	private DxxImage rareIcon;

	[SerializeField]
	private DxxFitContentText crtAttTxt;

	[SerializeField]
	private DxxFitContentText targetAttTxt;

	[SerializeField]
	private DxxFitContentText normalDescTxt;

	[SerializeField]
	private DxxFitContentText lockDescTxt;

	[SerializeField]
	private GameObject goArrow;

	[SerializeField]
	private GameObject goLock;

	[SerializeField]
	private GameObject goUnLock;

	[SerializeField]
	private GameObject goEnhance;

	[SerializeField]
	private GameObject goEnhanceEffect;

	private Color _mainAttColor;

	private Color _lockAttColor;

	private WaitForSeconds _wait;

	private Coroutine coroutineCountDown;

	private Sequence _seq;

	public void InitAtt(TotemAtt crtAtt, TotemAtt targetAtt, bool isMain = false)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshAtt_003Ed__16))]
	private IEnumerator RefreshAtt(TotemAtt crtAtt, TotemAtt targetAtt, bool isMain = false)
	{
		return null;
	}

	public void InitSkill(TotemAtt skillAtt, bool isMain = false)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshSkill_003Ed__18))]
	private IEnumerator RefreshSkill(TotemAtt skillAtt, bool isMain)
	{
		return null;
	}

	public void InitLock(int unlockLevel, bool isPlayBreath = false)
	{
	}

	public void InitLevel(string totemName, int level, int targetLevel, Color rareColor, bool isPlayEffect = false)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshLevel_003Ed__21))]
	private IEnumerator RefreshLevel(string totemName, int level, int targetLevel, Color rareColor)
	{
		return null;
	}

	private void RefreshRareIcon(TotemAtt att)
	{
	}

	public void SetRareIconShow(bool isShow)
	{
	}

	public void PlayEnhanceEffect()
	{
	}
}
