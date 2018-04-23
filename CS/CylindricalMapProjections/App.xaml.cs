// Developer Express Code Central Example:
// How to provide cylindrical equal-area projections of a map
// 
// This example illustrates how to get map equal-area projections (Lambert,
// Behrmann, Tristan Edwards, Peters, Gall orthographic and Balthasart) for the
// shapes loaded from the Shapefiles (Countries.shp, Countries.dbf).
// 
// To
// accomplish this task, create an EqualAreaProjection
// (http://help.devexpress.com/#Silverlight/clsDevExpressXpfMapEqualAreaProjectiontopic)
// object and assign it to the VectorLayerBase.MapProjection
// (http://help.devexpress.com/#Silverlight/DevExpressXpfMapVectorLayerBase_MapProjectiontopic)
// property. Then, specify the Width/height aspect ratio for each equal area
// projection using the VectorLayerBase.InitialMapSize
// (http://help.devexpress.com/#Silverlight/DevExpressXpfMapVectorLayerBase_InitialMapSizetopic)
// property. To learn more about the equal-area projections, see Cylindrical
// equal-area projection
// (http://en.wikipedia.org/wiki/Cylindrical_equal-area_projection).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4397

using System;
using System.Windows;

namespace CylindricalMapProjections
{
    public partial class App : Application
    {

        public App()
        {
            this.Startup += this.Application_Startup;
            this.Exit += this.Application_Exit;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            this.RootVisual = new MainPage();
        }

        private void Application_Exit(object sender, EventArgs e)
        {

        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // If the app is running outside of the debugger then report the exception using
            // the browser's exception mechanism. On IE this will display it a yellow alert 
            // icon in the status bar and Firefox will display a script error.
            if (!System.Diagnostics.Debugger.IsAttached)
            {

                // NOTE: This will allow the application to continue running after an exception has been thrown
                // but not handled. 
                // For production applications this error handling should be replaced with something that will 
                // report the error to the website and stop the application.
                e.Handled = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
            }
        }

        private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e)
        {
            try
            {
                string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
                errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
            }
            catch (Exception)
            {
            }
        }
    }
}
