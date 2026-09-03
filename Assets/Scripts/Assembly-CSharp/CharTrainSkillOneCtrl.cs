using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CharTrainSkillOneCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayUpgradeAnim_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public CharTrainSkillOneCtrl _003C_003E4__this;

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
		public _003CPlayUpgradeAnim_003Ed__11(int _003C_003E1__state)
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

	public CharStarShowItem starItem;

	public Animator UpgradeAnim;

	public Image allHerobg;

	public GameObject allHeroText;

	private static Color textcolor;

	private static Color imagecolor;

	private static Color whiteColor;

	public void init(int charid, int star)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayUpgradeAnim_003Ed__11))]
	private IEnumerator PlayUpgradeAnim(float waitTime)
	{
		return null;
	}
}
