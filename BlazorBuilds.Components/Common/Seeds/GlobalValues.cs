namespace BlazorBuilds.Components.Common.Seeds;
internal class GlobalValues
{
    public const string JavaScript_Register_Func            = "registerLostFocusHandler";
    public const string JavaScript_UnRegister_Func          = "unRegisterLostFocusHandler";
    public const string JavaScript_AddTabIndex_Func         = "addTabIndexIfScrollableContent";
    public const string JavaScript_File_Path                = "./_content/BlazorBuilds.Components/assets/js/toggletip.js";

    public const string Toggletip_KeyBoard_Close_Key        = "Escape";

    public const string Aria_Open_Label_Exception_Message   = "The aria open label for the toggletip button is required. It cannot be null, empty or whitespace";
    public const string Aria_Close_Label_Exception_Message  = "The aria close label for the contents close button is required. It cannot be null, empty or whitespace";

    public const string ToggleTip_Class                     = "toggletip";
    public const string ToggleTip_Open_Wrapper_Class        = $"{ToggleTip_Class}__open-wrapper";
    public const string ToggleTip_Content_Class             = $"{ToggleTip_Class}__content";
    public const string ToggleTip_Footer_Class              = $"{ToggleTip_Class}__footer";
    public const string ToggleTip_Content_Area_Class        = $"{ToggleTip_Class}__content-area";
    public const string ToggleTip_Opener_Class              = $"{ToggleTip_Class}__opener";
    public const string ToggleTip_Closer_Class              = $"{ToggleTip_Class}__closer";
    public const string ToggleTip_Icon_Class                = $"{ToggleTip_Class}__icon";
    public const string ToggleTip_Label_Class               = $"{ToggleTip_Class}__label";
    public const string ToggleTip_Content_Area_Hidden_Class = $"{ToggleTip_Content_Area_Class}--hidden";
    public const string ToggleTip_Content_Area_Left_Class   = $"{ToggleTip_Content_Area_Class}--left";
    public const string ToggleTip_Content_Area_Right_Class  = $"{ToggleTip_Content_Area_Class}--right";
    public const string ToggleTip_Content_Area_Top_Class    = $"{ToggleTip_Content_Area_Class}--top";
    public const string ToggleTip_Content_Area_Bottom_Class = $"{ToggleTip_Content_Area_Class}--bottom";

    public const string ToggleTip_Icon_Name_Class           = "toggletip-icon";
    public const string ToggleTip_Close_Icon_Name_Class     = "close-tooltip-icon";

    public const string ToggleTip_Max_Width_Var_Name        = "--_toggletip-max-width";
    public const string ToggleTip_Max_Height_Var_Name       = "--_toggletip-max-height";

    public const string ToggleTip_Medium_Width_Value        = "30vw";
    public const string ToggleTip_Large_Width_Value         = "40vw";
    public const string ToggleTip_Medium_Height_Value       = "50vh";
    public const string ToggleTip_Large_Height_Value        = "60vh";

    public const string Style_As_Dark                       = "dark";
    public const string Style_As_Light                      = "light";

    public static string? GetStyleAsValue(StyleAs styleAs)

        => styleAs switch
        {
            StyleAs.OnLight => Style_As_Light,
            StyleAs.OnDark => Style_As_Dark,
            _ => null
        };
}
