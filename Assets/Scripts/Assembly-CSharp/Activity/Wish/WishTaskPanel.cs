using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.Wish
{
	public class WishTaskPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WishTaskPanel _003C_003E4__this;

			private LanguageManager _003Clan_003E5__2;

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
			public _003CTick_003Ed__18(int _003C_003E1__state)
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

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtTitleDailyTask;

		[SerializeField]
		private DxxText txtDailyRefreshTime;

		[SerializeField]
		private RectTransform rtTaskRoot;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private WishTaskItem taskTemplate;

		[SerializeField]
		private ScrollRect srDaily;

		private LocalUnityObjctPool pool;

		public override void Init(IActivityUI ctrl)
		{
		}

		public override void Open()
		{
		}

		public void RefreshItems()
		{
		}

		private void RefreshDailyTasks()
		{
		}

		private void RecycleItems()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override bool Escape()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__18))]
		private IEnumerator Tick()
		{
			return null;
		}
	}
}
