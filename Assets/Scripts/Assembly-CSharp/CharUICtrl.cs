using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

public class CharUICtrl : MediatorCtrlBase
{
	public enum CharEventType
	{
		none = 0,
		dragonUI = 1,
		hero = 2
	}

	public class ShowCharEvent
	{
		public CharEventType type;
	}

	public enum UIState
	{
		eNormal = 0,
		eWear = 1,
		eWearing = 2,
		eEmptyWearing = 3
	}

	[CompilerGenerated]
	private sealed class _003CWaitClose_003Ed__186 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharUICtrl _003C_003E4__this;

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
		public _003CWaitClose_003Ed__186(int _003C_003E1__state)
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
	private sealed class _003CrebuildAttributeUI_003Ed__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharUICtrl _003C_003E4__this;

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
		public _003CrebuildAttributeUI_003Ed__154(int _003C_003E1__state)
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
	private sealed class _003CrefreshAttackValue_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public long num_2;

		public long num_1;

		public long step;

		public DxxText text;

		private long _003Coffset_003E5__2;

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
		public _003CrefreshAttackValue_003Ed__152(int _003C_003E1__state)
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
	private sealed class _003CrefreshHpValue_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public long num_2;

		public long num_1;

		private long _003Coffset_003E5__2;

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
		public _003CrefreshHpValue_003Ed__153(int _003C_003E1__state)
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

	public GameObject window;

	[Tooltip("标题")]
	public UILineCtrl mLineCtrl;

	public DxxText Text_MyCollections;

	public RectTransform Rt_Attribute;

	public RectTransform Rt_left_Attribute;

	public RectTransform Rt_right_Attribute;

	public DxxText Text_Attribute;

	public DxxText Text_AttackPre;

	public DxxText Text_Attack;

	public DxxText Text_HpPre;

	public DxxText Text_Hp;

	public RectTransform mCollectionsParent;

	public ButtonCtrl Button_Close;

	[Header("装备位")]
	public List<EquipBGCtrl> mEquipBGList;

	public VerticalLayoutGroup Left;

	public VerticalLayoutGroup Right;

	public RectTransform bottom;

	public ScrollRectBase mScrollRectBase;

	public MainUIScrollRectInsideCtrl mInsideCtrl;

	public RectTransform board;

	public RectTransform bagParent;

	public GameObject copyitems;

	public RectTransform mHeroContainer;

	public CharUIHeroCtrl mHeroCtrl;

	public WindowButtonCtrl Button_Combine;

	public DxxText Text_Combine;

	public CharSortCtrl mSortCtrl;

	public ButtonCtrl Button_Bag;

	public DxxText Text_Bag;

	public GameObject RedPoint_Bag;

	public RectTransform BagContainer;

	public UILineCtrl mMaterialLineCtrl;

	public UILineCtrl fragmentBagLineCtrl;

	public UILineCtrl GemsBagLineCtrl;

	public UILineCtrl relicsBagLineCtrl;

	public ButtonCtrl Button_Light;

	public CharEquipChooseCtrl mChooseCtrl;

	[Header("穿戴时的装备显示位置")]
	public Transform wearctrlpos;

	public GameObject RedPoint_Combine;

	public RectTransform charBg;

	private GameObject _equipitem;

	public CharUIScrollView mCharUIScrollView;

	private const int ColumnCount = 5;

	private const int EquipWidth = 140;

	private const int EquipHeight = 140;

	private const float BottomHeight = 100f;

	private float AllHeight;

	private List<EquipOneCtrl> mEquipItemList;

	private MutiCachePool<EquipOneCtrl> mCachePool;

	private Sequence seq;

	private float scrollendpos;

	private Vector2 collisionpos;

	private Vector2 bagparentpos;

	private SelfAttributeData mAttributeData;

	private EquipOneCtrl mClickEquip;

	private bool bGuide1;

	private EquipOneCtrl _WearCtrl;

	private float fringeHeight;

	private bool bOpened;

	public CharUISelectCharCtrl mSelectCharCtrl;

	public WindowButtonCtrl Button_Gem;

	private bool isGuiderRunning;

	public GameObject GemRedPoint;

	public ButtonCtrl btn_dragon;

	public Image image_dragon;

	public Image image_dragon_bg;

	public Image image_dragon_rarity;

	public GameObject DragonRedPoint;

	public ButtonCtrl btn_imprint;

	public Image image_imprint_bg;

	public DxxText text_belieflevel;

	public GameObject ImprintRedPoint;

	public Transform levelEffectObj;

	public GameObject BtnsParent;

	public GameObject GemsNewEntance;

	public GameObject PlayerNewEntance;

	public GameObject PetNewEntance;

	public GameObject DragonNewEntance;

	public GameObject ImprintNewEntance;

	public GameObject WingNewEntance;

	public GameObject ArtiNewEntance;

