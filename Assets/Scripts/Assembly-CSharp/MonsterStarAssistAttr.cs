using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterStarAssistAttr : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayUpgradeAnim_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public MonsterStarAssistAttr _003C_003E4__this;

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
		public _003CPlayUpgradeAnim_003Ed__14(int _003C_003E1__state)
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

	public GameObject allObj;

	public DxxText allText;

	public DxxText skillText;

	public Material grayMat;

	public GameObject starLight;

	public Animator UpgradeAnim;

	public GameObject allHerobg;

	public GameObject allHeroText;

	private static Color textcolor;

	private static Color imagecolor;

	private static Color whiteColor;

	public GameObject GrayPanel;

	public DxxText Text_Quality;

	public void init(int mid, string effect, int star, int arrive)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayUpgradeAnim_003Ed__14))]
	private IEnumerator PlayUpgradeAnim(float waitTime)
	{
		return null;
	}
}
