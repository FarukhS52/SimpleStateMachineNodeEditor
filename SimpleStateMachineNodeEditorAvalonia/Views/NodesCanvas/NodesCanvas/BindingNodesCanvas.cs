﻿using ReactiveUI;
using SimpleStateMachineNodeEditorAvalonia.Helpers;
using System.Reactive.Disposables;

namespace SimpleStateMachineNodeEditorAvalonia.Views
{
    public partial class NodesCanvas
    {
        protected override void SetupBinding()
        {
            this.WhenViewModelAnyValue(disposable =>
            {
                //this.OneWayBind(this.ViewModel, x => x.Nodes, x => x.NodesNodesCanvas.ViewModel).DisposeWith(disposable);
                this.OneWayBind(this.ViewModel, x => x.Connects, x => x.ConnectsNodesCanvas.ViewModel).DisposeWith(disposable);
                //this.OneWayBind(this.ViewModel, x => x.Selector, x => x.SelectorNodesCanvas.ViewModel).DisposeWith(disposable);
                //this.OneWayBind(this.ViewModel, x => x.Cutter, x => x.CutterNodesCanvas.ViewModel).DisposeWith(disposable);

            });
        }

    }
}

