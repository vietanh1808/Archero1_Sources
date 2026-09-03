using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CharUpgradeRewardOneCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayUpgradeAnim_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public CharUpgradeRewardOneCtrl _003C_003E4__this;

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
		public _003CPlayUpgradeAnim_003Ed__16(int _003C_003E1__state)
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

	public DxxImage Image_BG;

	public GameObject Image_Lock;

	public DxxImage Image_Unlock;

	public DxxText Text_UnlockLevel;

	public DxxText Text_AttributeAH_Lock;

	public GameObject allheroes;

	public Image Image_AllHeroes;

	public DxxText Text_AllHeroes;

	public DxxText Text_AttributeAH;

	public Animator UpgradeAnim;

	public GameObject AllHeroContainer;

	public GameObject mask;

	private static Color lockcolor;

	private static Color imagecolor;

	private static readonly Color bgcolor;

	public void Init(LocalSave.CharacterOne one, int index, bool ifInit = true)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayUpgradeAnim_003Ed__16))]
	private IEnumerator PlayUpgradeAnim(float waitTime)
	{
		return null;
	}
}
