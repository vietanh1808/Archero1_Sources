using UnityEngine;

public class BodyShaderTimeLine
{
	protected EntityTimeLineBase owner;

	protected BodyMask body;

	protected SkinnedMeshRenderer BodyMeshRenderer;

	protected MeshRenderer BodyMeshRenderer2;

	protected Shader m_outlineShader;

	protected Shader m_alphaShader;

	protected Shader m_deadShader;

	protected Material mMaterial;

	protected int Property_Brightness;

	private int Property_EmissionColor;

	protected int Property_RimColor;

	protected int Property_TextureColor;

	protected int Property_Alpha;

	protected float Brightness_valueinit;

	private const float elite_bright = 0.6f;

	public void Init(EntityTimeLineBase entity)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void UpdateElite()
	{
	}

	protected void SetLightShader()
	{
	}

	public void ReturnToDefault()
	{
	}

	protected virtual void OnReturnToDefault()
	{
	}

	public void SetPartBody()
	{
	}

	public void SetHitted()
	{
	}

	public void OnUpdateHitted(float value)
	{
	}

	public void SetElement(Color color)
	{
	}

	public void SetTexture(string textureid)
	{
	}

	private void _set_texture(SkinnedMeshRenderer renderer, string textureid)
	{
	}

	private void _set_textures(SkinnedMeshRenderer[] renderers, string textureid)
	{
	}

	public void SetOrder(int order)
	{
	}

	public void SetStrengh()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void ShowShadow(bool show)
	{
	}

	private void SetAllRenderersShadow(bool castShadow)
	{
	}
}
