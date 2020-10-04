[System.Serializable]

public class GridPropoty
{

    public GridCoordinate gridCoordinate;
    public GridBoolPropoty gridBoolPropoty;
    public bool gridBoolValue = false;

    public GridPropoty(GridCoordinate gridCoordinate,GridBoolPropoty gridBoolPropoty,bool gridBoolVale)
    {
        this.gridCoordinate = gridCoordinate;
        this.gridBoolPropoty = gridBoolPropoty;
        this.gridBoolValue = gridBoolValue;
    }

}
