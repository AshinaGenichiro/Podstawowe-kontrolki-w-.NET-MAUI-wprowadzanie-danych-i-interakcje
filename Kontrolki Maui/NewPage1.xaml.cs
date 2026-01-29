namespace Kontrolki_Maui;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private async void aggredOnAlert(object sender, EventArgs e)
    {
        var acceptedServices = new List<string>();

        bool PushNotification = false;
        bool EmailNotification = false;
        bool SmsNotification = false;
        bool darkmode = false;
        bool shareData = false;
        bool personalisedAds = false;
        
        if (PushNotificationSwitch.IsToggled)
        {
            PushNotification = true;
            acceptedServices.Add("Push Notifications");
        }
        if(EmilNotificationSwitch.IsToggled)
        {
            EmailNotification = true;
            acceptedServices.Add("Email Notifications");
        }
        if (SMSNotificationSwitch.IsToggled)
        {
            SmsNotification = true;
            acceptedServices.Add("SMS Notifications");
        }
        if (darkModeSwitch.IsToggled)
        {
            darkmode = true;
            acceptedServices.Add("Dark Mode");
        }
        if (shareDataCheckBox.IsChecked)
        {
            shareData = true;
            acceptedServices.Add("Data Sharing");
        }
        if (personalizedAdsCheckBox.IsChecked)
        {
            personalisedAds = true;
            acceptedServices.Add("Personalized Ads");
        }
        string acceptedServicesString = string.Join(", ", acceptedServices);
        await DisplayAlertAsync(
             "Us³ugi na ktore sie zgodzi³eœ:",
              acceptedServicesString,
              "OK");
        

    }
}
//*****************************************************
 //nazwa funkcji: aggredOnAlert
 // opis funkcji: Sprawdza na jakie us³ugi u¿ytkownik sie zgodzi³ i pokazuje je w alercie
 // parametry wejœciowe: object sender, EventArgs e(standardowe parametry dla zdarzeñ object sender odnosi sie do obiektu
 // ktory wywo³a³ zdarzenie, a EventsArgs e zawiera dane zdarzenia)
 // zwracany typ : void (brak) 
 //  autor: Kacper Z.
 //***************************************************