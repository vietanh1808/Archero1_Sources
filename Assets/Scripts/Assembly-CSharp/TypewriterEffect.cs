using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TypewriterEffect : BaseMeshEffect
{
	[CompilerGenerated]
	private sealed class _003CTypeText_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TypewriterEffect _003C_003E4__this;

		public string fullText;

		private int _003CtotalLength_003E5__2;

		private int _003CcurrentCount_003E5__3;

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
		public _003CTypeText_003Ed__18(int _003C_003E1__state)
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

	private int visibleCharacterCount;

	private Text text;

	private Coroutine coroutine;

	[Range(0.05f, 5f)]
	public float typingSpeed;

	public Vector2 fontBestFit;

	[HideInInspector]
	public bool isTypeing;

	[CompilerGenerated]
	private Action m_OnEndCallBack;

	public Text Text => null;

	public event Action OnEndCallBack
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

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnEnable()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void UpdateVisibleCharacters(int count)
	{
	}

	public void StartTypewriter(string fullText)
	{
	}

	public void Kill(bool isComplete = true)
	{
	}

	[IteratorStateMachine(typeof(_003CTypeText_003Ed__18))]
	private IEnumerator TypeText(string fullText)
	{
		return null;
	}
}
