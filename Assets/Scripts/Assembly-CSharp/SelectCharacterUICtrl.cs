using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CLoadModel_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SelectCharacterUICtrl _003C_003E4__this;

		private IList<PlayerCharacter_Character> _003Clist_003E5__2;

		private int _003Ci_003E5__3;

		private ResourceRequest _003Crequest_003E5__4;

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
		public _003CLoadModel_003Ed__56(int _003C_003E1__state)
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

	private const float modelDistance = 200f;

	private const float reboundTime = 0.15f;

	private const float modelMaxScale = 120f;

	private const float modelMinScale = 100f;

	private float modelPosXMax;

	public Transform modelParent;

	public DxxText descText;

	public DxxText hasSelectText;

	public DxxText selectBtnText;

	public DxxText buyPriceText;

	public DxxText chapterUnLockText;

	public DxxText purchasePriceText;

	public Image priceIconImage;

	public ButtonCtrl btnBuy;

	public ButtonCtrl btnSelect;

	public ButtonCtrl btnClose;

	public SelectCharacter_Skill copySkill;

	public Transform skillParent;

	public ButtonCtrl btnGet;

	public DxxText getText;

	public GameObject copyModelParent;

	public DxxText propertyTitleText;

	public DxxText propertyText;

	public DxxText nameText;

	public Transform modelShowParent;

	public UITextTips tips;

	public ScrollIntCharacterModelCtrl m_scroll;

	public GameObject copyOne;

	public Transform scrollChild;

	public ButtonCtrl btnUpgrade;

	public DxxText upgradeText;

	public GridLayoutGroup heroCardRoot;

	public HeroCardOneCtrl copyCard;

	public GameObject heroCardCache;

	private int curSelectIndex;

	private List<int> updateCharacterIndex;

	private int totalCharacterCount;

	private List<SelectCharacter_Skill> skillList;

	private Transform[] modelArray;

	private PlayerCharacter_Character[] dataArray;

	private Transform[] showModelArray;

	private SelectCharacterData m_CharData;

	private bool bChangeHero;

	private bool upgrade_open;

	private float btnSelectx;

	private float textSelectx;

	private LocalUnityObjctPool heroCardPool;

	protected override void OnInit()
	{
	}

	private void InitText()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void refresh_upgrade_open()
	{
	}

	private void RefreshDesc(CharacterModelOneCtrl one)
	{
	}

	private void update_buy_button_text()
	{
	}

	private void show_upgrade_button(bool value)
	{
	}

	private void RefreshBottomButton()
	{
	}

	public override void OnLanguageChange()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadModel_003Ed__56))]
	private IEnumerator LoadModel()
	{
		return null;
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	private void OnPointerUp(SelectCharacter_Skill skillCom, object arg)
	{
	}

	private void OnPointerDown(SelectCharacter_Skill skillCom, object arg)
	{
	}

	private void OnClickSelect()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickBuy()
	{
	}

	private void OnConfirmBuy(PlayerCharacter_Character tableData)
	{
	}

	private void UpdateOne(int index, CharacterModelOneCtrl one)
	{
	}

	private void UpdateSize(int index, CharacterModelOneCtrl one)
	{
	}

	private void OnScrollEnd(int index, CharacterModelOneCtrl one)
	{
	}

	private void OnBeginDrag()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void InitHeroCard()
	{
	}

	private void UpdateHeroCardInfo()
	{
	}

	private void DeInitHeroCard()
	{
	}
}
