using System;

public class GamePlayActivityOneData_Server : IComparable<GamePlayActivityOneData_Server>
{
	public int id;

	public int tag;

	public int free_cnt;

	public int buy_cnt;

	public int level;

	public int score;

	public int max_free_cnt;

	public int cost_life;

	public string buy_life_cost;

	public long start_time;

	public long end_time;

	public long conf_end_time;

	public int order;

	public int lastTime => 0;

	public int buyTime => 0;

	public int IfNotValid()
	{
		return 0;
	}

	int IComparable<GamePlayActivityOneData_Server>.CompareTo(GamePlayActivityOneData_Server other)
	{
		return 0;
	}
}
