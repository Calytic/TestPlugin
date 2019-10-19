using System;
using Oxide.Core;

namespace Oxide.Plugins
{
    [Info ("Test", "Calytic", "0.0.48")]
    [Description ("Test")]
    class TestPlugin : CovalencePlugin
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
