public class SailingShipGameEngine : CInstance<SailingShipGameEngine>
{
	private SailingShipManager ShipManager => null;

	private SailingShipGameData ShipGameData => null;

	public bool IsExiting { get; set; }

	public void GameStart()
	{
	}

	public void GameEnd()
	{
	}

	private void Onupdate(float deltaTime)
	{
	}

	public void GameStartWithText()
	{
	}

	public void GameEndWithText()
	{
	}

	private void OnUpdateText(float deltaTime)
	{
	}

	public void UpdateEntityData(SailingShipBattleMsgItemData battleData)
	{
	}

	private void DebugOriginAttrLog()
	{
	}

	private void DebugPerBattleAttrLog(SailingShipBattleMsgItemData battleData)
	{
	}
}
