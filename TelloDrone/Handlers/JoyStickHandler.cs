using System;
using Android;
using Android.OS;
using Android.Content;
using Android.Content.Res;
using Android.Widget;
using Java.Util.Regex;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using Android.Graphics.Drawables;
using Java.Util.Logging;
using AndroidX.AppCompat.Widget;
using FormsJoystick.CustomControls;
using FormsJoystick.Droid.JoystickAndroidCustomControl;

namespace TelloDrone;

public partial class JoyStickHandler : ViewHandler<JoystickControl, JoystickMainLayout>
{
    private JoystickMainLayout _JoystickMainLayout;
    private JoystickControl control = new JoystickControl();

    protected override JoystickMainLayout CreatePlatformView()
    {
        _JoystickMainLayout = new JoystickMainLayout(Context);
        //SetNativeControl(_JoystickMainLayout);


        control = VirtualView;
        // Configure the control and subscribe to event handlers
        _JoystickMainLayout.AddTouchListener((xposition, yposition, distance, angle) =>
        {
            
            control.Xposition = xposition;
            control.Yposition = yposition;
            control.Distance = distance;
            control.Angle = angle;
        });
        return _JoystickMainLayout;
    }
    public JoyStickHandler():base(PropertyMapper)
    {

    }

    

    public static PropertyMapper<JoystickControl, JoyStickHandler> PropertyMapper = new PropertyMapper<JoystickControl, JoyStickHandler>(ViewHandler.ViewMapper)
    {
        
    };
}



