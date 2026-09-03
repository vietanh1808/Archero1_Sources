using System;
using UnityEngine;

public class SailingBpStageItem : MonoBehaviour
{
	public DxxImage stageIcon;

	public GameObject lockIcon;

	public DxxText stageName;

	public GameObject goProcess;

	public GameObject goMask;

	public GameObject goRed;

	public ParticleSystem effect;

	public ButtonCtrl btn_Stage;

	private int _crtStage;

	public void Init(int stage, Action<int> onClick)
	{
	}

	public void RefreshRed()
	{
	}

	public void SetStageStatus(int targetStage)
	{
	}

	public void PlayAni(int stage)
	{
	}
}
