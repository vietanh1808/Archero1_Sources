using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Guild.Data;
using UnityEngine;
using UnityEngine.UI;

public class GuildActivityUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CDelayRequest_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuildActivityUICtrl _003C_003E4__this;

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
		public _003CDelayRequest_003Ed__63(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CTick_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuildActivityUICtrl _003C_003E4__this;

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
		public _003CTick_003Ed__62(int _003C_003E1__state)
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
	private DxxText txtTitleInfo;

	[SerializeField]
	private DxxText txtInfo;

	[SerializeField]
	private DxxText txtTimeLeft;

	[SerializeField]
	private DxxText txtSubmitRecordTitle;

	[SerializeField]
	private DxxText txtSubmitProgressTitle;

	[SerializeField]
	private DxxText txtOwnedItemTitle;

	[SerializeField]
	private DxxText txtRewardInfo;

	[SerializeField]
	private DxxText txtRewardNum;

	[SerializeField]
	private DxxText txtBtnSubmit;

	[SerializeField]
	private DxxText txtRankingEmptyTip;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnInfo;

	[SerializeField]
	private ButtonCtrl btnSubmit;

	[SerializeField]
	private ButtonCtrl btnCloseInfo;

	[SerializeField]
	private ButtonCtrl btnChestLeft;

	[SerializeField]
	private ButtonCtrl btnChestRight;

	[SerializeField]
	private GameObject goInfoRoot;

	[SerializeField]
	private GuildActivityRankInfinity infinity;

	[SerializeField]
	private GuildActivityRankItem selfRank;

	[SerializeField]
	private RectTransform rtMaterials;

	[SerializeField]
	private RectTransform rtMyMaterials;

	[SerializeField]
	private GuildActivityMaterialItem materialTemplate;

	[SerializeField]
	private GuildActivityChestItem chestTemplate;

	[SerializeField]
	private RectMask2D _mask2D;

	[SerializeField]
	private int cellsize;

	[HideInInspector]
	public int curIndex;

	private LocalUnityObjctPool pool;

	private ActivityContributionRankingData rankingDataCache;

	private float srWidthTotal;

	private float bossScale;

	private float lastUnlockedRatio;

	[SerializeField]
	private float progressBarRatio;

	private int activityId;

	private int giftIdShown;

	private int bossId;

	private List<int> materialIds;

	private Dictionary<int, int> materialRequirements;

	private Dictionary<int, int> temp;

	private int currentBossId;

	private int lockedIndex;

	public DxxText Text_BoxLevel;

	public DxxText Text_TabBox;

	public DxxText Text_TabRecord;

	public GameObject Tab_BoxFocus;

	public GameObject Tab_RecordFocus;

	public GuildActivityChestItem chestItem;

	public int currentTab;

	public GameObject Panel_Progress;

	public GameObject Panel_Rank;

	private float maskHalfWidth => 0f;

	private float unitRatio => 0f;

	protected override void OnInit()
	{
	}

	private void SetProgressBar(Vector2 vec)
	{
	}

	private void RegisterButtons()
	{
	}

	public void MoveToIndex(int index)
	{
	}

	private void UpdateRankItem(int index, GuildActivityRankItem item)
	{
	}

	private List<ActivityContributionRankingData.ActivityRankItem> GenContributionItems(ActivityContributionRankingData.ActivityRankItem[] rawItems)
	{
		return null;
	}

	protected override void OnOpen()
	{
	}

	private void RequestActivityInfo()
	{
	}

	private void RequestRanking()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	[IteratorStateMachine(typeof(_003CTick_003Ed__62))]
	private IEnumerator Tick()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayRequest_003Ed__63))]
	private IEnumerator DelayRequest()
	{
		return null;
	}

	private void android_escape()
	{
	}

	private void Submit()
	{
	}

	private void OnSubmitResponse(MessageEventData<SubmitActiveItemData> response)
	{
	}

	private void SetMaterials()
	{
	}

	private void SetChestsAndScroll()
	{
	}

	private int GetIndexDefault()
	{
		return 0;
	}

	private void GenChests(int count)
	{
	}

	private string GetBodyString(string id)
	{
		return null;
	}

	private void SetBossModel()
	{
	}

	private void SetRankings()
	{
	}

	private void GetBossInfo()
	{
	}

	private void GetRequirementInfo()
	{
	}

	public void onButtonTab(int tab)
	{
	}
}
