﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStateMachineNodeEditorAvalonia.Views
{
    public partial class MainWindow
    {
        public NodesCanvas NodesCanvasMainWindow;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            NodesCanvasMainWindow = this.FindControl<NodesCanvas>("NodesCanvasMainWindow");
        }

    }
}
