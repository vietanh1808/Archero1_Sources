using System.Collections.Generic;
using UnityEngine;

public class TileExtraItemMgr : MonoBehaviour
{
	public CampMap campMap;

	private LocalUnityObjctPool mLocalPool;

	public GameObject cpTileBubble;

	private Dictionary<string, TileBubble> bubbleDict;

	public GameObject cpTileTextInfo;

	private Dictionary<string, TileTextInfo> tileTextInfoDict;

	public GameObject cpTownSkinEffectItem;

	private Dictionary<string, TileTownSkinEffectItem> townSkinEffectDict;

	public GameObject cpTicketItem;

	private Dictionary<string, TownTicketItem> townTicketDict;

	public GameObject cpTeamFlagItem;

	private Dictionary<string, TeamFlagItem> teamFlagDict;

	public void Awake()
	{
	}

	public void addExtraItem(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	public void deleteExtraItem(int mx, int my)
	{
	}

	public void clear()
	{
	}

	private void initBubble()
	{
	}

	private TileBubbleType checkBubble(LayerName layer, int tileIDEx, int x, int y)
	{
		return TileBubbleType.Unknown;
	}

	private void addBubble(TileBubbleType type, LayerName layer, int tileIDEx, int mx, int my)
	{
	}

	private void deleteBubble(int mx, int my)
	{
	}

	private void checkTileTopBubble(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	private void deleteTileTopBubble(int mx, int my)
	{
	}

	private void initTextInfo()
	{
	}

	private bool checkTileTextInfoOne(int tileIDEx)
	{
		return false;
	}

	private void addTileTextInfoOne(int tileIDEx, int mx, int my)
	{
	}

	private void deleteTileTextInfoOne(int mx, int my)
	{
	}

	private void checkTileTextInfo(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	private void deleteTileTextInfo(int mx, int my)
	{
	}

	private void initTownSkinEffect()
	{
	}

	private bool checkTownSkinEffect(int realx, int realy)
	{
		return false;
	}

	private void addTownSkinEffect(LayerName layer, int tileIDEx, int realx, int realy, int mapx, int mapy)
	{
	}

	private void deleteTownSkinEffect(int mx, int my)
	{
	}

	private void addTownSkinEffectToMap(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	private void deleteTownSkinEffectFromMap(int mx, int my)
	{
	}

	private void initTownTicketItem()
	{
	}

	private bool checkTownSkinTicket(int realx, int realy)
	{
		return false;
	}

	private void addTownSkinTicket(LayerName layer, int tileIDEx, int rx, int ry, int mapx, int mapy)
	{
	}

	private void deleteTownSkinTicket(int mx, int my)
	{
	}

	private void addTownSkinTicketToMap(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	private void deleteTownSkinTicketFromMap(int mx, int my)
	{
	}

	private void initTeamFlagItem()
	{
	}

	private bool checkTeamFlagItem(int realx, int realy)
	{
		return false;
	}

	private void addTeamFlagItem(LayerName layer, int tileIDEx, int rx, int ry, int mapx, int mapy)
	{
	}

	private void deleteTeamFlagItem(int mx, int my)
	{
	}

	private void addTeamFlagItemToMap(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	private void deleteTeamFlagItemFromMap(int mx, int my)
	{
	}
}
