using System.Collections.Generic;
using UnityEngine;

public class SailingShipPartOne : MonoBehaviour
{
	private SailingShipPartItemData _crtPartData;

	public DxxImage _partIcon;

	public ParticleSystem effectBehind;

	public ParticleSystem effectFront;

	public SailingShipPartEffectItem EffectItem;

	private bool _isInit;

	private Dictionary<int, Dictionary<GameObject, Vector2>> _effectCacheMap;

	public void Init(SailingShipPartItemData crtData)
	{
	}

	public void SetSelectStatus(int partID, bool isInMask)
	{
	}

	public void SetSelectStatusBySkinID(int skinID, bool isInMask)
	{
	}

	public void PlayChangeAni(int partID)
	{
	}
}
