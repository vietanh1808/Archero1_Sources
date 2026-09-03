using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VisionMistCameraV2 : MonoBehaviour
{
	private Camera _camera;

	private Material _fogMaterial;

	private Material _silhouetteMaterial;

	private Material _blitMaterial;

	private CommandBuffer _cmdBuffer;

	private static readonly int P_FogAlpha;

	private static readonly int P_PlayerUV;

	private static readonly int P_BrightUV;

	private static readonly int P_PlayerRadius;

	private static readonly int P_BrightRadius;

	private static readonly int P_PlayerSoftness;

	private static readonly int P_BrightSoftness;

	private float _unitVPX;

	private float _unitVPY;

	private readonly List<Renderer> _silhouetteRenderers;

	public void Init()
	{
	}

	private void EnsureBlitMaterial()
	{
	}

	public void DeInit()
	{
	}

	private void CalcUnitViewport()
	{
	}

	public void RegisterSilhouette(Renderer renderer)
	{
	}

	public void UnregisterSilhouette(Renderer renderer)
	{
	}

	public void RegisterEntitySilhouette(EntityBase entity)
	{
	}

	public void UnregisterEntitySilhouette(EntityBase entity)
	{
	}

	public void ClearSilhouettes()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
