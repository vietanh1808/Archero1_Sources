using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DxxtextLink : Text, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CRefrehLayout_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DxxtextLink _003C_003E4__this;

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
		public _003CRefrehLayout_003Ed__19(int _003C_003E1__state)
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

	private Image _imgUnderLine;

	private LocalUnityObjctPool _pool;

	private string m_OutputText;

	private readonly List<HrefInfo_> m_HrefInfos;

	protected static readonly StringBuilder s_TextBuilder;

	private static readonly Regex s_VertexFilter;

	private VertexHelper _toFill;

	private bool bool_IsLink;

	private Action<string> linkFunc_Cb;

	private RectTransform rect_Parent;

	private const int perCharVerCount = 4;

	protected static readonly StringBuilder textRebuild;

	private RectTransform Rect_Parent => null;

	protected override void Awake()
	{
	}

	public void Set_TextLinkFuncCB(Action<string> linkFunc_Cb)
	{
	}

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CRefrehLayout_003Ed__19))]
	private IEnumerator RefrehLayout()
	{
		return null;
	}

	private string GetOutputText_Init(string outputText)
	{
		return null;
	}

	private string GetOutputText(string outputText, int currentVertCount)
	{
		return null;
	}

	private string GetOutputText_Nomal(string outputText)
	{
		return null;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
