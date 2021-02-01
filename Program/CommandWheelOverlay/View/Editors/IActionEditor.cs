using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IActionEditor
    {
        Type Type { get; }
        string DisplayName { get; }

        IWheelAction CreateAction(IWheelElements elements);
        bool EditAction(IWheelAction action, IWheelElements elements);
    }

    public abstract class ActionEditor<T> : IActionEditor where T : IWheelAction
    {
        public Type Type { get => typeof(T); }
        public abstract string DisplayName { get; }

        public abstract T CreateAction(IWheelElements elements);

        public abstract bool EditAction(T action, IWheelElements elements);

        IWheelAction IActionEditor.CreateAction(IWheelElements elements) => CreateAction(elements);

        bool IActionEditor.EditAction(IWheelAction action, IWheelElements elements) => EditAction((T)action, elements);
    }
}
