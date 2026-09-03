using UnityEngine;

public class BeamVO
{
	public float textureLengthScale;

	public float textureScrollSpeed;

	private Transform mTransform;

	private bool follow;

	public Vector3 StartPos;

	public Vector3 EndPos;

	public float BeamLength;

	public bool Follow => false;

	public BeamVO(Transform _trans, Vector3 dir, float beamLength, bool _follow = false)
	{
	}

	public Vector2 GetMainTextureScale()
	{
		return default;
	}

	public Vector2 GetMainTextureOffset()
	{
		return default;
	}

	public float GetScaledDistance()
	{
		return 0f;
	}

	public virtual Vector3 GetColliderCenter()
	{
		return default;
	}

	public virtual Vector3 GetColliderSize(BoxCollider collider)
	{
		return default;
	}
}
