using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class MainUIActivityShip : MonoBehaviour
{
	public RectTransform child;

	public RectTransform ship;

	public Transform target;

	public ButtonCtrl button;

	public DxxImage image1;

	public DxxImage image2;

	public GameObject time;

	public DxxText timeDesc;

	public DxxText timeText;

	private SequencePool mSeqPool;

	private Vector3 mSrcVec;

	private Vector3 mDesVec;

	private float startX;

	private float endX;

	private Sequence seq;

	private float countdown;

	private bool isEnter;

	private bool isExit;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void show()
	{
	}

	private void upDown(bool anim)
	{
	}

	public void hide()
	{
	}

	public void UpdateUI()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnOpen()
	{
	}

	public RectTransform GetTransform()
	{
		return null;
	}

	public void OnLanguageChange()
	{
	}
}
