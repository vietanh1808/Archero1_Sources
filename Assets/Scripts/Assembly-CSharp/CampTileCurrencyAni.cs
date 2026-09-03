using DG.Tweening;
using UnityEngine;

public class CampTileCurrencyAni : MonoBehaviour
{
	[SerializeField]
	private GameObject ironArrow;

	[SerializeField]
	private GameObject goldArrow;

	private CampTileReturnArrowData data;

	private Sequence ani;

	public bool isUsing;

	public Sequence PlayIronArrowAni(int index, CampTileReturnArrowData data, Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	public Sequence PlayGoldArrowAni(int index, CampTileReturnArrowData data, Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public void Recycle()
	{
	}
}
