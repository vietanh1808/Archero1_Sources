using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ActIslandVSPropItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CJumpNumber_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActIslandVSPropItem _003C_003E4__this;

		public int ratio;

		private bool _003CneedAni_003E5__2;

		private int _003Chave_003E5__3;

		private int _003Cmax_003E5__4;

		private int _003CendValue_003E5__5;

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
		public _003CJumpNumber_003Ed__10(int _003C_003E1__state)
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

	public Image Image_BG;

	public Image Shine;

	public DxxText Text_Count;

	public PropOneEquip propItem;

	public GameObject GetEffectObj;

	public DxxText Text_ID;

	private ActIslandVSWheelInData itemData;

	private int showHave;

	public void init(ActIslandVSWheelInData data)
	{
	}

	public void freshItem_Text(int ratio)
	{
	}

	[IteratorStateMachine(typeof(_003CJumpNumber_003Ed__10))]
	private IEnumerator JumpNumber(int ratio)
	{
		return null;
	}

	public void freshItem_Shine()
	{
	}
}
