using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TradingAchievementUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003COnGetReward_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TradingAchievementUIPanel _003C_003E4__this;

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
		public _003COnGetReward_003Ed__24(int _003C_003E1__state)
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

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText MaxBloodTex;

	public DxxText crtPropertyText;

	public DxxText historyPropertyText;

	public DxxText MaxRewardLevel;

	public TradingAchievementRewardItem maxRewardItem;

	public RectTransform itemParent;

	public ButtonCtrl closeBtn;

	public TradingAchievementItem copyItem;

	public RectTransform Mask;

	public GameObject go_MaxHasGet;

	public ScrollRect scroll;

	private TradingAchievementItem[] items;

	private List<TradingAchRewardItemData> _dataList;

	private bool _isShowSpecial;

	private LocalUnityObjctPool _pool;

	private int _showSpecialIndex;

	private TradingAchRewardItemData maxData;

	private int _lastSpecialIndex;

	private int _lastItemShowIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void SetData()
	{
	}

	public void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003COnGetReward_003Ed__24))]
	public IEnumerator OnGetReward(List<Drop_DropModel.DropData> list, bool isLast)
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshList()
	{
	}

	public void RefreshSpecialIndex()
	{
	}

	public void OnScrollValueChanged()
	{
	}

	public void CheckMaxShow(bool isMax)
	{
	}

	public bool IsItemVisible(RectTransform item)
	{
		return false;
	}
}
