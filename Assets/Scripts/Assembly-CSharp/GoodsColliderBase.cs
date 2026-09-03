using UnityEngine;

public class GoodsColliderBase : MonoBehaviour
{
	private GoodsBase m_Goods;

	private BoxCollider box;

	private float lasttime;

	private RaycastHit[] TriggerTest_Hits;

	private RaycastHit TriggerTest_Hit;

	private int TriggerTest_i;

	private int TriggerTest_Max;

	private Vector3 dir;

	private void Awake()
	{
	}

	public void SetGoods(GoodsBase good)
	{
	}

	private void Update()
	{
	}

	private void TriggerTest()
	{
	}
}
