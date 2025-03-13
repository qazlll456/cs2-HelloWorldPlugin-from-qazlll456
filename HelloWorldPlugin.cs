using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Commands;

namespace HelloWorldChatPlugin;

public class HelloWorldChatPlugin : BasePlugin
{
    public override string ModuleName => "Hello World Chat Plugin";
    public override string ModuleVersion => "1.0.0";
    public override string ModuleAuthor => "qazlll456 from HK with xAI assistance to develop";
    public override string ModuleDescription => "A simple plugin that supports the console command css_hello and the chat command !hello";

    public override void Load(bool hotReload)
    {
        // Output "Hello World!" to the server console when the plugin is loaded
        Console.WriteLine("Hello World! Plugin Loaded Successfully!");

        // Register the chat command, triggered when a player types !hello
        AddCommand("css_hello", "Say hello world! in the chat or output to the console", OnHelloCommand);
    }

    private void OnHelloCommand(CCSPlayerController? player, CommandInfo command)
    {
        // If the command is issued by a player (typed !hello or /hello in chat)
        if (player != null && player.IsValid)
        {
            // Display a message to all players in the chat, including the player's name
            Server.PrintToChatAll($" {player.PlayerName} says: hello world!");
        }
        // If the command is issued from the console
        else
        {
            // Output "hello world!" to the server console
            Console.WriteLine("hello world!");
        }
    }
}