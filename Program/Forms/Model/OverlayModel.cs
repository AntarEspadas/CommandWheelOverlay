using CommandWheelForms.Settings;
using CommandWheelOverlay.Model;
using CommandWheelOverlay.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWheelForms.Model
{
    class OverlayModel : JsonElementsModel
    {
        public override IUserSettings GetSettings()
        {
            return UserSettings.Instance;
        }

        public override bool SaveSettings(IUserSettings settings)
        {
            try
            {
                ((UserSettings)settings).Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
