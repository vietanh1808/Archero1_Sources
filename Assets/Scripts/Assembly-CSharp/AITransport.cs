using System.Collections.Generic;

public class AITransport : ActionSeqWrapper
{
	public EntityBase m_TowerEntity;

	private Dictionary<int, float> sizeDict;

	private const float TransportEffectTime = 0.5f;

	private const float SwitchEffectPercent = 0.5f;

	private const string TransportEffectPath = "Game/TDEffects/TD1847_TransportEnemy";

	private float[] waitTimes;

	private AIBase_TD aiBase;

	private float effectScale;

	private float waitTimeAfterTransport;

	protected override void OnDeInit()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	private void createEffect()
	{
	}
}
