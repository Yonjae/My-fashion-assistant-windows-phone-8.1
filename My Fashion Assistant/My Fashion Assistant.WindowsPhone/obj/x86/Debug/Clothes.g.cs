﻿

#pragma checksum "F:\Users\Achref\Desktop\My fashion assistant version 1\My Fashion Assistant\My Fashion Assistant\My Fashion Assistant.WindowsPhone\Clothes.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F16F6E24142E5826AD9A83499E39C30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_Fashion_Assistant
{
    partial class Assistant : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 20 "..\..\..\Clothes.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Camera_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 24 "..\..\..\Clothes.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Save_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 25 "..\..\..\Clothes.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.allClothes_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 59 "..\..\..\Clothes.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerEntered += this.txtClothesName_PointerEntered;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 55 "..\..\..\Clothes.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.imagePreivew_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


