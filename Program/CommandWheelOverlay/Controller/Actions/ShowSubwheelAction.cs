using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller.Actions
{
    public class ShowSubwheelAction : IWheelAction
    {
        public IWheel SubWheel { get; set; }

        public IWheelAction Clone(IWheelElements elements)
        {
            var result = new ShowSubwheelAction
            {
                SubWheel = SubWheel?.Clone(elements)
            };
            return result;
        }

        public void Perform()
        {
            throw new NotSupportedException();
        }
    }
}
