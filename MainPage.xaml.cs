using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Cinema
{
  
    public sealed partial class MainPage : Page
    {
        Compositor _compositor;
        ContainerVisual _root;

        void DrawRectangles()
        {
            SpriteVisual tick;
            //center
                tick = _compositor.CreateSpriteVisual();
                tick.Size = new Vector2(60.0f, 30.0f);
                tick.Brush = _compositor.CreateColorBrush(Colors.Black);
                tick.Offset = new Vector3(80.0f, 50.0f, -5f);
                tick.CenterPoint = new Vector3(30.0f, 15.0f, 0f);
                
            _root.Children.InsertAtTop(tick);
            
            
            //top
                tick = _compositor.CreateSpriteVisual();
                tick.Size = new Vector2(60.0f, 20.0f);
                tick.Brush = _compositor.CreateColorBrush(Colors.Green);
                tick.Offset = new Vector3(80.0f, 30.0f, -5);
                tick.CenterPoint = new Vector3(30.0f, 10.0f, 0);
                //X rotation
                //tick.RotationAxis = new Vector3(1, 0, 0);
                //tick.RotationAngleInDegrees = 90f;
                _root.Children.InsertAtTop(tick);
            //bottom
                tick = _compositor.CreateSpriteVisual();
                tick.Size = new Vector2(60.0f, 20.0f);
                tick.Brush = _compositor.CreateColorBrush(Colors.Yellow);
                tick.Offset = new Vector3(80.0f, 70.0f, -5);
                tick.CenterPoint = new Vector3(30.0f, 10.0f, 0);
                //X rotation
                //tick.RotationAxis = new Vector3(1, 0, 0);
                //tick.RotationAngleInDegrees = -30f;
                _root.Children.InsertAtTop(tick);
            //left
                tick = _compositor.CreateSpriteVisual();
                tick.Size = new Vector2(50.0f, 80.0f);
                tick.Brush = _compositor.CreateColorBrush(Colors.Red);
                tick.Offset = new Vector3(53.0f, 25.0f, -5);
                tick.CenterPoint = new Vector3(15.0f, 15.0f, 0);
                //Y rotation
                tick.RotationAxis = new Vector3(0, 1, 0);
                tick.RotationAngleInDegrees = 0.5f;
                _root.Children.InsertAtTop(tick);
            //right
                tick = _compositor.CreateSpriteVisual();
                tick.Size = new Vector2(30.0f, 80.0f);
                tick.Brush = _compositor.CreateColorBrush(Colors.Blue);
                tick.Offset = new Vector3(147f, 25.0f, -5);
                tick.CenterPoint = new Vector3(15.0f, 15.0f, 0);
                //Y rotation
                tick.RotationAxis = new Vector3(0, 1, 0);
                tick.RotationAngleInDegrees = -1f;
                _root.Children.InsertAtTop(tick);


            Matrix4x4 persp = Matrix4x4.CreatePerspective(0.5f, 0.5f, 1, 100);
            _root.TransformMatrix = persp;
          
           
           

        }
        void InitializeComposition()
        {
            _root = Container.GetVisual();
            _compositor = _root.Compositor;

            DrawRectangles();
           

        }
        public MainPage()
        {
            this.InitializeComponent();
            InitializeComposition();
        }
    }
}
