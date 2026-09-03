using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class EquipInfoUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CRebuild_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RectTransform t;

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
		public _003CRebuild_003Ed__84(int _003C_003E1__state)
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

	public const string AniMoveName = "CharEquipInfoMove";

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Upgrade;

	public ButtonCtrl Button_UpgradeOneClick;

	public ButtonCtrl Button_Refine;

	public ButtonCtrl Button_RelicFragmentInfo;

	public RectTransform equipparent;

	public DxxText Text_Info;

	public GoldTextCtrl mGoldTextCtrl;

	public ButtonCtrl Button_Mask;

	public RectTransform bg;

	public DxxText Text_IsMax;

	public UILineCtrl mTitleCtrl;

	public DxxText Text_Quality;

	public DxxText Text_Upgrade;

	public DxxText Text_UpgradeOneClick;

	public DxxText Text_Refine;

	public RectTransform Image_OutLine;

	public GameObject attributeParent;

	[SerializeField]
	private ScrollRect mScrollRect;

	[SerializeField]
	private RectTransform attrRootEquip;

	[SerializeField]
	private RectTransform attrRootRefine;

	public DxxText Text_Attribute;

	public Animator mAni;

	public RectTransform ButtonParent;

	public ButtonCtrl Button_Wear;

	public Image Image_ButtonWear;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Discount;

	public DxxText Text_Buy;

	public DxxText Text_Wear;

	public GoldTextCtrl mBuyGold;

	public GoldTextCtrl oldBuyGold;

	public GoldTextCtrl newBuyGold;

	public RectTransform redLine;

	public EquipInfoNeedCtrl mNeedCtrl;

	public List<GameObject> typeparent;

	public GameObject equipattparent;

	[SerializeField]
	private TotemPreviewItem totemPreview;

	[SerializeField]
	private VerticalLayoutGroup infoBg;

	[SerializeField]
	private RefineStarCtrl refineStarCtrl;

	[SerializeField]
	private CarvingSlotsCtrl carvingSlotsCtrl;

	public DxxText Text_EquipInfo;

	public DxxText Text_AttributeTitle;

	public DxxText Text_AttributeTitleRefine;

	public DxxText Text_MaterialTitle;

	public DxxText Text_BreakDown;

	public DxxText Text_EquipNum;

	public RectTransform Image_Attribute_Bg;

	public static readonly float preferedSize;

	public RectTransform ReferTrans;

	public RectTransform FollowTrans;

	public HorizontalLayoutGroup layoutGroup;

	private EquipOneCtrl _equipctrl;

	[SerializeField]
	private DxxText Text_MaterialNum;

	public Button Button_EquipDown;

	public Button Button_Skin;

	private BlackItemOnectrl _itemone;

	private RectTransform mRectTransform;

	private LocalSave.EquipOne mEquipData;

	private EquipInfoModuleProxy.Transfer mTransfer;

	private LocalUnityObjctPool mPool;

	private List<EquipInfoAttributeOne> mTexts;

	private int diamondforcoin;

	private bool bGoldBuy;

	private bool bScrollBuy;

	private bool bGoldEffect;

	private List<uint> mTransIds;

	public GameObject Gem_Panel;

	public ButtonCtrl Button_Gem;

	public DxxText Text_GemInsert;

	public Image[] Gem_BG;

	public Image[] Gem_Icon;

	private EquipOneCtrl mEquipCtrl => null;

	private BlackItemOnectrl itemone => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private void RefreshBreakTextFollow()
	{
	}

	private void update_equipinfo()
	{
	}

	private void type_show(int index, bool value)
	{
	}

	private float InitAttribute()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CRebuild_003Ed__84))]
	private IEnumerator Rebuild(RectTransform t)
	{
		return null;
	}

	private string GetAttributeBase(int index)
	{
		return null;
	}

	private string GetAttributeBase(int index, string strAttr, string strAdd)
	{
		return null;
	}

	private string GetAttributeBase(int index, SelfAttributeData selfAttributeShow)
	{
		return null;
	}

	private void InitNormalButton()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnGoldBuyCallback(int diamond)
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickUpgradeOneClick()
	{
	}

	private void UpgradeOneClick(int maxLevel, Equip_Upgrade curLevel)
	{
	}

	private void DealGoldBuyNotification()
	{
	}

	private void PlayLevelUp(int upgradeLevel)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void UpdateNet()
	{
	}

	private void UpdateButtonUpgrade()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	public void freshEquipDownButtons()
	{
	}

	public void onButtonEquipDown()
	{
	}

	public void onButtonSkinDown()
	{
	}
}
