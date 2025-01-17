﻿using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationMaster
{
    partial class ConfigGui
    {
        internal void DrawCutsceneConfig()
        {
            if(ImGui.Checkbox("Enable", ref p.cfg.cutscene_Enable))
            {
                CutsceneEnded.Setup(p.cfg.cutscene_Enable, p);
            }
            if (p.cfg.cutscene_Enable)
            {
                ImGui.Text("When cutscene ends do the following if FFXIV is running in background:");
                ImGui.Checkbox("Show tray notification", ref p.cfg.cutscene_ShowToastNotification);
                ImGui.Checkbox("Flash taskbar icon", ref p.cfg.cutscene_FlashTrayIcon);
                ImGui.Checkbox("Bring FFXIV to foreground", ref p.cfg.cutscene_AutoActivateWindow);
                ImGui.Text("Zone locking:");
                ImGui.Checkbox("Only trigger in MSQ roulette dungeons", ref p.cfg.cutscene_OnlyMSQ);
                DrawHttpMaster(p.cfg.cutscene_HttpRequests, ref p.cfg.cutscene_HttpRequestsEnable,
                    "None available");
            }
        }
    }
}
