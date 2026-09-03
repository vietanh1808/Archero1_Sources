using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MeadowBattleCtrl : MonoBehaviour
{
	private enum BtnRewardEnum
	{
		None = 0,
		ShowGachaCoin = 1,
		ShowDiamond = 2,
		VIPFree = 3
	}

	public Image image_curDiamond;

	public Image image_curGachaCoins;

	public DxxText txt_curDiamond;

	public DxxText txt_curGachaCoins;

	public ButtonCtrl btn_curDiamond;

	public DxxText txt_boxlist_title;

	public ButtonCtrl btn_closeInfo;

	public DxxText txt_title;

	public DxxText txt_seasonEnd;

	public DxxText txt_monsterTitle;

	public DxxText txt_monsterInfo;

	public Slider slider;

	public DxxText txt_freeCount;

	public DxxText txt_payCount;

	public Image image_diamond;

	public DxxText txt_disableTip;

	public DxxText txt_countDown;

	public Image image_reward;

	public DxxText txt_rewardInfo;

	public WinMatchesRewardTip winMatchesRewardTip;

	public MBInstructionWindow instructionWindow;

	public ButtonCtrl Button_Play;

	public ButtonCtrl Button_DefensiveFormation;

	public ButtonCtrl Button_Reward;

	public ButtonCtrl Button_Leaderboard;

	public ButtonCtrl Button_Info;

	public DxxText Txt_Level;

	public DxxText Txt_Ranking;

	public DxxText Txt_Zone;

	public DxxText Txt_ZoneInfo;

	public DxxText Text_DefensiveFormation;

	public DxxText Text_Play;

	public DxxText Text_Leaderboard;

	public GameObject RewardMonsterItemPrefab;

	public GameObject RewardBoxItemPrefab;

	public ScrollRectBase scrollBoxList;

	public GameObject goRewardMonsterListContent;

	public GameObject goRewardBoxListContent;

	public GameObject goBoxContent;

	private float centerX;

	private Transform cacheItemTrans;

	private BtnRewardEnum curBtnRewardEnum;

	private ulong timeEndToday;

	private int timeID;

	private const float itemWidth = 100f;

	private const float space = 150f;

	private const int paddingLeft = 10;

	private float duration;

	private bool isGachaCoinEnough => false;

	private int CurDiamondCount => 0;

	private int TotalRewardBoxCount => 0;

	private void initTxts()
	{
	}

	public void init()
	{
	}

	private void refreshCurrencyInfo()
	{
	}

	private void OnDrag(PointerEventData obj)
	{
	}

	private void OnEndDrag(PointerEventData obj)
	{
	}

	private void OnStartDrag(PointerEventData obj)
	{
	}

	private void onListPosChanged(Vector2 arg0)
	{
	}

	private void onScroll()
	{
	}

	private void changeScale(float _curDeltaX, Transform _transform)
	{
	}

	private void checkIfHaveTutorial()
	{
	}

	private void refreshAll()
	{
	}

	private void refreshBattleCount()
	{
	}

	private void initButtonClicks()
	{
	}

	private void onClickCurDiamond()
	{
	}

	private void refreshGochaRewardInfo()
	{
	}

	private void refreshBtnReward()
	{
	}

	private void refreshBtnPlay()
	{
	}

	public void OnDestroy()
	{
	}

	private void refreshTimeCountdown()
	{
	}

	private void refreshSeasonEndTime()
	{
	}

	private void updateCountdownTime()
	{
	}

	private void refreshRankInfo()
	{
	}

	private void initRewardMonsterList()
	{
	}

	private void refreshRewardMonsterList()
	{
	}

	private void refreshRewardBoxList()
	{
	}

	private void initRewardBoxList()
	{
	}

	private void refreshBoxListPos(bool playAnim)
	{
	}

	private void refreshBoxListPosByBoxCount(int boxCount, bool playAnim)
	{
	}

	private int getFocusCount()
	{
		return 0;
	}

	private Transform getRewardBox(int index)
	{
		return null;
	}

	private float getSliderPercent()
	{
		return 0f;
	}

	private void refreshSlider(int len)
	{
	}

	private GameObject createRewardMonsterItemInstance()
	{
		return null;
	}

	private GameObject createRewardBoxItemInstance()
	{
		return null;
	}

	private void onClickInfo()
	{
	}

	private void onClickLeardboard()
	{
	}

	private void onClickReward()
	{
	}

	private void onClickDefensiveFormation()
	{
	}

	private void onClickPlay()
	{
	}

	public void OnClose()
	{
	}

	public void handleNotification(string key, object value)
	{
	}

	private void onPlayBoxScrollAnim()
	{
	}

	public void onRequest_MB_INFO_SUCCESS(STFarmPvpRespInfo data)
	{
	}

	private void onOpenWinBoxSuccess()
	{
	}

	private void onOpenGachaBoxSuccess()
	{
	}

	private void onShowWinMatchesRewardTip(Farm_VictoryReward _victoryReward)
	{
	}
}
