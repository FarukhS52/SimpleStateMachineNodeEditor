﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using SimpleStateMachineNodeEditorAvalonia.Helpers;
using System;
using System.Diagnostics;
using System.Reactive.Disposables;

namespace SimpleStateMachineNodeEditorAvalonia.Views
{
    public partial class Node
    {
        private Point oldPosition;
        protected override void SetupEvents()
        {  
            this.WhenViewModelAnyValue(disposable =>
            {           
                this.BorderNode.Events().PointerPressed.Subscribe(OnEventBorderPointerPressed).DisposeWith(disposable);
                this.BorderNode.Events().PointerReleased.Subscribe(OnEventBorderPointerReleased).DisposeWith(disposable);
            });
        }

        void OnEventBorderPointerPressed(PointerPressedEventArgs e)
        {
            
            this.ViewModel.SelectCommand.ExecuteWithSubscribe(Keyboard.IsKeyDown(Key.LeftCtrl) ? SelectMode.ClickWithCtrl : SelectMode.Click);
            oldPosition = e.GetPosition(NodesCanvas.Current);
            this.PointerMoved += this.OnEventPointerMoved;
        }

        void OnEventBorderPointerReleased(PointerReleasedEventArgs e)
        {
            this.PointerMoved -= this.OnEventPointerMoved;
        }

        void OnEventPointerMoved(object subject, PointerEventArgs e)
        {
            var currentPosition = e.GetPosition(NodesCanvas.Current);
            this.ViewModel.NodesCanvas.Nodes.MoveCommand.ExecuteWithSubscribe(currentPosition - oldPosition);
            oldPosition = currentPosition;
        }
    }
}
