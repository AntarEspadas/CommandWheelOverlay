using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IActionEditor
    {
        string DisplayName { get; }

        IWheelAction CreateAction();
        IWheelAction EditAction(IWheelAction action);
    }

    public abstract class IActionEditor<T> : IActionEditor where T : IWheelAction
    {
        public Type Type { get => typeof(T); }
        public abstract string DisplayName { get; }

        public abstract T CreateAction();

        public abstract T EditAction(IWheelAction action);

        IWheelAction IActionEditor.CreateAction() => CreateAction();

        IWheelAction IActionEditor.EditAction(IWheelAction action) => EditAction(action);
    }
}
