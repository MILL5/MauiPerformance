using CommunityToolkit.Mvvm.ComponentModel;

namespace MacCollectionView;

public class TestObject : ObservableObject
{
    private static readonly Random Random = new();
     
    private double _double1;
    private double _double2;
    private double _double3;
    private double _double4;
    private double _double5;

    public double Double1
    {
        get => _double1;
        set => SetProperty(ref _double1, value);
    }
    public double Double2
    {
        get => _double2;
        set => SetProperty(ref _double2, value);
    }
    public double Double3
    {
        get => _double3;
        set => SetProperty(ref _double3, value);
    }
    public double Double4
    {
        get => _double4;
        set => SetProperty(ref _double4, value);
    }
    public double Double5
    {
        get => _double5;
        set => SetProperty(ref _double5, value);
    }

    public TestObject()
    {
        Update();
    }

    public void Update()
    {
        Double1 = Random.NextDouble();
        Double2 = Random.NextDouble();
        Double3 = Random.NextDouble();
        Double4 = Random.NextDouble();
        Double5 = Random.NextDouble();
    }
} 