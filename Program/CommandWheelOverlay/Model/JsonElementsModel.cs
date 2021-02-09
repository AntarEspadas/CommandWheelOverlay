using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace CommandWheelOverlay.Model
{
    public abstract class JsonElementsModel : IOverlayModel
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

        public abstract bool SaveSettings(IUserSettings settings);
        public abstract IUserSettings GetSettings();
    }
}
