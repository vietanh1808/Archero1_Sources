using UnityEngine;

public class RayCastManager
{
	private static int _groundlayer;

	private static int _flylayer;

	public static int groundLayer => 0;

	public static int flyLayer => 0;

	public static void CastMinDistance(Vector3 startpos, float angle, bool fly, out float mindis)
	{
		mindis = default;
	}

	public static void CastMinDistance(Vector3 startpos, Vector3 dir, bool fly, out float mindis)
	{
		mindis = default;
	}

	public static void CastMinDistance(Vector3 startpos, Vector3 dir, bool fly, out float mindis, out Vector3 minpos)
	{
		mindis = default;
		minpos = default;
	}

	public static void CastMinDistance(Vector3 startpos, Vector3 dir, bool fly, out float mindis, out Vector3 minpos, out Collider minCollider)
	{
		mindis = default;
		minpos = default;
		minCollider = null;
	}
}
