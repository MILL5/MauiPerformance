# MauiPerformance

Single CollectionView that is bound to an ObservableCollection of 5 objects.  When Animate button is pressed, (Environment.ProcessorCount -1)
threads are created with a 4ms sleep that enumerates and updates the 5 objects.

The app locks up and dies quickly.
