using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollCircle : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	public delegate void JoyTouchStart(JoyData data);

	public delegate void JoyTouching(JoyData data);

	public delegate void JoyTouchEnd(JoyData data);

	private const string TAG = "ScrollCircle";

	[CompilerGenerated]
	private static JoyTouchStart m_On_JoyTouchStart;

	[CompilerGenerated]
	private static JoyTouching m_On_JoyTouching;

	[CompilerGenerated]
	private static JoyTouchEnd m_On_JoyTouchEnd;

	public static Action OnDoubleClick;

	[SerializeField]
	private JoyNameType JoyType;

	private Dictionary<JoyNameType, string> JoyDic;

	protected Vector2 Origin;

	protected float mRadius;

	protected float mRadiusSmall;

	protected Transform child;

	protected Transform bgParent;

	protected Transform bgParengbgbg;

	protected Transform touch;

	protected Transform direction;

	private Vector3 StartPos;

	private bool bShowDirection;

	protected JoyData m_Data;

	private bool disable;

	public static bool keepStand;

	private bool touchdown;

	private Vector3 touchdownpos;

	private static bool TouchIn;

	private int mTouchID;

	private const float INTERNAL = 0.08f;

	private const float STRAIGHT_INTERNAL = 0.5f;

	private float lastSyncTime;

	private bool isDrag;

	private float fClickTime;

	private float ClickDelayTime;

	private Animator mAni_ScreenTouch;

	private bool bDrag;

	public GameObject GuideModeObj;

	[SerializeField]
	private CanvasGroup moveJoyCanvas;

	private float lastStopTime;

	private Vector3 pos_v;

	private float pos_w;

	private Vector3 pos_2;

	private Vector2 DealDrag_touchpos;

	private Vector2 DealDrag_touchpos1;

	private const bool JoyFollowTouch = false;

	public static event JoyTouchStart On_JoyTouchStart
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event JoyTouching On_JoyTouching
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event JoyTouchEnd On_JoyTouchEnd
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private Vector3 GetPos(Vector3 pos)
	{
		return default;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void OnPointerDown(Vector3 pos)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	private void on_point_up(PointerEventData eventData)
	{
	}

	public void CheckGuideMove()
	{
	}

	private void CheckMoveJoyCanvasStatus()
	{
	}

	private void SetMoveJoyStatus(bool isActive)
	{
	}

	private void DealDrag(Vector2 pos, bool updateui = true)
	{
	}
}
