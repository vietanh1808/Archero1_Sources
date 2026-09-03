using System.Collections.Generic;
using Ara;
using UnityEngine;

[ExecuteAlways]
public class UltimateTransparencyController : MonoBehaviour
{
	private List<Renderer> _renderers;

	private List<AraTrail> araTrails;

	private Dictionary<Renderer, Material[]> _originalMaterials;

	private List<Material> _runtimeMaterials;

	private List<Texture2D> _runtimeTextures;

	private MaterialPropertyBlock propertyBlock;

	private string[] ColorProps;

	private bool _isWeakened;

	private HashSet<Renderer> _animatedRenderers;

	private float AlphaValue => 0f;

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void LoadEffectWeaken()
	{
	}

	public void UnloadEffectWeaken()
	{
	}

	private void ApplyEffectWeaken(float alpha)
	{
	}

	private void ApplyViaMaterialInstance(Renderer rend, float alpha)
	{
	}

	private void RemoveEffectWeakenOverride()
	{
	}

	private void ClearAraTrailMaterials()
	{
	}

	private void InitProperty()
	{
	}

	private void InitializeRenderers()
	{
	}

	public void SetGlobalAlpha(float alpha)
	{
	}

	private bool TrySetAlphaViaProperty(Renderer renderer, int index, Material mat, float alpha)
	{
		return false;
	}

	private Material TrySetAlphaViaProperty(Material mat, float alpha)
	{
		return null;
	}

	private void CreateMaterialInstances()
	{
	}

	private void ActivateFallbackSolution(Renderer rend, int materialIndex, float alpha)
	{
	}

	private Material GetFallbackMaterial(float alpha)
	{
		return null;
	}

	private Material CreateAlphaMaterial(Shader shader, string colorProp, float alpha)
	{
		return null;
	}

	private Material CreateDynamicShaderMaterial(float alpha)
	{
		return null;
	}

	private void ForceEnableTransparency(Material mat)
	{
	}

	private void RestoreOriginalMaterials()
	{
	}

	private void CleanupRuntimeResources()
	{
	}
}
