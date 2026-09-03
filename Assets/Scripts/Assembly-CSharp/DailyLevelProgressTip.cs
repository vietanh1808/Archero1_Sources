using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DailyLevelProgressTip : MonoBehaviour
{
	private const float TIP_MISS_TIME = 0.25f;

	private const string UPDATE_NAME = "LevelProgressTip-Update";

	public RectTransform c2_center;

	public RectTransform c2_event_level;

	public Slider slider1;

	public Slider slider2;

	public SingleLevelTip leftLevelTip;

	public SingleLevelTip centerLevelTip;

	public SingleLevelTip rightLevelTip;

	public SingleLevelTip futureEventTip;

	private float curAliveTime;

	private float appearTime;

	private float progressTime;

	private float aliveTime;

	private DailyLevelProgressTipVO TipVO;

	private bool isSecondRoomFromLast;

	private int dailyId;

	private int firstRoomId;

	private int maxRoomId;

	private bool isAppeared;

	private Sequence appearSeq;

	private Sequence missSeq;

	public void Init()
	{
	}

	private void DeInitRoom()
	{
	}

	private void setVisible(bool visible)
	{
	}

	public void DeInit()
	{
	}

	public void Refresh(int roomId)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void refreshSliders(bool isSecondFromLast, bool showSlider1Hand, bool showSlider2Hand)
	{
	}

	private string getIconStr(int curRoomId)
	{
		return null;
	}

	private void playAppearAnim()
	{
	}

	private void playMissAnim()
	{
	}

	private void playProgressAnim()
	{
	}

	private void killSeqs()
	{
	}

	public static bool IsSpecialRoom(RoomGenerateBase.RoomType roomType)
	{
		return false;
	}
}
