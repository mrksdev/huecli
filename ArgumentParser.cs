using System;
using System.Collections.Generic;

namespace huecli
{
    public class ArgumentParser
    {
        public String[] arguments { get; set; }

        public void ShowHelp()
        {
            Console.WriteLine("huecli 1.0 - made by bmsimons, 2018");
            Console.WriteLine("Control your Hue lighting/home automation from the CLI.");
            Console.WriteLine("");
            Console.WriteLine("Arguments:");
            Console.WriteLine("");
            Console.WriteLine("Scan for UPnP-enabled hubs:     huecli scan-hubs");
            Console.WriteLine("Add a hub:                      huecli add-hub");
            Console.WriteLine("Remove a hub:                   huecli remove-hub");
            Console.WriteLine("Get available hubs:             huecli get-hubs");
            Console.WriteLine("Get avail. lighting for hub:    huecli get-lighting hubalias");
            Console.WriteLine("");
            Console.WriteLine("Turn light on:                  huecli on hubalias lightid");
            Console.WriteLine("Turn light off:                 huecli off hubalias lightid");
            Console.WriteLine("Set light brightness:           huecli set-brightness hubalias lightid 1-254");
            Console.WriteLine("Set light temperature:          huecli set-temperature hubalias lightid 154-500");
            Console.WriteLine("Set light color:                huecli set-color hubalias lightid 0-65535");
            Console.WriteLine("Set light effect:               huecli set-effect hubalias lightid <colorloop>|<none>");
        }

        public bool ShouldShowHelp()
        {
            return this.arguments.Length <= 1;
        }

        public string GetMainAction()
        {
            if (this.ShouldShowHelp())
            {
                return null;
            }
            else
            {
                return this.arguments[1];
            }
        }

        public bool RemoveHubCheckEnoughArguments()
        {
            return this.arguments.Length == 3;
        }

        public bool AddHubCheckEnoughArguments()
        {
            return this.arguments.Length == 4;
        }

        public bool GetLightingCheckEnoughArguments()
        {
            return this.arguments.Length == 3;
        }

        public bool TurnOnOffCheckEnoughArguments()
        {
            return this.arguments.Length == 4;
        }

        public bool SetBrightnessCheckEnoughArguments()
        {
            return this.arguments.Length == 5;
        }

        public bool SetTemperatureCheckEnoughArguments()
        {
            return this.arguments.Length == 5;
        }

        public bool SetColorCheckEnoughArguments()
        {
            return this.arguments.Length == 5;
        }

        public bool SetEffectcheckEnoughArguments()
        {
            return this.arguments.Length == 5 || this.arguments.Length == 4;
        }

        public ArgumentParser()
        {
            arguments = Environment.GetCommandLineArgs();
        }
    }
}