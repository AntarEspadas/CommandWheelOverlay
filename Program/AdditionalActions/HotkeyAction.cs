﻿using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using sharpAHK;
using System.Collections.ObjectModel;

namespace CommandWheelOverlay.AdditionalActions
{
    public class HotkeyAction : IWheelAction
    {
        private static readonly _AHK _ahk = new _AHK();

        public IReadOnlyList<string> Keys => _keys;

        private string[] _keys;

        private string _hotkey;

        public void SetHotkey(params string[] keys)
        {
            _keys = keys;

            string downs = "";
            string ups = "";
            foreach (string input in keys)
            {
                downs += "{" + input + " Down}";
                ups += "{" + input + " Up}";
            }
            _hotkey = downs + ups;
        }

        public IWheelAction Clone(IWheelElements elements)
        {
            return (IWheelAction)MemberwiseClone();
        }

        public void Perform()
        {
            _ahk.SendInput(_hotkey);
        }
    }
}
