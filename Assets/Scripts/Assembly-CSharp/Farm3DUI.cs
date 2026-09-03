using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farm3DUI : MonoBehaviour
{
	public enum VisitState
	{
		Unknown = 0,
		Visit = 1,
		Ad = 2,
		End = 3
	}

	public FarmRawImage farmRaw;

	private Farm3D farm3d;

	public GameObject MovePanel;

	public RedNodeCtrl redNode1;

	public RedNodeCtrl redNode2;

	public ButtonCtrl buttonNormal;

	public ButtonCtrl buttonBoss;

	public ButtonCtrl Button_Farm;

	public DxxText normalText;

	public DxxText bossText;

	public DxxText Text_Empty;

	public Color colorWhite;

	public Color colorGray;

	private TabFarm currentTab;

	private Camera UICamera;

	private const int defaultH = 160;

	private int talkMid;

	public GameObject talkNode;

	public DxxText Text_Story;

	private Transform talkTF;

	private int talkY;

	private float talkShowTime;

	private float talkRandomTime;

	public GameObject TalkZZZ;

	[HideInInspector]
	public Dictionary<int, FarmMoveData> farmMoveDict;

	private Dictionary<int, int> talkYDict;

	public GameObject Others;

	public GameObject Eggs;

	public ButtonCtrl Button_Msg;

	public ButtonCtrl Button_Visit;

	public DxxText Text_Msg;

	public GameObject visit;

	public DxxText Text_Visit;

	public DxxText Text_Count;

	public DxxText Text_NoCount;

	public DxxText Text_TimeToday;

	public AdsController ads;

	public Image Image_Ad;

	public DxxText Text_Ad;

	public DxxText Text_AdCount;

	public DxxText Text_BPFree;

	public FarmOtherEgg[] foegg;

	public FarmVisitBubble bubble;

	public GameObject bubbleRedP;

	public GameObject visitRedP;

	private VisitState vstate;

	public RectTransform Visit1;

	public RectTransform Visit2;

	public RectTransform Visiter;

	public ButtonCtrl Button_CleanAll;

	public DxxText Text_CleanAll;

	public void Awake()
	{
	}

	public void init()
	{
	}

	private void freshCleanAllInfo()
	{
	}

	private void freshVisitInfo()
	{
	}

	private void freshOtherEggs()
	{
	}

	private void freshBubble()
	{
	}

	private void onButtonNormal()
	{
	}

	private void onButtonBoss()
	{
	}

	private void initFarm(TabFarm tab)
	{
	}

	private void addMoveIcon()
	{
	}

	public void freshFarmEvent()
	{
	}

	private void checkTabRedPoint()
	{
	}

	public void OnClose()
	{
	}

	public void OnDestroy()
	{
	}

	private void randomTalk()
	{
	}

	public void Update()
	{
	}

	public void onClickFarmItem(int eventId)
	{
	}

	public void onFarmEventHandle(int eventId)
	{
	}

	private void RemoveEvent(int type, int eventId)
	{
	}

	public Vector3 World2Screen(Vector3 worldpos)
	{
		return default;
	}

	public void handleNotification(string key, object value)
	{
	}

	private string getEggFailText()
	{
		return null;
	}
}
