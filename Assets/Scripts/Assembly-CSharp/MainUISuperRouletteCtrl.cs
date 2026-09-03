using Dxx.Util;
using UnityEngine;

public class MainUISuperRouletteCtrl : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Roulette;

	public GameObject effect;

	public Transform ImgBG;

	public ParticleSystem rotEff;

	public Animator anim;

	private CanvasGroup ImgCanvas;

	private float UI_Alpha;

	public float alphaSpeed;

	private bool isRot;

	private float startRotTotal;

	private float endRotTotal;

	private float rotCount;

	private SequencePool mSeqPool;

	private void Awake()
	{
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override bool IsShow()
	{
		return false;
	}

	private void Show(bool value)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetRot(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	public void OnOpen()
	{
	}

	public new void OnClose()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}
}
