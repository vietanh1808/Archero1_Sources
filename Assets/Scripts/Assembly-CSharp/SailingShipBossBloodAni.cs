using UnityEngine;

public class SailingShipBossBloodAni : MonoBehaviour
{
	[SerializeField]
	private RectTransform blood1Rect;

	[SerializeField]
	private RectTransform blood2Rect;

	[SerializeField]
	private DxxText dmgScore;

	private const float BloodProgressAniTime = 0.5f;

	private int targetIndex;

	private int curShowScore;

	private int scoreDiff;

	private bool isMax;

	private RectTransform CurBloodRect => null;

	public void PlayAni(int targetIndex, int lastScore, float targetWidth, float originHeight, bool isMax)
	{
	}

	public void StopAllAni()
	{
	}

	public void Refresh()
	{
	}
}
