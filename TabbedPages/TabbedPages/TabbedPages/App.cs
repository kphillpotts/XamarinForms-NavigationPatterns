using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPages
{
public class App : Application
{
    public TabbedPage tabContainer = new TabbedPage();
    public App()
    {
        // tabbed page 
        tabContainer.Title="Star Trek";
        tabContainer.Children.Add(new ContentPage () {Title="Humans"});
        tabContainer.Children.Add(new ContentPage () {Title="Klingons"});
        tabContainer.Children.Add(new ContentPage () { Title = "Vulcans" });

        tabContainer.CurrentPageChanged += tabContainer_CurrentPageChanged;
        

        // The root page of your application
        MainPage = tabContainer;
    }

    void tabContainer_CurrentPageChanged(object sender, EventArgs e)
    {
        Page b = tabContainer.CurrentPage;
        
        //throw new NotImplementedException();
    }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
