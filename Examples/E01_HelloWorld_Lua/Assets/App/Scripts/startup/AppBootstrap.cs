﻿using TinaX;
using TinaX.VFSKit;
using TinaX.UIKit;

namespace Nekonya.Example
{
    /// <summary>
    /// 推荐作为App (Game) 的程序入口。该class会被TinaX反射寻找，可以同时存在多个
    /// It is recommended to be the program entry of app (game). 
    /// This class will be reflection by tinax , and there can be multiple
    /// </summary>
    public class AppBootstrap : IXBootstrap
    {
        /// <summary>
        /// "OnInit" be called after "TinaX's Services" Inited and Registered, before "TinaX's Services" started.
        /// </summary>
        public void OnInit(IXCore core)
        {
        }

        public void OnStart(IXCore core)
        {
            //move to lua : Assets/App/Lua/Startup/startup.lua.txt
        }

        public void OnQuit()
        {
        }

        public void OnAppRestart()
        {
        }

    }
}
