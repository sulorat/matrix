using System;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        Matrix matrix = new Matrix();
    }
}

class Matrix
{
    StringBuilder sb = new StringBuilder();
    Random rand = new Random();
    static private int _countRows = 0;
    public int CountRows
    {
        get => _countRows;
        set => _countRows = value;
    }
    static private int _countColumns = 0;
    public int CountColumns
    {
        get => _countColumns;
        set => _countColumns = value;
    }

    private double[,] Values = new double[_countRows, _countColumns];

    public override string ToString()
    {
        for (int i = 0; i < _countRows; i++)
        {
            for (int j = 0; j < _countColumns; j++)
            {
                sb.Append(j);
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
    public Matrix(int CountRows, int CountColumns)
    {
        this.CountColumns = CountColumns;
        this.CountRows = CountRows;
        for (int i = 0; i < _countRows; i++)
        {
            for (int j = 0; j < _countColumns; j++)
            {
                Values[i, j] = rand.Next(10, 100);
            }
        }
    }
    public Matrix(double[,] Values)
    {
        this.Values = Values;
        CountRows = Values.GetLength(0);
        CountColumns = Values.GetLength(1);
    }

    public Matrix()
    {

    }
}