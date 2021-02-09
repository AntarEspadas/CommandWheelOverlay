using CommandWheelForms.Settings;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Model;
using CommandWheelOverlay.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWheelForms.Model
{
    class OverlayModel : IOverlayModel
    {
        public string ElementsPath { get; set; }

        private readonly JsonSerializerSettings jsonSettings = new JsonSerializerSettings()
        {
            PreserveReferencesHandling = PreserveReferencesHandling.All,
            TypeNameHandling = TypeNameHandling.Auto
        };

        public IWheelElements GetElements()
        {
            try
            {
                string json;
                lock (this)
                {
                    json = File.ReadAllText(ElementsPath);
                }
                IWheelElements elements = JsonConvert.DeserializeObject<IWheelElements>(json, jsonSettings);
                return elements;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool SaveElements(IWheelElements elements)
        {
            try
            {
                var jsonSettings = new JsonSerializerSettings
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.All,
                    TypeNameHandling = TypeNameHandling.Objects
                };
                string json = JsonConvert.SerializeObject(elements, elements.GetType(), Formatting.Indented, jsonSettings);
                lock (this)
                {
                    File.WriteAllText(ElementsPath, json);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IUserSettings GetSettings()
        {
            return UserSettings.Instance;
        }

        public bool SaveSettings(IUserSettings settings)
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
