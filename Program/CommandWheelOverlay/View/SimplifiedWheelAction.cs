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
            Type = action is ShowSubwheelAction ? WheelActionType.DisplaySubwheel : WheelActionType.Other;
            if (Type == WheelActionType.DisplaySubwheel && action.SubWheel != null)
            {
                SubWheel = new SimplifiedWheel(action.SubWheel, elements);
            }
            else
            {
                SubWheel = null;
            }
        }
    }
}
