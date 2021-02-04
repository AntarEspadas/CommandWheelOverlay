using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CommandWheelOverlay.Input
{
    public interface IInputHandler
    {
        IList<int> ShowHotkey { get; set; }
        IList<int> MoveLeftHotkey { get; set; }
        IList<int> MoveRightHotkey { get; set; }
        void RecordHotkey(Action<int> keyRecordedCallback, Action<IList<int>> finishedRecordingCallback, CancellationToken cancellationToken);
        void Handle(MouseInput input);
        void Handle(KeyboardInput input);
    }
}
