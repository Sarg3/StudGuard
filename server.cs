function GameConnection::AutoAdminCheck(%client)
{
    messageClient(%client,'',"<color:912E13>This server is running StudGuard Version" SPC $StudGuard::Version @ ".");
    return parent::AutoAdminCheck(%client);
}

exec("./presets/presets.cs");
exec("./modules/modules.cs");
exec("./StudBot/studbot.cs");
