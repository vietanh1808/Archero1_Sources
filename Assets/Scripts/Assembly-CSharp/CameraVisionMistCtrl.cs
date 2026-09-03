using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraVisionMistCtrl : MonoBehaviour
{
	public struct RendererMaterialPair
	{
		public Renderer renderer;

		public Material material;
	}

	private Material _fogMaterial;

	private Camera _camera;

	private CommandBuffer _cmdBuffer;

	private Material _silhouetteMatOutLight;

	private Material _silhouetteMatOutLine02;

	private readonly List<RendererMaterialPair> _silhouetteRenderers;

	private float _unitRadiusX;

	private float _unitRadiusY;

	private bool _unitRadiusCached;

	private static readonly int P_DebugDraw;

	private int _debugLogCounter;

	public bool DebugMode;

	private static readonly int P_FogAlpha;

	private static readonly int P_PlayerScreenPos;

	private static readonly int P_VisionRadiusX;

	private static readonly int P_VisionRadiusY;

	private static readonly int P_VisionSoftness;

	private static readonly int P_BrightScreenPos;

	private static readonly int P_BrightRadiusX;

	private static readonly int P_BrightRadiusY;

	private static readonly int P_BrightSoftness;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void EnsureUnitRadius()
	{
	}

	private Vector2 GetPlayerViewportPos()
	{
		return default;
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	private void SetMatParams(Material mat, Vector4 psp, float vrx, float vry, Vector4 bsp, float brx, float bry)
	{
	}

	private void RegisterSilhouette(Renderer renderer)
	{
	}

	private Material GetSilhouetteMaterial(Renderer renderer)
	{
		return null;
	}

	public void RegisterEntitySilhouette(EntityBase entity)
	{
	}

	public void UnregisterSilhouette(Renderer renderer)
	{
	}

	public void UnregisterEntitySilhouette(EntityBase entity)
	{
	}

	public void ClearSilhouettes()
	{
	}
}
