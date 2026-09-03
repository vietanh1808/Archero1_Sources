using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SailingSalvageUIPanel : MediatorCtrlBase
{
	private class TimeLineSalvage : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineSalvage _003C_003E4__this;

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
			public _003CWait_003Ed__2(int _003C_003E1__state)
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

		private float waitsecond;

		public TimeLineSalvage(SailingSalvageUIPanel sailingSalvageCtrl, float second)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__2))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	public SailingSalvagePreviewCtrl previewCtrl;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl getBtn;

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText hookText;

	public DxxText hookLevelText;

	public DxxText talentTex;

	public DxxText talentAddTex;

	public DxxText btnTex;

	public DxxText noDropDescText;

	public SailingMapShipItem shipItem;

	public Transform propItemParent;

	public CanvasGroup dropItem;

	public Image dropItemIcon;

	public PropOneEquip copyone;

	private TimeLineContainer timeLine;

	private List<PropOneEquip> items;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	protected override void OnClose()
	{
	}

	public void ClosePanel()
	{
	}

	private void OpenInfo()
	{
	}

	private void GetSalvage()
	{
	}

	private void freshTime()
	{
	}

	private void freshBtnTime()
	{
	}

	private void freshReqInfo()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void DoSalvageAni()
	{
	}

	private bool OnCheckGuideCondition(SailingGuideManager.GuideModule module)
	{
		return false;
	}
}
