using DG.Tweening;
using UnityEngine;

public class EventWindowCtrl : MonoBehaviour
{
	public WindowID windowID;

	protected GameObject shadow;

	private GoodsEventEmojiCtrl eMojiCtrl;

	private SphereCollider mSphere;

	private Sequence seq;

	private Animation ani;

	[SerializeField]
	protected bool bEvent;

	private bool bDelay;

	protected bool bOpenUI;

	private float delaystarttime;

	private float starttime;

	private float anispeed;

	protected virtual string MissAction => null;

	public bool IsWorking => false;

	private void Awake()
	{
	}

	protected virtual void OnInit()
	{
	}

	private void OnDestroy()
	{
	}

	private void KillSequence()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void ShowShadow()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	private void OnCollisionEnter(Collision o)
	{
	}

	private void Enter(GameObject o)
	{
	}

	protected virtual void OnEnter()
	{
	}

	protected virtual void OpenWindow()
	{
	}

	protected virtual void Miss()
	{
	}
}
