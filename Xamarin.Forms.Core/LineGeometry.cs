﻿namespace Xamarin.Forms
{
    public class LineGeometry : Geometry
    {
        public static readonly BindableProperty StartPointProperty =
            BindableProperty.Create(nameof(StartPoint), typeof(Point), typeof(LineGeometry), new Point());

        public static readonly BindableProperty EndPointProperty =
            BindableProperty.Create(nameof(EndPoint), typeof(Point), typeof(LineGeometry), new Point());

        public Point StartPoint
        {
            set { SetValue(StartPointProperty, value); }
            get { return (Point)GetValue(StartPointProperty); }
        }

        public Point EndPoint
        {
            set { SetValue(StartPointProperty, value); }
            get { return (Point)GetValue(StartPointProperty); }
        }
    }
}