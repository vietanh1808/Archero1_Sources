using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UINumberItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CplayAni_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string numStr;

		public UINumberItem _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CplayAni_003Ed__13(int _003C_003E1__state)
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
	private sealed class _003CrollDigit_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int targetDigit;

		public Image img;

		public UINumberItem _003C_003E4__this;

		private float _003Cinterval_003E5__2;

		private int _003Cd_003E5__3;

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
		public _003CrollDigit_003Ed__14(int _003C_003E1__state)
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

	public RectTransform Content;

	public GameObject cpItem;

	private float aniDurationPerDigit;

	private float aniDelayPerDigit;

	private const string ATLAS_NUMBER = "number";

	private const string SPRITE_PREFIX = "num_";

	private List<Image> digitImages;

	private Sprite[] spriteCache;

	private Coroutine aniCoroutine;

	private Sprite getNumSprite(int digit)
	{
		return null;
	}

	public void init(int number, bool ani)
	{
	}

	public void initZero(int number)
	{
	}

	private void refreshDigitCount(int count)
	{
	}

	[IteratorStateMachine(typeof(_003CplayAni_003Ed__13))]
	private IEnumerator playAni(string numStr)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CrollDigit_003Ed__14))]
	private IEnumerator rollDigit(Image img, int targetDigit)
	{
		return null;
	}
}
