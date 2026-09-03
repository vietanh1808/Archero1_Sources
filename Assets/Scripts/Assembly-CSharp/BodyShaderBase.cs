using UnityEngine;

public class BodyShaderBase
{
	protected EntityBase m_Entity;

	protected BodyMask m_Body;

	protected SkinnedMeshRenderer BodyMeshRenderer;

	protected MeshRenderer BodyMeshRenderer2;

	protected Shader m_outlineShader;

	protected Shader m_alphaShader;

	protected Shader m_transparentShader;

	protected Shader m_transparentSpecialShader;

	protected Shader m_deadShader;

	protected Shader m_superGoldShader;

	protected Material mMaterial;

	protected int Property_Brightness;

	private int Property_EmissionColor;

	protected int Property_RimColor;

	protected int Property_TextureColor;

	protected int Property_Alpha;

	protected int Property_ColorPower;

	protected int Property_MainTex;

	protected int Property_MatCapColor;

	protected int Property_MatCapIntensity;

	protected int Property_Opacity;

	protected int Property_MaskIntensity;

	protected float Brightness_valueinit;

	private const float elite_bright = 0.6f;

	private static bool UseRealtimeShadow => false;

	public void Init(EntityBase entity)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void SetBodyManually(BodyMask _body)
	{
	}

	public void UpdateElite()
	{
	}

	public void UpdateHell()
	{
	}

	public void UpdateHellBody()
	{
	}

	public void UpdatePartBody()
	{
	}

	public void updateWithSpecialShader()
	{
	}

	public void UpdateTransparent()
	{
	}

	protected void SetLightShader(Color color)
	{
	}

	public void ReturnToDefault()
	{
	}

	protected virtual void OnReturnToDefault()
	{
	}

	public void SetPartBody(bool ignorShader = false)
	{
	}

	private void setPartBodyForBodyExtra()
	{
	}

	public void SetSuperGold()
	{
	}

	public virtual void SetHitted()
	{
	}

	public virtual void OnUpdateHitted(float value)
	{
	}

	public virtual void SetElement(Color color)
	{
	}

	public void SetTexture(string textureid)
	{
	}

	public void SetRimPower(float value)
	{
	}

	public void SetColorPower(float value)
	{
	}

	public virtual void SetRimColor(Color color)
	{
	}

	private void _set_texture(SkinnedMeshRenderer renderer, string textureid)
	{
	}

	private void _set_textures(SkinnedMeshRenderer[] renderers, string textureid)
	{
	}

	public virtual void SetOrder(int order)
	{
	}

	public void SetStrengh()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public float GetAlpha()
	{
		return 0f;
	}

	public void ShowShadow(bool show)
	{
	}

	private void SetAllRenderersShadow(bool castShadow)
	{
	}

	public void DeInit()
	{
	}
}
