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

        IWheelAction CreateAction();
        bool EditAction(IWheelAction action);
    }

    public abstract class ActionEditor<T> : IActionEditor where T : IWheelAction
    {
        public Type Type { get => typeof(T); }
        public abstract string DisplayName { get; }

        public abstract T CreateAction();

        public abstract bool EditAction(T action);

        IWheelAction IActionEditor.CreateAction() => CreateAction();

        bool IActionEditor.EditAction(IWheelAction action) => EditAction((T)action);
    }
}
