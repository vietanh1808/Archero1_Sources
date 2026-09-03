using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class EggEntranceCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayEggAni_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EggEntranceCtrl _003C_003E4__this;

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
		public _003CPlayEggAni_003Ed__19(int _003C_003E1__state)
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

	public const string EggAniString = "boxchestRotating_01";

	public const string ManorAniString = "eui_boxchestrotating_01";

	public WindowButtonCtrl Button_Layer;

	public RedNodeCtrl mRedCtrl;

	public RectTransform BoxTran;

	public RectTransform ManorTran;

	public Animation Ani_Egg;

	public Animation Ani_Manor;

	public GameObject go_Ani;

	private Sequence seq;

	private Sequence seq2;

	private bool isAdd;

	private bool isDataAlready;

	private void Awake()
	{
	}

	public void ShowEggArrow(bool visible)
	{
	}

	public static void OpenFarmRequest()
	{
	}

	public void FarmRequest(Action callback)
	{
	}

	private void OnDestroy()
	{
	}

	public void showIcon()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayEggAni_003Ed__19))]
	public IEnumerator PlayEggAni()
	{
		return null;
	}

	public void showGuider()
	{
	}
}
