# Quick Tasks App Tutorial Part 2


## 1. Create navigation container for app

* Added Navigation for MainPage in constructor App.class

```csharp
public App()
{
    InitializeComponent();
    MainPage = new NavigationPage(new MainPage();
}
```

## 2. Added ListView and Fakedata to MainScreen

+![](Materials/Screenshot_04.png)

 1. Open MainPage.xaml file in solution and change default label to ListView

```csharp
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:QuickTasks"
             x:Class="QuickTasks.MainPage">

	<ListView x:Name="QuickTaskListView" />

</ContentPage>
```

2. Open MainPage.xaml.cs and add list with fakedata 


```csharp
public MainPage()
{
	InitializeComponent();
	List<string> tasks = new List<string>();
	tasks.Add("Create Xamarin Apps");
	tasks.Add("Join XMDG.cz on Facebook and Twitter");
	tasks.Add("Enjoy Xamarin Prague Days");
}
```


3. Add Data to ListView

```csharp
QuickTaskListView.ItemsSource = tasks;
```


## You got this!

+![](Materials/Screenshot_05.png)



