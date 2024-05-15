using ScoutingApp;

namespace ScoutingApp.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    public string? ScouterName { get; set; }
    public int TeamNumber { get; set; }
    public int MatchNumber { get; set; }

    public RobotPosition RobotPosition { get; set; }
}