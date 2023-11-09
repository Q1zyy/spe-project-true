﻿/*
 * Copyright 2015 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : SCADA-Communicator Console Application for Mono .NET framework
 * Summary  : The main entry point for the application
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2015
 * Modified : 2015
 */

using Scada.Comm.Engine;
using System;
using System.IO;
using System.Threading;

namespace Scada.Comm.Mono
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // запуск службы
            Console.WriteLine("Starting SCADA-Communicator...");
            Manager manager = new Manager();
            manager.StartService();

            Console.WriteLine("SCADA-Communicator is started");
            Console.WriteLine("Press 'x' or create 'commstop' file to stop SCADA-Communicator");

            // остановка службы при нажатии 'x' или обнаружении файла остановки
            FileListener stopFileListener = new FileListener("Cmd" + Path.DirectorySeparatorChar + "commstop");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.X || stopFileListener.FileFound))
                Thread.Sleep(ScadaUtils.ThreadDelay);
            manager.StopService();
            stopFileListener.DeleteFile();
            stopFileListener.Abort();
            Console.WriteLine("SCADA-Communicator is stopped");
        }
    }
}
