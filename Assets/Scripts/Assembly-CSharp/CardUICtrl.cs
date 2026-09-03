using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CardUICtrl : MediatorCtrlBase
{
	public class ShowTabEvent
	{
		public CardUIType tab;
	}

	[CompilerGenerated]
	private sealed class _003CWaitClose_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardUICtrl _003C_003E4__this;

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
		public _003CWaitClose_003Ed__106(int _003C_003E1__state)
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

	private const int CountPerRow = 4;

	private const int CardWidth = 174;

	private const int CardHeight = 210;

	private const float TextContentDefaultHeight = 100f;

	public GameObject window;

	public DxxText Text_Content;

	public DxxText Text_Count;

	public RectTransform CurrentWindow;

	public ButtonGoldCtrl Button_Upgrade;

	public ButtonCtrl Button_BG;

	public RectTransform cardparent;

	public RectTransform randomobj;

	public CardInfoCtrl mInfoCtrl;

	public CardUpgradeCtrl mUpgradeCtrl;

	private List<LocalSave.CardOne> cards;

	private List<CardOneCtrl> mCardList;

	private LocalUnityObjctPool mPool;

	private Sequence s;

	private Sequence s_random;

	private int gold;

	private GameObject _carditem;

	private float cardparenty;

	private bool bInitOver;

	private const int SpeedDownCount = 20;

	private int lastrandomindex;

	private int currentcount;

	private int currentrandomid;

	private AnimationCurve curve;

	private LocalSave.CardOne randomcard;

	private bool bOpened;

	public GameObject Tab_Card_Invalid;

	public GameObject Tab_Rune_Invalid;

	public GameObject Tab_Altar_Invalid;

	public GameObject Tab_Relics_Invalid;

	public GameObject Tab_Totem_Invalid;

	public GameObject CardPanel;

	public GameObject RunePanel;

	private AltarPanel _altarPanel;

	private RelicsPanel _relicsPanel;

	private TotemPanel _totemPanel;

	public Text RuneTitleText;

	public Image RuneTitleImage;

	public GameObject RuneMenu;

	public Text RuneDescText;

	public GameObject RuneTempMenu;

	public ButtonCtrl CardBtn;

	public ButtonCtrl RuneBtn;

	public ButtonCtrl Button_Altar;

	public DxxText Text_Altar;

	public ButtonCtrl RelicsBtn;

	public DxxText Txt_Relics;

	public ButtonCtrl TotemBtn;

	public DxxText Txt_Totem;

	public GameObject[] RuneParents;

	public RuneOneCtrl RuneCtrl;

	private List<RuneOneCtrl> RuneCtrls;

	private int runeIndex;

	public RuneItemCtrl RuneItem;

	public RuneItemCtrl RuneTempItem;

	private List<RuneItemCtrl> RuneItems;

	private List<RuneItemCtrl> RuneTempItems;

	public ButtonCtrl Rune_Cancel;

	public ButtonCtrl Rune_Replace;

	public Text Text_Replace;

	public Text Text_Refine;

	public Text Text_RuneStone;

	public Image Icon_RuneStone;

	public ButtonGoldCtrl RefineBtn;

	public ButtonCtrl RuneInfoBtn;

	public DxxText RuneInfoBtnText;

	public RedNodeCtrl RuneInfoRed;

	public RedNodeCtrl RuneTabRed;

	public RedNodeCtrl RelicTabRed;

	public RedNodeCtrl TotemTabRed;

	public GameObject RuneInfoRoot;

	public Text TabCardText;

	public Text TabRuneText;

	public RectTransform RectTabButtons;

	private float yDelta;

	private bool _isOpenedTotemPanel;

	private Coroutine closeIEnumerator;

	private GameObject carditem => null;

	public CardUIType CurrentType { get; private set; }

	private AltarPanel altarPanel => null;

	private RelicsPanel relicsPanel => null;

	private TotemPanel totemPanel => null;

	protected override void OnInit()
	{
	}

	private void InitRune()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnShowTabEvent(object pData)
	{
	}

	private void ShowTab(CardUIType uiType, bool ifForce = false)
	{
	}

	private void ShowCard()
	{
	}

	private void ShowRune()
	{
	}

	private void showAltar(CardUIType pType)
	{
	}

	private void showRelics()
	{
	}

	private void showTotem()
	{
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitClose_003Ed__106))]
	private IEnumerator WaitClose()
	{
		return null;
	}

	private void showwindow(bool value)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void InitUI(bool delay = true)
	{
	}

	private int Sort(LocalSave.CardOne a, LocalSave.CardOne b)
	{
		return 0;
	}

	private void UpdateOne(int index)
	{
	}

	private void UpdateButton()
	{
	}

	private int GetCardIndex(LocalSave.CardOne one)
	{
		return 0;
	}

	private void OnClickBG()
	{
	}

	private void OnClickCardBtn()
	{
	}

	private void OnClickRuneBtn()
	{
	}

	private void ShowAltarTab(CardUIType pType)
	{
	}

	private void onClickButtonAltar()
	{
	}

	private void onClickBtnRelics()
	{
	}

	private void OnClickRuneInfo()
	{
	}

	private void OnClickCard(CardOneCtrl one)
	{
	}

	private void OnClickBtnTotem()
	{
	}

	private void OnGoldBuyCallback(int diamond)
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void DealGoldBuyNotification()
	{
	}

	private void ResetRandom()
	{
	}

	private void StartPlayRandom()
	{
	}

	private void PlayRandom()
	{
	}

	private void SetRandomPosition()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnRuneSelect(int index)
	{
	}

	private void OnRuneDiscardClick()
	{
	}

	private void OnRuneReplaceClick()
	{
	}

	private void OnRefineBtnClick()
	{
	}

	public void UpdateMenuItem(int index)
	{
	}

	public void UpdateRefineBtn()
	{
	}

	private void UpdateRuneInfoBtn()
	{
	}

	private void UpdateRuneInfoRed()
	{
	}

	public void UpdateRelicRed()
	{
	}

	public void UpdateTotemRed()
	{
	}

	public bool TryGetRuneIdByIndex(int index, out RuneGroup group)
	{
		group = null;
		return false;
	}

	private float GetScaler()
	{
		return 0f;
	}
}
