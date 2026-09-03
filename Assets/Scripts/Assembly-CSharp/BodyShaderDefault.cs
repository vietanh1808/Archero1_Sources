using UnityEngine;

public class BodyShaderDefault : BodyShaderBase
{
	private float outlineWidth;

	private Color m_oulineColor;

	private bool bTargetColor;

	private static Color TargetColor;

	private const float TargetWidth = 0.1f;

	private Color tcolor;

	protected override void OnInit()
	{
	}

	protected override void OnReturnToDefault()
	{
	}
}
