﻿using Avalonia.X11;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace SimpleStateMachineNodeEditorAvalonia.ViewModels
{
    public partial class NodeViewModel
    {
        protected override void SetupSubscriptions()
        {

        }


        //public void Test()
        //{
        //    this.Where(x => x.Output != null)
        //        .WhenAnyValue(x => x.Point1).Buffer(2, 1).Select(values => values[1] - values[0]).Subscribe(value => Output.Position = Output.Position + value);
        //}



    }
}
