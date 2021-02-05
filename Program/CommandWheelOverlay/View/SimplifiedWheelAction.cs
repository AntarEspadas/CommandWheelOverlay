using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Controller.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheelAction
    {
        public SimplifiedWheel? SubWheel { get; }
        public WheelActionType Type { get; }

        public SimplifiedWheelAction(IWheelAction action, IWheelElements elements)
        {
            if (action is ShowSubwheelAction showSubwheelAction)
            {
                Type = WheelActionType.DisplaySubwheel;
                if (showSubwheelAction.SubWheel != null)
                    SubWheel = new SimplifiedWheel(showSubwheelAction.SubWheel, elements);
                else
                    SubWheel = null;
            }
            else
            {
                Type = WheelActionType.Other;
                SubWheel = null;
            }
        }
    }
}
