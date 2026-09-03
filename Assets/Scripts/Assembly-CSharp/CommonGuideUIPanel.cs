using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CommonGuideUIPanel : MediatorCtrlBase
{
	public class TimeLineGuideButton : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CHasClick_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineGuideButton _003C_003E4__this;

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
			public _003CHasClick_003Ed__5(int _003C_003E1__state)
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

		private GuideNoMaskCtrl ctrl;

		private ButtonCtrl[] Btns;

		public bool isClicked;

		public TimeLineGuideButton(string panelName, string btnpath, LocalSave.GuideMaskType maskType, int order = 1)
		{
		}

		private void Click()
		{
		}

		[IteratorStateMachine(typeof(_003CHasClick_003Ed__5))]
		private IEnumerator HasClick()
		{
			return null;
		}
	}

	public class TimeLineGuideDiglogueItem : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CHasEnd_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineGuideDiglogueItem _003C_003E4__this;

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
			public _003CHasEnd_003Ed__2(int _003C_003E1__state)
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

		private DiglogueItem diglogueItem;

		public TimeLineGuideDiglogueItem(DiglogueItem item, int position, int name, string content, string picName)
		{
		}

		[IteratorStateMachine(typeof(_003CHasEnd_003Ed__2))]
		private IEnumerator HasEnd()
		{
			return null;
		}
	}

	public class TimeLineGuideEvent : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CHasEnd_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineGuideEvent _003C_003E4__this;

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
			public _003CHasEnd_003Ed__3(int _003C_003E1__state)
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

		private CommonGuideManager.CommonGuideData guideData;

		private int step;

		public TimeLineGuideEvent(CommonGuideManager.CommonGuideData data, int step)
		{
		}

		[IteratorStateMachine(typeof(_003CHasEnd_003Ed__3))]
		private IEnumerator HasEnd()
		{
			return null;
		}
	}

	public GameObject bgmask;

	private TimeLineContainer timeLine;

	private CommonGuideManager.CommonGuideData guideData;

	private DiglogueItem diglogueItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
