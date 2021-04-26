// Reference: 0Harmony
using System;
using Harmony;

namespace uMod.Plugins
{
    [Info ("Test", "Calytic", "0.0.51")]
    [Description ("Test")]
    class TestPlugin : Plugin
    {
        [Command ("Test")]
        void cmdTest ()
        {
            webrequest.Enqueue ("https://httpbin.com/get", string.Empty, delegate (int status, string response) {
                Interface.Oxide.LogInfo ("Response1\n" + response);
            }, this);
        }
    }
}