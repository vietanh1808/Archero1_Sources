using DG.Tweening;
using UnityEngine;

public class CampTileNumFlyAni : MonoBehaviour
{
	[SerializeField]
	private DxxText normalDmg;

	[SerializeField]
	private DxxText specialDmg;

	private Tweener tweener;

	private bool isUsing;

	public Tweener PlayAni(Vector3 pos, CampTileArrowDamageData damageData, CampTileOccupyType occupyType)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public bool IsUsing()
	{
		return false;
	}

	public void Recycle()
	{
	}
}
