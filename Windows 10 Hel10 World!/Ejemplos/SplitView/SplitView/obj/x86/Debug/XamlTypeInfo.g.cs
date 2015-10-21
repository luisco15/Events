﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace SplitView
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace SplitView.SplitView_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[23];
            _typeNameTable[0] = "SplitView.ViewModels.Base.ViewModelLocator";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "SplitView.ViewModels.MainViewModel";
            _typeNameTable[3] = "SplitView.ViewModels.Base.ViewModelBase";
            _typeNameTable[4] = "SplitView.ViewModels.HomeViewModel";
            _typeNameTable[5] = "SplitView.ViewModels.StandingsViewModel";
            _typeNameTable[6] = "SplitView.ViewModels.AboutViewModel";
            _typeNameTable[7] = "Windows.UI.Color";
            _typeNameTable[8] = "System.ValueType";
            _typeNameTable[9] = "Byte";
            _typeNameTable[10] = "SplitView.Converters.AlternatingIndexConverter";
            _typeNameTable[11] = "SplitView.Converters.ToUpperConverter";
            _typeNameTable[12] = "SplitView.Views.Base.PageBase";
            _typeNameTable[13] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[14] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[15] = "Windows.UI.Xaml.Controls.Frame";
            _typeNameTable[16] = "SplitView.Views.AboutView";
            _typeNameTable[17] = "SplitView.Views.HomeView";
            _typeNameTable[18] = "SplitView.Behaviors.ItemClickCommandBehavior";
            _typeNameTable[19] = "System.Windows.Input.ICommand";
            _typeNameTable[20] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[21] = "SplitView.Views.MainView";
            _typeNameTable[22] = "SplitView.Views.StandingsView";

            _typeTable = new global::System.Type[23];
            _typeTable[0] = typeof(global::SplitView.ViewModels.Base.ViewModelLocator);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::SplitView.ViewModels.MainViewModel);
            _typeTable[3] = typeof(global::SplitView.ViewModels.Base.ViewModelBase);
            _typeTable[4] = typeof(global::SplitView.ViewModels.HomeViewModel);
            _typeTable[5] = typeof(global::SplitView.ViewModels.StandingsViewModel);
            _typeTable[6] = typeof(global::SplitView.ViewModels.AboutViewModel);
            _typeTable[7] = typeof(global::Windows.UI.Color);
            _typeTable[8] = typeof(global::System.ValueType);
            _typeTable[9] = typeof(global::System.Byte);
            _typeTable[10] = typeof(global::SplitView.Converters.AlternatingIndexConverter);
            _typeTable[11] = typeof(global::SplitView.Converters.ToUpperConverter);
            _typeTable[12] = typeof(global::SplitView.Views.Base.PageBase);
            _typeTable[13] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[14] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[15] = typeof(global::Windows.UI.Xaml.Controls.Frame);
            _typeTable[16] = typeof(global::SplitView.Views.AboutView);
            _typeTable[17] = typeof(global::SplitView.Views.HomeView);
            _typeTable[18] = typeof(global::SplitView.Behaviors.ItemClickCommandBehavior);
            _typeTable[19] = typeof(global::System.Windows.Input.ICommand);
            _typeTable[20] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[21] = typeof(global::SplitView.Views.MainView);
            _typeTable[22] = typeof(global::SplitView.Views.StandingsView);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_ViewModelLocator() { return new global::SplitView.ViewModels.Base.ViewModelLocator(); }
        private object Activate_4_HomeViewModel() { return new global::SplitView.ViewModels.HomeViewModel(); }
        private object Activate_5_StandingsViewModel() { return new global::SplitView.ViewModels.StandingsViewModel(); }
        private object Activate_10_AlternatingIndexConverter() { return new global::SplitView.Converters.AlternatingIndexConverter(); }
        private object Activate_11_ToUpperConverter() { return new global::SplitView.Converters.ToUpperConverter(); }
        private object Activate_12_PageBase() { return new global::SplitView.Views.Base.PageBase(); }
        private object Activate_16_AboutView() { return new global::SplitView.Views.AboutView(); }
        private object Activate_17_HomeView() { return new global::SplitView.Views.HomeView(); }
        private object Activate_21_MainView() { return new global::SplitView.Views.MainView(); }
        private object Activate_22_StandingsView() { return new global::SplitView.Views.StandingsView(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SplitView.SplitView_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  SplitView.ViewModels.Base.ViewModelLocator
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_ViewModelLocator;
                userType.AddMemberName("MainViewModel");
                userType.AddMemberName("HomeViewModel");
                userType.AddMemberName("StandingsViewModel");
                userType.AddMemberName("AboutViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  SplitView.ViewModels.MainViewModel
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  SplitView.ViewModels.Base.ViewModelBase
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  SplitView.ViewModels.HomeViewModel
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  SplitView.ViewModels.StandingsViewModel
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  SplitView.ViewModels.AboutViewModel
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  Windows.UI.Color
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.AddMemberName("A");
                userType.AddMemberName("B");
                userType.AddMemberName("G");
                userType.AddMemberName("R");
                xamlType = userType;
                break;

            case 8:   //  System.ValueType
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 9:   //  Byte
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 10:   //  SplitView.Converters.AlternatingIndexConverter
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_10_AlternatingIndexConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  SplitView.Converters.ToUpperConverter
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_11_ToUpperConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  SplitView.Views.Base.PageBase
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_PageBase;
                userType.AddMemberName("SplitViewFrame");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 14:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 15:   //  Windows.UI.Xaml.Controls.Frame
                xamlType = new global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 16:   //  SplitView.Views.AboutView
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.Views.Base.PageBase"));
                userType.Activator = Activate_16_AboutView;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  SplitView.Views.HomeView
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.Views.Base.PageBase"));
                userType.Activator = Activate_17_HomeView;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  SplitView.Behaviors.ItemClickCommandBehavior
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("Command");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  System.Windows.Input.ICommand
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, null);
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 20:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 21:   //  SplitView.Views.MainView
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.Views.Base.PageBase"));
                userType.Activator = Activate_21_MainView;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  SplitView.Views.StandingsView
                userType = new global::SplitView.SplitView_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SplitView.Views.Base.PageBase"));
                userType.Activator = Activate_22_StandingsView;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_ViewModelLocator_MainViewModel(object instance)
        {
            var that = (global::SplitView.ViewModels.Base.ViewModelLocator)instance;
            return that.MainViewModel;
        }
        private object get_1_ViewModelLocator_HomeViewModel(object instance)
        {
            var that = (global::SplitView.ViewModels.Base.ViewModelLocator)instance;
            return that.HomeViewModel;
        }
        private object get_2_ViewModelLocator_StandingsViewModel(object instance)
        {
            var that = (global::SplitView.ViewModels.Base.ViewModelLocator)instance;
            return that.StandingsViewModel;
        }
        private object get_3_ViewModelLocator_AboutViewModel(object instance)
        {
            var that = (global::SplitView.ViewModels.Base.ViewModelLocator)instance;
            return that.AboutViewModel;
        }
        private object get_4_Color_A(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.A;
        }
        private void set_4_Color_A(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.A = (global::System.Byte)Value;
        }
        private object get_5_Color_B(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.B;
        }
        private void set_5_Color_B(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.B = (global::System.Byte)Value;
        }
        private object get_6_Color_G(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.G;
        }
        private void set_6_Color_G(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.G = (global::System.Byte)Value;
        }
        private object get_7_Color_R(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.R;
        }
        private void set_7_Color_R(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.R = (global::System.Byte)Value;
        }
        private object get_8_PageBase_SplitViewFrame(object instance)
        {
            var that = (global::SplitView.Views.Base.PageBase)instance;
            return that.SplitViewFrame;
        }
        private void set_8_PageBase_SplitViewFrame(object instance, object Value)
        {
            var that = (global::SplitView.Views.Base.PageBase)instance;
            that.SplitViewFrame = (global::Windows.UI.Xaml.Controls.Frame)Value;
        }
        private object get_9_ItemClickCommandBehavior_Command(object instance)
        {
            return global::SplitView.Behaviors.ItemClickCommandBehavior.GetCommand((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_9_ItemClickCommandBehavior_Command(object instance, object Value)
        {
            global::SplitView.Behaviors.ItemClickCommandBehavior.SetCommand((global::Windows.UI.Xaml.DependencyObject)instance, (global::System.Windows.Input.ICommand)Value);
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SplitView.SplitView_XamlTypeInfo.XamlMember xamlMember = null;
            global::SplitView.SplitView_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "SplitView.ViewModels.Base.ViewModelLocator.MainViewModel":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelLocator");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "MainViewModel", "SplitView.ViewModels.MainViewModel");
                xamlMember.Getter = get_0_ViewModelLocator_MainViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "SplitView.ViewModels.Base.ViewModelLocator.HomeViewModel":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelLocator");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "HomeViewModel", "SplitView.ViewModels.HomeViewModel");
                xamlMember.Getter = get_1_ViewModelLocator_HomeViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "SplitView.ViewModels.Base.ViewModelLocator.StandingsViewModel":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelLocator");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "StandingsViewModel", "SplitView.ViewModels.StandingsViewModel");
                xamlMember.Getter = get_2_ViewModelLocator_StandingsViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "SplitView.ViewModels.Base.ViewModelLocator.AboutViewModel":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SplitView.ViewModels.Base.ViewModelLocator");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "AboutViewModel", "SplitView.ViewModels.AboutViewModel");
                xamlMember.Getter = get_3_ViewModelLocator_AboutViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "Windows.UI.Color.A":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "A", "Byte");
                xamlMember.Getter = get_4_Color_A;
                xamlMember.Setter = set_4_Color_A;
                break;
            case "Windows.UI.Color.B":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "B", "Byte");
                xamlMember.Getter = get_5_Color_B;
                xamlMember.Setter = set_5_Color_B;
                break;
            case "Windows.UI.Color.G":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "G", "Byte");
                xamlMember.Getter = get_6_Color_G;
                xamlMember.Setter = set_6_Color_G;
                break;
            case "Windows.UI.Color.R":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "R", "Byte");
                xamlMember.Getter = get_7_Color_R;
                xamlMember.Setter = set_7_Color_R;
                break;
            case "SplitView.Views.Base.PageBase.SplitViewFrame":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SplitView.Views.Base.PageBase");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "SplitViewFrame", "Windows.UI.Xaml.Controls.Frame");
                xamlMember.Getter = get_8_PageBase_SplitViewFrame;
                xamlMember.Setter = set_8_PageBase_SplitViewFrame;
                break;
            case "SplitView.Behaviors.ItemClickCommandBehavior.Command":
                userType = (global::SplitView.SplitView_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SplitView.Behaviors.ItemClickCommandBehavior");
                xamlMember = new global::SplitView.SplitView_XamlTypeInfo.XamlMember(this, "Command", "System.Windows.Input.ICommand");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_9_ItemClickCommandBehavior_Command;
                xamlMember.Setter = set_9_ItemClickCommandBehavior_Command;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::SplitView.SplitView_XamlTypeInfo.XamlSystemBaseType
    {
        global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SplitView.SplitView_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
