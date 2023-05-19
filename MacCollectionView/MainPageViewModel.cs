using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MacCollectionView;

public partial class MainPageViewModel : ObservableObject
{
    private bool _animating;
    public ObservableCollection<TestObject> TestObjects { get; }
    private readonly int _threadCount = Environment.ProcessorCount -1;
    private const int ThreadSleep = 4;
    private const int ObjectCount = 5;
    
    [ObservableProperty]
    private string _buttonText;
    
    public MainPageViewModel()
    {
        ButtonText = "Animate";
        TestObjects = new ObservableCollection<TestObject>();
        for (var i = 0; i < ObjectCount; i++)
        {
            TestObjects.Add(new());
        }
    }

    [RelayCommand]
    private void Animate()
    {
        _animating = !_animating;
        ButtonText = (_animating) ? "Stop" : "Animate";
        if (_animating)
        {
            RunAnimate();
        }
    }

    private void RunAnimate()
    {
        for (var i = 0; i < _threadCount; i++)
        {
            Task.Run(() =>
            {
                while (_animating)
                {
                    foreach (var testObject in TestObjects.ToArray())
                    {
                        testObject.Update();
                        Thread.Sleep(ThreadSleep);
                    }
                }
            });
        }
    }
}