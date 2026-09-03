using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class MainUIPage4Ctrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CEnableScrollView_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPage4Ctrl _003C_003E4__this;

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
		public _003CEnableScrollView_003Ed__49(int _003C_003E1__state)
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

	public RectTransform titleparent;

	public RectTransform Service;

	public RectTransform Privacy;

	public DxxText Text_Setting;

	public ScrollRect mScrollView;

	public MainUIUserIDCtrl mUserIDCtrl;

	public DxxText Text_Version;

	public SettingMusicCtrl mMusicCtrl;

	public SettingSoundCtrl mSoundCtrl;

	public SettingLanguageCtrl mLanguageCtrl;

	public SettingQualityCtrl mQualityCtrl;

	public SettingProducterCtrl mProducterCtrl;

	public SettingHabbyIdCtrl mHabbyIdCtrl;

	public SettingReportCtrl mReportCtrl;

	public SettingServiceCtrl mServiceCtrl;

	public SettingPrivacyCtrl mPrivacyCtrl;

	public SettingInviteCodeCtrl mInviteCodeCtrl;

	public SettingFacebookCtrl mFacebookCtrl;

	public SettingIdfaCtrl mIdfaCtrl;

	public RectTransform IdfaParent;

	public RectTransform InviteCodeCtrl;

	public ButtonCtrl buttonClose;

	public ButtonCtrl Button_SettingDebug;

	public SettingBattleCtrl mBattleCtrl;

	public SettingHabitCtrl mHabitCtrl;

	public SettingEquipStorageCtrl mEquipStorageCtrl;

	public SettingWingSetting mWingSettingCtrl;

	public SettingShowKBCtrl mShowKBCtrl;

	[SerializeField]
	private SettingTargetFrameRate mSettingTargetFrameRate;

	[SerializeField]
	private GameObject mDelAccountContaner;

	[SerializeField]
	private DxxText mTextDelTitle;

	[SerializeField]
	private ButtonCtrl mBtnDelAccount;

	[SerializeField]
	private DxxText mTextDelAccount;

	[SerializeField]
	private SettingShopBoxTips shopBoxTips;

	[SerializeField]
	private SettingEffectWeaken effectWeakenStatus;

	private bool bOpened;

	private bool userid_showlong;

	[SerializeField]
	private GameObject CacheClearRoot;

	[SerializeField]
	private DxxText Text_CacheTitle;

	[SerializeField]
	private ButtonCtrl Button_CacheClear;

	[SerializeField]
	private DxxText Text_CacheTitleSub;

	[SerializeField]
	private GameObject AppleReviewPurchaseRoot;

	[SerializeField]
	private DxxText Text_AppleReviewPurchaseTitle;

	[SerializeField]
	private ButtonCtrl Button_AppleReviewPurchase;

	[SerializeField]
	private DxxText Text_AppleReviewPurchaseTitleSub;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableScrollView_003Ed__49))]
	private IEnumerator EnableScrollView()
	{
		return null;
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
