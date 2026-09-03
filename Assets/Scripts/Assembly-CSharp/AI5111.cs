using Dxx.Util;

public class AI5111 : AIBase
{
	public const int BULLET_ID = 5333;

	public const string SwingHorizontallyAttackPrev_1_pre = "SwingHorizontallyAttackPrev_1_pre";

	private WeightRandomCount mWeightRandom;

	private SequencePool mSeqPool;

	private int[] callids;

	private int m_nCallId;

	private float m_fCallSpeed;

	private float m_fAttackEndSpeed;

	private float deltaSpeed;

	private bool changeAnimSpeed;

	private float newTime;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	private ActionBase SwingHorizontallyAttack()
	{
		return null;
	}

	private ActionBase CallThunder()
	{
		return null;
	}

	private ActionBase SwingVerticallyAttack()
	{
		return null;
	}

	private ActionBase Call()
	{
		return null;
	}

	private void ResetCallAniSpeed(string name)
	{
	}

	protected override void OnAIDeInit()
	{
	}
}
