using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EmojiPanelCtl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowAnimation_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmojiPanelCtl _003C_003E4__this;

		private float _003Ctspeed_003E5__2;

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
		public _003CShowAnimation_003Ed__15(int _003C_003E1__state)
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

	public ButtonCtrl showBtn;

	public Image showBtn_Image;

	public Image cdImage;

	public GameObject itemTemp;

	public RectTransform content;

	private List<EmojiItem> emojiItems;

	private IEnumerator ientor;

	private bool clickShow;

	private float cdTimer;

	private const float cdMax = 5f;

	private void Awake()
	{
	}

	private void Init()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPlayEmoji(int pIndex)
	{
	}

	private void OnShowClick()
	{
	}

	private void SetBtnColor()
	{
	}

	[IteratorStateMachine(typeof(_003CShowAnimation_003Ed__15))]
	private IEnumerator ShowAnimation()
	{
		return null;
	}

	private void SetCanClick(bool pCanClick)
	{
	}

	private void ShowCD(bool pShow)
	{
	}

	private void Update()
	{
	}

	private void UpdateTimer(float dt)
	{
	}

	private void UpdateChild(float dt)
	{
	}
}
