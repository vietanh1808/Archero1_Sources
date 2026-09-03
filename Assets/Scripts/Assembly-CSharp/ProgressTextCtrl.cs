using System;
using DG.Tweening;

public class ProgressTextCtrl : ProgressCtrl
{
	private int _cur;

	private int _max;

	public Action<int, int> OnValueChanged;

	public DxxText text { get; private set; }

	public int current
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int currentcount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int max
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void OnAwake()
	{
	}

	private void UpdateValue()
	{
	}

	public void SetText(string value)
	{
	}

	public void PlayTextScale(float scale, float time)
	{
	}

	public Sequence PlayCount(int after, float alltime)
	{
		return null;
	}

	public void PlayPercent(float after, float time)
	{
	}
}
