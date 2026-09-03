using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattleLevelUICtrl : MediatorCtrlBase
{
	public class SkillButtonVO
	{
		public Transform ActivatedTrans;

		public bool Visible;
	}

	[CompilerGenerated]
	private sealed class _003C_CheckChangeWeaponCondition_003Ed__171 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleLevelUICtrl _003C_003E4__this;

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
		public _003C_CheckChangeWeaponCondition_003Ed__171(int _003C_003E1__state)
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
	private sealed class _003C_CheckSuperSkillCondition_003Ed__169 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleLevelUICtrl _003C_003E4__this;

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
		public _003C_CheckSuperSkillCondition_003Ed__169(int _003C_003E1__state)
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

	private LevelProgressTip lvProgressTip;

	public ButtonCtrl mSuperSkillBtn;

	private ButtonCtrl _mWuKongSuperSkillBtn;

	[SerializeField]
	private Image mSuperSkillImg;

	[SerializeField]
	private Image mWuKongSuperSkillImg;

	public Image mSuperSkillCDImg;

	private Image _mWuKongSuperSkillCDImg;

	[SerializeField]
	private Image mChangeWeaponImg;

	[SerializeField]
	private ButtonCtrl mChangeWeaponBtn;

	private ButtonCtrl _btnCancelDisguise;

	public ButtonCtrl Button_Pause;

	public ButtonCtrl Button_KillAll;

	public BattleExpCtrl mExpCtrl;

	public BattleBossHPCtrl mHPCtrl;

	[SerializeField]
	private BattleBossHPCtrl mHellHPCtrl;

	public BattleGoldCtrl mGoldCtrl;

	public GameObject copyitems;

	public GameObject copyGold;

	public RectTransform Image_Gold;

	public BattleLevelAchieveCtrl mAchieveCtrl;

	public Transform challenge_parent;

	public DxxText Text_TestLayer;

	public DxxText Text_Level;

	public DxxText Text_GameType5Level;

	public BabySkillUICtrl BabySkillParent;

	[SerializeField]
	private ArtifactCtrl _artifactCtrl;

	[SerializeField]
	private GameObject artifactWaveParent;

	[SerializeField]
	private DxxText artifactWaveText;

	private float deltaTime;

	private ActionUpdateCtrl mActionUpdateCtrl;

	protected BattleLevelWaveCtrl mLevelWaveCtrl;

	private BattleDailyWaveCtrl mDailyWaveCtrl;

	private BattleDailySurvivalWaveCtrl mDailySurvivalWaveCtrl;

	private Sequence seq_levelup;

	private int levelupCount;

	private Tweener tGold;

	private List<long> getgoldlist;

	private bool bGoldAniPlaying;

	private bool m_bCdFlag;

	private float CONFIG_CD_TIME;

	private float CONFIG_EXTRA_CD_TIME;

	private float WuKongTotalCDTime;

	private float m_fCDTime;

	private float m_fExtraCDTime;

	private float m_fWuKongCDTime;

	private bool _m_bShowSuperSkillFlag;

	private bool m_bIsExtraSuperSkill;

	private bool m_bShowWuKongSuperSkillFlag;

	private bool m_bLastRoomIsBossRoom;

	private RoomGenerateBase.Room m_currentRoom;

	private int m_nOffMusicRoomId;

	private LocalUnityObjctPool mObjPool;

	[SerializeField]
	private Transform m_alertParent;

	[SerializeField]
	private AlertOneCtrl m_alertCopyOne;

	[SerializeField]
	private ToxifogAlertCtrl _toxifogAlertCtrl;

	private ToxifogAlertCtrl[] _vecToxifogAlertCtrls;

	private LocalUnityObjctPool mAlertPool;

	[SerializeField]
	private RelicsSkillUICtrl mRelicsSkillUICtrl;

	private LanceSkillBtnCtrl lanceSkillBtnCtrl;

	private TridentSkillBtnCtrl tridentSkillBtnCtrl;

	private HammerSkillBtn hammerSkillBtn;

	private PetSkillBtnGroup petSkillBtnGroup;

	[Header("战斗速度")]
	[SerializeField]
	private ButtonCtrl _btnSpeed;

	[SerializeField]
	private Image _imgSpeed;

	private List<float> _listAllSpeeds;

	private int _nCurSpeedIndex;

	[Header("迷雾")]
	[SerializeField]
	private GameObject _goVisionMist;

	[SerializeField]
	private DxxText _textVisionCD;

	[SerializeField]
	private DxxText _textVisionCDTips;

	private GameObject artifact101CastIcon;

	private const float SUPER_SKILL_HEIGHT = -420f;

	private const float CHANGE_WEAPON_HEIGHT = -565f;

	private const float CANCEL_DISGUISE_HEIGHT = -565f;

	private DragonMagicInGameCtrl dragonCtrl;

	private BattleAssistantUICtrl m_battleAssistantUICtrl;

	[HideInInspector]
	public ButtonCtrl mWuKongSuperSkillBtn => null;

	[HideInInspector]
	public Image mWuKongSuperSkillCDImg => null;

	public ButtonCtrl btnCancelDisguise => null;

	private bool m_bShowSuperSkillFlag
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual bool CanShowSpeedBtn => false;

	private bool CanShowSpeedInLevel => false;

	protected virtual Transform GetDailyWaveParent => null;

	protected virtual bool PlayBgmCondition => false;

	private void UpdateVisionMistCd()
	{
	}

	protected override void OnInit()
	{
	}

	private void InitBattleSpeed()
	{
	}

	private void UpdateSpeedBtn()
	{
	}

	private void RefreshWaveData(int cur, int maxWave)
	{
	}

	private void OnClickSpeedBtn()
	{
	}

	public void AlignWuKongSuperSkillBtn(bool leftAligned = true)
	{
	}

	public void AlignSuperSkillBtn(bool leftAligned = true)
	{
	}

	public void AlignChangeWeaponBtn(bool leftAligned = true)
	{
	}

	public void AlignCancelDisguise(bool leftAligned = true)
	{
	}

	protected override void OnOpen()
	{
	}

	private void CreateAlertCache()
	{
	}

	private void OnSuperWuKongSkillEndAction()
	{
	}

	private void InitRelicsSkillUI()
	{
	}

	private void InitArtifactWaveText()
	{
	}

	private void Track()
	{
	}

	private void OnEnergyMaxChange()
	{
	}

	protected virtual int GetRoomId()
	{
		return 0;
	}

	protected virtual void InitUI()
	{
	}

	protected virtual void InitDragonMagicInGameCtrl()
	{
	}

	private void init_level_wave()
	{
	}

	private void InitDailyWave()
	{
	}

	private void InitDailySurvivalWave()
	{
	}

	private void init_tower_wave()
	{
	}

	private void init_event_tower_wave()
	{
	}

	private void Init_Survival_Wave()
	{
	}

	private void OnLanceChangeState(bool isCannon)
	{
	}

	private void OnTridentChangeState(bool isDagger)
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnAngerOver()
	{
	}

	protected virtual void ShowBossHP(bool show)
	{
	}

	private void OnClickPause()
	{
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void UpdateToxifogAlert()
	{
	}

	private void refreshGameType5Level()
	{
	}

	private bool SetSuperSkillBtnVisible()
	{
		return false;
	}

	private bool SetWuKongSuperSkillBtnVisible()
	{
		return false;
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void PlayBgm(RoomGenerateBase.Room room = null)
	{
	}

	private void RefreshDebugInfo()
	{
	}

	private void StartGame()
	{
	}

	private void OnCloseLevelUpUI()
	{
	}

	private void OpenLevelUpUI()
	{
	}

	private void CacheGoldText(MainUIGoldAddCtrl ctrl)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	protected virtual void UpdateGold()
	{
	}

	protected void onCreateDragonCtrl(DragonVO vo, bool startTimer = false)
	{
	}

	protected virtual void tryShowLevelProgress()
	{
	}

	private void createLvProgressTip()
	{
	}

	protected void CreateAssistantBtn()
	{
	}

	private void OnClickAssistantBtn(int id)
	{
	}

	protected virtual void LevelUp()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected virtual void OnApplicationQuit()
	{
	}

	protected void SetSuperBtnState()
	{
	}

	protected void SetWuKongSuperBtnState()
	{
	}

	public void SetSkillCDImgVisible()
	{
	}

	public void SetWuKongSkillBtnEnable(bool enabled)
	{
	}

	protected virtual bool GetBtnShow()
	{
		return false;
	}

	protected virtual bool GetBtnWuKongShow()
	{
		return false;
	}

	protected virtual void UpdateCD()
	{
	}

	protected void SetCDTime(float time)
	{
	}

	protected void SetExtraCDTime(float time)
	{
	}

	protected void SetWuKongTotalCDTime(float time)
	{
	}

	protected virtual void OnClick()
	{
	}

	private void OnClickWuKongSuperSkillBtn()
	{
	}

	private void OnSuperSkillEnd()
	{
	}

	protected virtual void OnClickChangeWeaponBtn()
	{
	}

	private void updateWuKongCD(float delta)
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	private void UpdateSuperSkillCDTime(float delta)
	{
	}

	private void updateSuperSkillCD(ref float destCDTime, float cdTime)
	{
	}

	private void UpdateAlert()
	{
	}

	protected virtual void CheckSuperSkillCondition()
	{
	}

	[IteratorStateMachine(typeof(_003C_CheckSuperSkillCondition_003Ed__169))]
	private IEnumerator _CheckSuperSkillCondition()
	{
		return null;
	}

	protected virtual void CheckChangeWeaponCondition()
	{
	}

	[IteratorStateMachine(typeof(_003C_CheckChangeWeaponCondition_003Ed__171))]
	private IEnumerator _CheckChangeWeaponCondition()
	{
		return null;
	}

	private void SetChangeWeaponBtnVisible(bool show)
	{
	}

	protected virtual List<int> GetSelfEquipIds()
	{
		return null;
	}

	private void SetHammerSkillBtnState()
	{
	}

	private void SetHammerSkillBtnVisible(bool canShow)
	{
	}

	private void AlignHammerSkillBtn(bool leftAligned = true)
	{
	}

	private void SetLanceSkillBtnState()
	{
	}

	private void SetLanceSkillBtnVisible(bool canShow)
	{
	}

	private void AlignLanceSkillBtn(bool leftAligned = true)
	{
	}

	private void SetTridentSkillBtnState()
	{
	}

	private void SetTridentSkillBtnVisible(bool canShow)
	{
	}

	private void AlignTridentSkillBtn(bool leftAligned = true)
	{
	}

	protected virtual void SetPetSkillBtnGroupState()
	{
	}

	private void SetPetSkillBtnGroupVisible(bool canShow, Action loadEnd)
	{
	}

	private void AlignPetSkillBtnGroupBtn(bool leftAligned = true)
	{
	}

	private void SetArtifact101IconVisible(bool canShow)
	{
	}

	private void RefreshArtifact101CastIconPos()
	{
	}
}