	public ButtonCtrl GemsNewBtn;

	public ButtonCtrl PlayerNewBtn;

	public ButtonCtrl PetNewBtn;

	public ButtonCtrl DragonNewBtn;

	public ButtonCtrl ImprintNewBtn;

	public ButtonCtrl WingNewBtn;

	public ButtonCtrl ArtiNewBtn;

	public RedNodeCtrl PlayerNewRed;

	public GameObject levelupnode;

	public GameObject PetNewRed;

	public GameObject DragonNewRed;

	public GameObject ImprintNewRed;

	public GameObject WingNewRed;

	public GameObject ArtiNewRed;

	public DxxText GemsNewTex;

	public DxxText PlayerNewTex;

	public DxxText PetNewTex;

	public DxxText DragonNewTex;

	public DxxText ImprintNewTex;

	public DxxText WingNewTex;

	public DxxText ArtiNewTex;

	public GameObject GemsNewUnLock;

	public GameObject PlayerNewUnLock;

	public GameObject PetNewUnLock;

	public GameObject DragonNewUnLock;

	public GameObject ImprintNewUnLock;

	public GameObject WingNewUnLock;

	public GameObject ArtiNewUnLock;

	public GameObject GemsNewLock;

	public GameObject PlayerNewLock;

	public GameObject PetNewLock;

	public GameObject DragonNewLock;

	public GameObject ImprintNewLock;

	public GameObject WingNewLock;

	public GameObject ArtiNewLock;

	private UIState state;

	private RectTransform m401Or402Equip;

	private RectTransform mMagicBookEquip;

	private RectTransform mFirstEquip;

	private LocalSave.EquipOne mEquipOne;

	[Header("装备存储页")]
	public EquipStoragePageEntrance storageEntrance;

	private float lastframey;

	private Coroutine closeIEnumerator;

	private bool stoneBuyTrigger;

	private static DelegateBridge __Hotfix0_get_equipitem;

	private static DelegateBridge __Hotfix0_get_mWearCtrl;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_refreshDragon;

	private static DelegateBridge __Hotfix0_showwindow;

	private static DelegateBridge __Hotfix0_OnSetArgs;

	private static DelegateBridge __Hotfix0_InitCachePool;

	private static DelegateBridge __Hotfix0_OnShowTabEvent;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_get_canShowDragon;

	private static DelegateBridge __Hotfix0_get_canShowDragonRedDot;

	private static DelegateBridge __Hotfix0_check_401_or_402_equip_guide;

	private static DelegateBridge __Hotfix0_check_magic_book_equip_guide;

	private static DelegateBridge __Hotfix0_check_character_open;

	private static DelegateBridge __Hotfix0_check_first_equip;

	private static DelegateBridge __Hotfix0_UpdateHero;

	private static DelegateBridge __Hotfix0_GetEquipOrder;

	private static DelegateBridge __Hotfix0_UpdateEquipsList;

	private static DelegateBridge __Hotfix0_OnCreateItem;

	private static DelegateBridge __Hotfix0_createEquipLine;

	private static DelegateBridge __Hotfix0_GetHeight;

	private static DelegateBridge __Hotfix0_InitWears;

	private static DelegateBridge __Hotfix0_UpdateAttribute;

	private static DelegateBridge __Hotfix0_refreshAttackValue;

	private static DelegateBridge __Hotfix0_refreshHpValue;

	private static DelegateBridge __Hotfix0_rebuildAttributeUI;

	private static DelegateBridge __Hotfix0_SetScrollEnable;

	private static DelegateBridge __Hotfix0_InitChooseCtrl;

	private static DelegateBridge __Hotfix0_ChooseUIShow;

	private static DelegateBridge __Hotfix0_OnClickWearAdd;

	private static DelegateBridge __Hotfix0_UpdateChooseEquip;

	private static DelegateBridge __Hotfix0_checkIfDragonEquip;

	private static DelegateBridge __Hotfix0_UpdateChooseCardScrollView;

	private static DelegateBridge __Hotfix0_OnUpdate;

	private static DelegateBridge __Hotfix0_OnClickInfo;

	private static DelegateBridge __Hotfix0_UpgradeCallBack;

	private static DelegateBridge __Hotfix0_WearCallBack;

	private static DelegateBridge __Hotfix0_OnClickLevel;

	private static DelegateBridge __Hotfix0_OnClickWear;

	private static DelegateBridge __Hotfix0_OnClickUnwear;

	private static DelegateBridge __Hotfix0_OnWearBreakDown;

	private static DelegateBridge __Hotfix0_OnUnwearBreakDown;

	private static DelegateBridge __Hotfix0_ChangeState;

	private static DelegateBridge __Hotfix0_UpdateWear;

	private static DelegateBridge __Hotfix0_DoWearAction;

	private static DelegateBridge __Hotfix0_StopWearAction;

