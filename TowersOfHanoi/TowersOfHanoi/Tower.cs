namespace TowersOfHanoi;

public class Tower
{
    private Disc[] _discs;
    private int position;

    public Tower(Disc[] discs, int position)
    {
        _discs = discs;
        position = position;
    }

    public Disc GetTopDisc()
    {
        return _discs[0];
    }

    public Disc RemoveTopDisc()
    {
        var disc = _discs[0];
        _discs[0] = _discs[1];
        _discs[1] = _discs[2];
        _discs[2] = null;
        return disc;
    }
}