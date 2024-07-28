public class Labaratory
{
    private readonly Cell _sourceCell;

    private Cell _prototypeCell;

    public List<Cell> AllCells;

    public Labaratory(int cellPower)
    {
        _sourceCell = new Cell(cellPower);
    }

    public void DuplicateSourceCell()
    {
        _prototypeCell = _sourceCell.Clone();
    }

    public void MutationSourceCell()
    {
        _sourceCell.DNAMutation();
    }

    public string GetSourceCellDNA()
    {
        return _sourceCell.ShowDNA();
    }

    public string GetPrototypeCellDNA()
    {
        return _prototypeCell.ShowDNA();
    }

}