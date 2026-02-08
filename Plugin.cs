namespace Mod;

using BepInEx;
using GameConsole;
using RestartCommand.Commands;
using UnityEngine;

[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
public class Plugin : BaseUnityPlugin
{
    public void Awake() => gameObject.hideFlags = HideFlags.HideAndDontSave;

    public void Start() => Console.Instance.RegisterCommand(new RestartCmd());
}

public class PluginInfo
{
    public const string GUID = "duviz.RestartCommand";
    public const string Name = "RestartCommand";
    public const string Version = "0.1.0";
}