using UnityEngine;

public class CameraHellInvironmentCtrl : MonoBehaviour
{
	[SerializeField]
	private Material PostProcessMat;

	private void Awake()
	{
	}

	public void Init(Material mat)
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
