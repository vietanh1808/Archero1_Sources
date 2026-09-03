using UnityEngine;

public class HeroShow : MonoBehaviour
{
	public Camera UICamera;

	public Transform ModelParent;

	private bool _isRTInstance;

	public void SetRenderTexture(RenderTexture rtInstance)
	{
	}

	public void ReleaseRenderTexture()
	{
	}

	private void OnDestroy()
	{
	}
}