	private static DelegateBridge __Hotfix0_MissAdd;

	private static DelegateBridge __Hotfix0_ScrollPlayFade;

	private static DelegateBridge __Hotfix0_OnDragBegin;

	private static DelegateBridge __Hotfix0_OnDrag;

	private static DelegateBridge __Hotfix0_OnDragEnd;

	private static DelegateBridge __Hotfix0_OnClickScrollView;

	private static DelegateBridge __Hotfix0_GetScrolling;

	private static DelegateBridge __Hotfix0_update_combine_rednode;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_WaitClose;

	private static DelegateBridge __Hotfix0_KillSequence;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_update_levelup;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_onButtonGem;

	private static DelegateBridge __Hotfix0_onClickBtnDragon;

	private static DelegateBridge __Hotfix0_onDragonChanged;

	private static DelegateBridge __Hotfix0_onClickPlayerNewBtn;

	private static DelegateBridge __Hotfix0_OnDeInit;

	private static DelegateBridge __Hotfix0_freshBagUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	private GameObject equipitem => null;

	private EquipOneCtrl mWearCtrl => null;

	private bool canShowDragon => false;

	private bool canShowDragonRedDot => false;

	protected override void OnInit()
	{
	}

	private void refreshDragon()
	{
	}

	private void showwindow(bool value)
	{
	}

	protected override void OnSetArgs(object o)
	{
	}

	private void InitCachePool()
	{
	}

	private void OnShowTabEvent(object pObj)
	{
	}

	protected override void OnOpen()
	{
	}

	private void check_401_or_402_equip_guide()
	{
	}

	private void check_magic_book_equip_guide()
	{
	}

	private void check_character_open()
	{
	}

	private void check_first_equip()
	{
	}

	private void UpdateHero(bool changehero)
	{
	}

	private int GetEquipOrder(LocalSave.EquipOne e)
	{
		return 0;
	}

	private void UpdateEquipsList(bool changehero)
	{
	}

	private void OnCreateItem(int index, RectTransform t)
	{
	}

	private void createEquipLine(List<LocalSave.EquipOne> list, int index, int equipCnt, int imax, CharUICtrl self, float startx, float starty, LocalSave.EquipOne equipOne)
	{
	}

	private float GetHeight(int count, int perheight)
	{
		return 0f;
	}

	private void InitWears()
	{
	}

	private void UpdateAttribute()
	{
	}

	[IteratorStateMachine(typeof(_003CrefreshAttackValue_003Ed__152))]
	private IEnumerator refreshAttackValue(DxxText text, long num_1, long num_2, long step = 1L)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CrefreshHpValue_003Ed__153))]
	private IEnumerator refreshHpValue(long num_1, long num_2)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CrebuildAttributeUI_003Ed__154))]
	private IEnumerator rebuildAttributeUI()
	{
		return null;
	}

	private void SetScrollEnable(bool value)
	{
	}

	private void InitChooseCtrl()
	{
	}

	private void ChooseUIShow(bool show)
	{
	}

	private void OnClickWearAdd(int index)
	{
	}

	public void UpdateChooseEquip(EquipOneCtrl one)
	{
	}

	private bool checkIfDragonEquip(EquipOneCtrl oneCtrl)
	{
		return false;
	}

	private void UpdateChooseCardScrollView()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnClickInfo()
	{
	}

	private void UpgradeCallBack()
	{
	}

	private void WearCallBack()
	{
	}

	private void OnClickLevel()
	{
	}

	private void OnClickWear()
	{
	}

	private void OnClickUnwear()
	{
	}

	private void OnWearBreakDown()
	{
	}

	private void OnUnwearBreakDown()
	{
	}

	private void ChangeState(UIState state, bool force = false)
	{
	}

	private void UpdateWear(LocalSave.EquipOne equipdata)
	{
	}

	private void DoWearAction()
	{
	}

	private void StopWearAction()
	{
	}

	private void MissAdd()
	{
	}

	private Sequence ScrollPlayFade(bool show)
	{
		return null;
	}

	private void OnDragBegin(PointerEventData eventData)
	{
	}

	private void OnDrag(PointerEventData eventData)
	{
	}

	private void OnDragEnd(PointerEventData eventData)
	{
	}

	private void OnClickScrollView()
	{
	}

	private bool GetScrolling()
	{
		return false;
	}

	private void update_combine_rednode()
	{
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitClose_003Ed__186))]
	private IEnumerator WaitClose()
	{
		return null;
	}

	private void KillSequence()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void UpdateNet()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public void update_levelup()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void onButtonGem()
	{
	}

	private void onClickBtnDragon()
	{
	}

	private void onDragonChanged()
	{
	}

	private void onClickPlayerNewBtn()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void freshBagUI(bool show)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnSetArgs(object P0)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnDeInit()
	{
	}
}
