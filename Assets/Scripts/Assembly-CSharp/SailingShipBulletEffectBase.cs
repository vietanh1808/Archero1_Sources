using UnityEngine;

public class SailingShipBulletEffectBase : MonoBehaviour
{
	[SerializeField]
	private TrailRenderer[] trailRenderer;

	private int maxOrder;

	public void Refresh()
	{
	}

	public int GetMaxOrder()
	{
		return 0;
	}
}
