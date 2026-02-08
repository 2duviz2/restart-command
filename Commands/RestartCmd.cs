namespace RestartCommand.Commands;

using GameConsole;
using System.Diagnostics;
using UnityEngine;

public class RestartCmd : ICommand
{
    string ICommand.Name => "Restart";

    public string Description => "Restarts the game via steam";

    public string Command => "restart";

    public void Execute(Console con, string[] args)
    {
        Application.Quit();
        var psi = new ProcessStartInfo
        {
            FileName = "steam://rungameid/1229490",
            UseShellExecute = true,
            WindowStyle = ProcessWindowStyle.Normal,
        };

        Process.Start(psi);
    }
}