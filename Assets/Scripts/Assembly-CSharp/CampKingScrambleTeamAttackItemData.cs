public class CampKingScrambleTeamAttackItemData
{
	private CampKingScrambleTeamAttackItemSourceData ConfigData { get; set; }

	public CampID CampID => CampID.Unknown;

	public ulong Score => 0uL;

	public int Ranking => 0;

	public ulong UserID => 0uL;

	public string Name => null;

	public int HeadID => 0;

	public int HeadFrame => 0;

	public long HeadFrameTime => 0L;

	public int VIPLevel => 0;

	public static CampKingScrambleTeamAttackItemData Create(CampKingScrambleTeamAttackItemSourceData configData)
	{
		return null;
	}
}
