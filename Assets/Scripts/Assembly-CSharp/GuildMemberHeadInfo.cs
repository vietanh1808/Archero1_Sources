using System;
using System.Collections.Generic;

[Serializable]
public class GuildMemberHeadInfo
{
	public int head_frame;

	public int stage_level;

	public int stage_layer;

	public int heroId;

	public int skinId;

	public int pvp_score;

	public int pve_stage;

	public int vip_level;

	public List<int> equip_medal;

	public List<int> coop_heros;

	public int pve_hardstage;

	public int head_icon;

	public string user_id;

	public string user_name;

	public new string ToString()
	{
		return null;
	}

	public GuildMemberHeadInfo Clone()
	{
		return null;
	}
}
