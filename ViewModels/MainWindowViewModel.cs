using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels;
public partial class MainWindowViewModel : ObservableObject
{
    public ObservableCollection<Student> Students { get; } = new();

    [ObservableProperty] private Student? _selectedStudent;
    [ObservableProperty] private string _currentName = "";
    [ObservableProperty] private string _currentGroup = "";
    [ObservableProperty] private string _currentAdvisor = "";

    [RelayCommand]
    private void Add()
    {
        Students.Add(new Student { Name = CurrentName, Group = CurrentGroup, ScientificAdvisor = CurrentAdvisor });
    }

    [RelayCommand]
    private void Delete()
    {
        if (SelectedStudent != null) Students.Remove(SelectedStudent);
    }
}