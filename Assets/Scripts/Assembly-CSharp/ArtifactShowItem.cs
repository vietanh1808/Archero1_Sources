using UnityEngine;

public class ArtifactShowItem : MonoBehaviour
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform artifactParent;

	[SerializeField]
	private Transform artifactTransform;

	private float rotateSpeed;

	public void Refresh(Transform objParent, float rotateSpeed, float scale, float height, float position, float[] artifactParentRotate)
	{
	}

	public void SetParentRotate(float rotate)
	{
	}

	private void Update()
	{
	}

	public Vector3 GetArtifactShowItemPosition()
	{
		return default;
	}

	public Quaternion GetArtifactShowItemRotation()
	{
		return default;
	}
}
