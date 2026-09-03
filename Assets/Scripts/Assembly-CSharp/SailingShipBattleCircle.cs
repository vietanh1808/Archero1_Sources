using System;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipBattleCircle : MonoBehaviour
{
	[SerializeField]
	private GameObject parent;

	[SerializeField]
	private Image circle;

	private float maxTime;

	private Func<float> leftTime;

	private bool isStart;

	private bool allowActive;

	public void SetActiveStatus(bool active)
	{
	}

	public void StartAni(float maxTime, Func<float> leftTime, SailingShipBattleCircleType circleType)
	{
	}

	public void StopAni()
	{
	}

	private void Update()
	{
	}

	private void RefreshFill(float progress)
	{
	}
}
