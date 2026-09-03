using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleMeadowUICtrl : MediatorCtrlBase
{
	public Image image_tutorialHand;

	public Material GrayMat;

	public GameObject goGameMode;

	public GameObject goFormationMode;

	public ButtonCtrl Button_Save;

	public DxxText Text_Save;

	public ButtonCtrl Button_Exit;

	public ButtonCtrl Button_Surrender;

	public ButtonCtrl Button_Pause;

	public ButtonCtrl Button_Delete;

	public ButtonCtrl Button_Start;

	public ButtonCtrl Button_Recycle;

	public DxxText Text_Start;

	public DxxText Text_Time;

	public DxxText Text_Points;

	public ScrollRectBase MonsterListScrollRect;

	public RectTransform MonsterListContentTrans;

	public GameObject MonsterListItemPrefab;

	private float mapWidth;

	private float mapHeight;

	private MapCreator mapCreator;

	private bool isGameOver;

	private int currentDragInstanceId;

	private float disX;

	private float disY;

	private int frameCount;

	private const int killFrameCount = 3;

	private GameObject goDragCache;

	private bool playerPurpose;

	private const float LIST_HEIGHT = 240f;

	private float cellWidth;

	private float space;

	private bool CanMove => false;

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onRequestSaveFormationSuccess()
	{
	}

	private void onStageMonstersChanged()
	{
	}

	private void refreshBtnExit()
	{
	}

	private string getPoints(int curPoints)
	{
		return null;
	}

	private void onMonsterPointsChanged()
	{
	}

	private void onActiveMonsterPoolChanged()
	{
	}

	private void onGameStarted()
	{
	}

	private void onSelectedMonsterChanged()
	{
	}

	protected override void OnInit()
	{
	}

	private void onClick_Button_Recycle()
	{
	}

	private void onClick_Save()
	{
	}

	private void onClick_Exit()
	{
	}

	private void checkIfFormationChanged()
	{
	}

	private void exitGameInDenfenseScene()
	{
	}

	private void onClick_Button_Pause()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnStartDrag(PointerEventData eventData)
	{
	}

	private void ResetDragInfo()
	{
	}

	private void OnDrag(PointerEventData eventData)
	{
	}

	private void OnStopDrag(PointerEventData eventData)
	{
	}

	private void onValueChanged(Vector2 deltaChange)
	{
	}

	private void onClick_Button_Surrender()
	{
	}

	private void onClick_Button_Delete()
	{
	}

	private void onClick_Button_Start()
	{
	}

	private void createMonsterList()
	{
	}

	public int[] dc_getActiveIds()
	{
		return null;
	}

	private void refreshMonsterList()
	{
	}

	private void reposMonsterList()
	{
	}

	private GameObject getFirstMonsterItem()
	{
		return null;
	}

	private void checkPoolCount()
	{
	}

	private void createMonsterItem(LocalSave.MonsterData data)
	{
	}

	private void enableScroll(bool enabled)
	{
	}

	private void checkIfHaveTutorial()
	{
	}

	private void showDragHand()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void appQuitHandler()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}
}
