﻿using Avalonia;
using ReactiveUI;
using SimpleStateMachineNodeEditorAvalonia.Helpers;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace SimpleStateMachineNodeEditorAvalonia.Views
{
    public partial class Connect
    {
        protected override void SetupSubscriptions()
        {
            this.WhenViewModelAnyValue(disposable =>
            {
                var points = ViewModel.WhenAnyValue(x => x.FromConnector.Position,
                    x => x.ToConnector.Position).Select(points => UpdateMediumPoints(points.Item1, points.Item2));
                
                points.Select(x => x.Point1).BindTo(BezierSegmentConnect, x => x.Point1).DisposeWith(disposable);
                points.Select(x => x.Point2).BindTo(BezierSegmentConnect, x => x.Point2).DisposeWith(disposable);
            });
        }

        public static (Point Point1, Point Point2) UpdateMediumPoints(Point startPoint, Point endPoint)
        {
            var different = endPoint - startPoint;
            var Point1 = new Point(startPoint.X + 3 * different.X / 8, startPoint.Y + 1 * different.Y / 8);
            var Point2 = new Point(startPoint.X + 5 * different.X / 8, startPoint.Y + 7 * different.Y / 8);

            return (Point1, Point2);
        }
    }
}
