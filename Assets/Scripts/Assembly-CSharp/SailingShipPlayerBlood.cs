using UnityEngine;
using UnityEngine.UI;

public class SailingShipPlayerBlood : MonoBehaviour
{
	[SerializeField]
	private Image progressIcon;

	[SerializeField]
	private RectTransform progressRect;

	[SerializeField]
	private SailingShipPlayerBloodAni bloodAni;

	private const float BloodChangePercent = 0.25f;

	private float progressOriginWidth;

	private bool isInit;

	private float leftPercent;

	private bool isPlayAni;

	private bool isSelf;

	private void Init()
	{
	}

	public void Refresh(bool isSelf, float leftPercent, bool isPlayAni)
	{
	}

	private void RefreshIcon()
	{
	}

	private void RefreshProgress()
	{
	}

	public void RefreshProgressNotAni()
	{
	}

	private void RefreshProgressWithAni()
	{
	}
}
