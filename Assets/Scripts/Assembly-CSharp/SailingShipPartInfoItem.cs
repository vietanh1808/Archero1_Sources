using UnityEngine;

public class SailingShipPartInfoItem : MonoBehaviour
{
	public DxxText partName;

	public DxxText partDesc;

	public DxxText partPower;

	public GameObject go_Power;

	public SailingShipPartInfoOne partOne;

	public ParticleSystem upgradeEffect;

	public GameObject goRed;

	private SailingShipPartItemData _crtData;

	public void InitPart(SailingShipPartItemData itemData)
	{
	}

	public void PlayUpgradeAni()
	{
	}

	public void RefreshRedNode()
	{
	}
}
