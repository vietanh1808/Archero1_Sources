using UnityEngine;

public class PlinkoBallItem : MonoBehaviour
{
	private float _radius;

	public PlinkoBallData ballData;

	public float Radius => 0f;

	public int Index { get; set; }

	public void initBall(PlinkoBallData data)
	{
	}

	public void resetBall()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
