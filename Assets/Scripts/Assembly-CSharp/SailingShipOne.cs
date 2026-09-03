using System.Collections.Generic;
using UnityEngine;

public class SailingShipOne : MonoBehaviour
{
	public SailingShipPartOne partOne;

	public SailingShipPartOne ShipBaseOne;

	public Animator shipAni;

	public SailingMonsterAttackAni monsterAttackAni;

	private SailingShipPartData _crtData;

	private LocalUnityObjctPool pool;

	private List<SailingShipPartOne> _crtPartOnes;

	private void Awake()
	{
	}

	public void Init(SailingShipPartData data)
	{
	}

	public void SetPartOneSelect(int partID, bool isInMask = false)
	{
	}

	public void SetPartOneSelectBySkinID(int skinID, bool isInMask = false)
	{
	}

	public void IsPlayAni(bool isPlay)
	{
	}

	public void PlayChangeAni(int partID)
	{
	}

	public void PlaySelfMCannonAni(RectTransform target)
	{
	}

	public void SetAutoMCannonAni(RectTransform target, bool isPlay)
	{
	}
}
