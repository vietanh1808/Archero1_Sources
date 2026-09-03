using UnityEngine;

public class Bullet5368Ctrl : MonoBehaviour
{
	[SerializeField]
	private GameObject selfPar;

	[SerializeField]
	private GameObject enemyPar;

	[SerializeField]
	private TrailRenderer selfTrailRenderer;

	[SerializeField]
	private TrailRenderer enemyTrailRenderer;

	private bool isSelf;

	public void Refresh(bool isSelf)
	{
	}
}
