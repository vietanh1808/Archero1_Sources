public class AI3195 : AI3011
{
	private const float BodyScaleMax = 30f;

	private const float MoveSpeedMax = 30f;

	private const float BodyHitMax = 30f;

	private float m_fBodyScaleAdd;

	private float m_fMoveSpeedAdd;

	private float m_fBodyHitAdd;

	private float m_fBodyScaleTotal;

	private float m_fMoveSpeedTotal;

	private float m_fBodyHitTotal;

	protected override void OnInitOnce()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void OnHitted(EntityBase entity, long hp)
	{
	}
}
