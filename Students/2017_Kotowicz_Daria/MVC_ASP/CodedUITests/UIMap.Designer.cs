﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// OpenInternetExplorer - Use 'OpenInternetExplorerParams' to pass parameters into this method.
        /// </summary>
        public void OpenInternetExplorer()
        {

            // Go to web page 'http://go.microsoft.com/fwlink/p/?LinkId=255141' using new browser instance
            BrowserWindow gomicrosoftcomBrowser = BrowserWindow.Launch(new System.Uri(this.OpenInternetExplorerParams.Url));
        }
        
        /// <summary>
        /// OpenApp - Use 'OpenAppParams' to pass parameters into this method.
        /// </summary>
        public void OpenApp()
        {
            #region Variable Declarations
            WinMenuItem uIAdresMenuItem = this.UIMSNPolskaOutlookSkypWindow.UIKontrolkakombiadresuToolBar.UIAdresMenuItem;
            BrowserWindow uIMSNPolskaOutlookSkypWindow = this.UIMSNPolskaOutlookSkypWindow;
            #endregion

            // Click 'Adres' menu item
            Mouse.Click(uIAdresMenuItem, new Point(62, 4));

            // Go to web page 'http://localhost:9098/'
            uIMSNPolskaOutlookSkypWindow.NavigateToUrl(new System.Uri(this.OpenAppParams.UIMSNPolskaOutlookSkypWindowUrl));
        }
        
        /// <summary>
        /// ListaOsobClick
        /// </summary>
        public void ListaOsobClick()
        {
            #region Variable Declarations
            HtmlButton uIListaosóbButton = this.UIMSNPolskaOutlookSkypWindow.UIErrorPageDocument.UIListaosóbButton;
            #endregion

            // Click 'Lista osób' button
            Mouse.Click(uIListaosóbButton, new Point(21, 6));
        }
        
        /// <summary>
        /// SprAdresClick
        /// </summary>
        public void SprAdresClick()
        {
            #region Variable Declarations
            HtmlButton uISprawdźadresButton = this.UIAllMyASPNETApplicatiWindow.UIAllMyASPNETApplicatiDocument.UISprawdźadresButton;
            #endregion

            // Click 'Sprawdź adres' button
            Mouse.Click(uISprawdźadresButton, new Point(30, 16));
        }
        
        /// <summary>
        /// ClickEditAdres
        /// </summary>
        public void ClickEditAdres()
        {
            #region Variable Declarations
            HtmlButton uIEdytujButton = this.UIMyASPNETApplicationIWindow.UIMyASPNETApplicationDocument.UIEdytujButton;
            #endregion

            // Click 'Edytuj' button
            Mouse.Click(uIEdytujButton, new Point(62, 26));
        }
        
        /// <summary>
        /// EditMiastoPerson - Use 'EditMiastoPersonParams' to pass parameters into this method.
        /// </summary>
        public void EditMiastoPerson()
        {
            #region Variable Declarations
            HtmlEdit uIMiastoEdit = this.UIMyASPNETApplicationIWindow.UIMyASPNETApplicationDocument1.UIMiastoEdit;
            #endregion

            // Type 'Gdansk' in 'Miasto' text box
            uIMiastoEdit.Text = this.EditMiastoPersonParams.UIMiastoEditText;
        }
        
        /// <summary>
        /// SaveAdresPersonClick
        /// </summary>
        public void SaveAdresPersonClick()
        {
            #region Variable Declarations
            HtmlInputButton uIZapiszButton = this.UIMyASPNETApplicationIWindow.UIMyASPNETApplicationDocument1.UIZapiszButton;
            #endregion

            // Click 'Zapisz' button
            Mouse.Click(uIZapiszButton, new Point(55, 34));
        }
        
        #region Properties
        public virtual OpenInternetExplorerParams OpenInternetExplorerParams
        {
            get
            {
                if ((this.mOpenInternetExplorerParams == null))
                {
                    this.mOpenInternetExplorerParams = new OpenInternetExplorerParams();
                }
                return this.mOpenInternetExplorerParams;
            }
        }
        
        public virtual OpenAppParams OpenAppParams
        {
            get
            {
                if ((this.mOpenAppParams == null))
                {
                    this.mOpenAppParams = new OpenAppParams();
                }
                return this.mOpenAppParams;
            }
        }
        
        public virtual EditMiastoPersonParams EditMiastoPersonParams
        {
            get
            {
                if ((this.mEditMiastoPersonParams == null))
                {
                    this.mEditMiastoPersonParams = new EditMiastoPersonParams();
                }
                return this.mEditMiastoPersonParams;
            }
        }
        
        public UIMSNPolskaOutlookSkypWindow UIMSNPolskaOutlookSkypWindow
        {
            get
            {
                if ((this.mUIMSNPolskaOutlookSkypWindow == null))
                {
                    this.mUIMSNPolskaOutlookSkypWindow = new UIMSNPolskaOutlookSkypWindow();
                }
                return this.mUIMSNPolskaOutlookSkypWindow;
            }
        }
        
        public UIAllMyASPNETApplicatiWindow UIAllMyASPNETApplicatiWindow
        {
            get
            {
                if ((this.mUIAllMyASPNETApplicatiWindow == null))
                {
                    this.mUIAllMyASPNETApplicatiWindow = new UIAllMyASPNETApplicatiWindow();
                }
                return this.mUIAllMyASPNETApplicatiWindow;
            }
        }
        
        public UIMyASPNETApplicationIWindow UIMyASPNETApplicationIWindow
        {
            get
            {
                if ((this.mUIMyASPNETApplicationIWindow == null))
                {
                    this.mUIMyASPNETApplicationIWindow = new UIMyASPNETApplicationIWindow();
                }
                return this.mUIMyASPNETApplicationIWindow;
            }
        }
        #endregion
        
        #region Fields
        private OpenInternetExplorerParams mOpenInternetExplorerParams;
        
        private OpenAppParams mOpenAppParams;
        
        private EditMiastoPersonParams mEditMiastoPersonParams;
        
        private UIMSNPolskaOutlookSkypWindow mUIMSNPolskaOutlookSkypWindow;
        
        private UIAllMyASPNETApplicatiWindow mUIAllMyASPNETApplicatiWindow;
        
        private UIMyASPNETApplicationIWindow mUIMyASPNETApplicationIWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OpenInternetExplorer'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class OpenInternetExplorerParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://go.microsoft.com/fwlink/p/?LinkId=255141' using new browser instance
        /// </summary>
        public string Url = "http://go.microsoft.com/fwlink/p/?LinkId=255141";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OpenApp'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class OpenAppParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://localhost:9098/'
        /// </summary>
        public string UIMSNPolskaOutlookSkypWindowUrl = "http://localhost:9098/";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EditMiastoPerson'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class EditMiastoPersonParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Gdansk' in 'Miasto' text box
        /// </summary>
        public string UIMiastoEditText = "Gdansk";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMSNPolskaOutlookSkypWindow : BrowserWindow
    {
        
        public UIMSNPolskaOutlookSkypWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "MSN Polska - Outlook, Skype, Hotmail, Messenger, Microsoft Office Online i OneDri" +
                "ve";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("MSN Polska - Outlook, Skype, Hotmail, Messenger, Microsoft Office Online i OneDri" +
                    "ve");
            this.WindowTitles.Add("ErrorPage");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIKontrolkakombiadresuToolBar UIKontrolkakombiadresuToolBar
        {
            get
            {
                if ((this.mUIKontrolkakombiadresuToolBar == null))
                {
                    this.mUIKontrolkakombiadresuToolBar = new UIKontrolkakombiadresuToolBar(this);
                }
                return this.mUIKontrolkakombiadresuToolBar;
            }
        }
        
        public UIErrorPageDocument UIErrorPageDocument
        {
            get
            {
                if ((this.mUIErrorPageDocument == null))
                {
                    this.mUIErrorPageDocument = new UIErrorPageDocument(this);
                }
                return this.mUIErrorPageDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIKontrolkakombiadresuToolBar mUIKontrolkakombiadresuToolBar;
        
        private UIErrorPageDocument mUIErrorPageDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIKontrolkakombiadresuToolBar : WinToolBar
    {
        
        public UIKontrolkakombiadresuToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinToolBar.PropertyNames.Name] = "Kontrolka kombi adresu";
            this.WindowTitles.Add("MSN Polska - Outlook, Skype, Hotmail, Messenger, Microsoft Office Online i OneDri" +
                    "ve");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIAdresMenuItem
        {
            get
            {
                if ((this.mUIAdresMenuItem == null))
                {
                    this.mUIAdresMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIAdresMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Adres";
                    this.mUIAdresMenuItem.WindowTitles.Add("MSN Polska - Outlook, Skype, Hotmail, Messenger, Microsoft Office Online i OneDri" +
                            "ve");
                    #endregion
                }
                return this.mUIAdresMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIAdresMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIErrorPageDocument : HtmlDocument
    {
        
        public UIErrorPageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "ErrorPage";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9098/";
            this.WindowTitles.Add("ErrorPage");
            #endregion
        }
        
        #region Properties
        public HtmlButton UIListaosóbButton
        {
            get
            {
                if ((this.mUIListaosóbButton == null))
                {
                    this.mUIListaosóbButton = new HtmlButton(this);
                    #region Search Criteria
                    this.mUIListaosóbButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUIListaosóbButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIListaosóbButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Lista osób";
                    this.mUIListaosóbButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIListaosóbButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIListaosóbButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUIListaosóbButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" onclick=\"locatio";
                    this.mUIListaosóbButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "1";
                    this.mUIListaosóbButton.WindowTitles.Add("ErrorPage");
                    #endregion
                }
                return this.mUIListaosóbButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlButton mUIListaosóbButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIAllMyASPNETApplicatiWindow : BrowserWindow
    {
        
        public UIAllMyASPNETApplicatiWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "All - My ASP.NET Application";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("All - My ASP.NET Application");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAllMyASPNETApplicatiDocument UIAllMyASPNETApplicatiDocument
        {
            get
            {
                if ((this.mUIAllMyASPNETApplicatiDocument == null))
                {
                    this.mUIAllMyASPNETApplicatiDocument = new UIAllMyASPNETApplicatiDocument(this);
                }
                return this.mUIAllMyASPNETApplicatiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAllMyASPNETApplicatiDocument mUIAllMyASPNETApplicatiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIAllMyASPNETApplicatiDocument : HtmlDocument
    {
        
        public UIAllMyASPNETApplicatiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "All - My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Person/All";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9098/Person/All";
            this.WindowTitles.Add("All - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlButton UISprawdźadresButton
        {
            get
            {
                if ((this.mUISprawdźadresButton == null))
                {
                    this.mUISprawdźadresButton = new HtmlButton(this);
                    #region Search Criteria
                    this.mUISprawdźadresButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUISprawdźadresButton.SearchProperties[HtmlButton.PropertyNames.Name] = "sprAdres";
                    this.mUISprawdźadresButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Sprawdź adres";
                    this.mUISprawdźadresButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUISprawdźadresButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUISprawdźadresButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUISprawdźadresButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"sprAdres\" class=\"btn btn-default\" ";
                    this.mUISprawdźadresButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "2";
                    this.mUISprawdźadresButton.WindowTitles.Add("All - My ASP.NET Application");
                    #endregion
                }
                return this.mUISprawdźadresButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlButton mUISprawdźadresButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMyASPNETApplicationIWindow : BrowserWindow
    {
        
        public UIMyASPNETApplicationIWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "- My ASP.NET Application";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("- My ASP.NET Application");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIMyASPNETApplicationDocument UIMyASPNETApplicationDocument
        {
            get
            {
                if ((this.mUIMyASPNETApplicationDocument == null))
                {
                    this.mUIMyASPNETApplicationDocument = new UIMyASPNETApplicationDocument(this);
                }
                return this.mUIMyASPNETApplicationDocument;
            }
        }
        
        public UIMyASPNETApplicationDocument1 UIMyASPNETApplicationDocument1
        {
            get
            {
                if ((this.mUIMyASPNETApplicationDocument1 == null))
                {
                    this.mUIMyASPNETApplicationDocument1 = new UIMyASPNETApplicationDocument1(this);
                }
                return this.mUIMyASPNETApplicationDocument1;
            }
        }
        #endregion
        
        #region Fields
        private UIMyASPNETApplicationDocument mUIMyASPNETApplicationDocument;
        
        private UIMyASPNETApplicationDocument1 mUIMyASPNETApplicationDocument1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMyASPNETApplicationDocument : HtmlDocument
    {
        
        public UIMyASPNETApplicationDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "- My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Adres/DisplayById/2";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9098/Adres/DisplayById/2";
            this.WindowTitles.Add("- My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlButton UIEdytujButton
        {
            get
            {
                if ((this.mUIEdytujButton == null))
                {
                    this.mUIEdytujButton = new HtmlButton(this);
                    #region Search Criteria
                    this.mUIEdytujButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUIEdytujButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIEdytujButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Edytuj";
                    this.mUIEdytujButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIEdytujButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIEdytujButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUIEdytujButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" onclick=\"locatio";
                    this.mUIEdytujButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "2";
                    this.mUIEdytujButton.WindowTitles.Add("- My ASP.NET Application");
                    #endregion
                }
                return this.mUIEdytujButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlButton mUIEdytujButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMyASPNETApplicationDocument1 : HtmlDocument
    {
        
        public UIMyASPNETApplicationDocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "- My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Adres/Edit/2";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9098/Adres/Edit/2";
            this.WindowTitles.Add("- My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIMiastoEdit
        {
            get
            {
                if ((this.mUIMiastoEdit == null))
                {
                    this.mUIMiastoEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIMiastoEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "miasto";
                    this.mUIMiastoEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "miasto";
                    this.mUIMiastoEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Miasto";
                    this.mUIMiastoEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIMiastoEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIMiastoEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = null;
                    this.mUIMiastoEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"miasto\" id=\"miasto\" type=\"text\" va";
                    this.mUIMiastoEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    this.mUIMiastoEdit.WindowTitles.Add("- My ASP.NET Application");
                    #endregion
                }
                return this.mUIMiastoEdit;
            }
        }
        
        public HtmlInputButton UIZapiszButton
        {
            get
            {
                if ((this.mUIZapiszButton == null))
                {
                    this.mUIZapiszButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIZapiszButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUIZapiszButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIZapiszButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Zapisz";
                    this.mUIZapiszButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIZapiszButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIZapiszButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUIZapiszButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" type=\"submit\" va";
                    this.mUIZapiszButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "8";
                    this.mUIZapiszButton.WindowTitles.Add("- My ASP.NET Application");
                    #endregion
                }
                return this.mUIZapiszButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIMiastoEdit;
        
        private HtmlInputButton mUIZapiszButton;
        #endregion
    }
}
