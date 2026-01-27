namespace Kontrolki_Maui
{
    public partial class MainPage : ContentPage
    {
 
       public MainPage()
        {
            InitializeComponent();
           
        }
        private async void formAlert(object sender, EventArgs e)
        {
            bool entryNameValidation = false;
            bool entrySurnameValidation = false;
            bool entryEmailValidation = false;
            bool entryMessageValidation = false;
            bool subjectEntryValidation = false;
            bool messageEditorValidation = false;
            bool entryMessage = false;
            var buttonAlert = sender as Button;

            if(string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                entryNameValidation = true;
                await DisplayAlertAsync(
                    "Błąd",
                    "Proszę uzupełnić pole Imię",
                    "OK");
            }
            else if (string.IsNullOrWhiteSpace(surnameEntry.Text))
            {
                entrySurnameValidation = true;
                await DisplayAlertAsync(
                    "Błąd",
                    "Proszę uzupełnić pole Nazwisko",
                    "OK");
            }
            else if (string.IsNullOrWhiteSpace(emailEntry.Text))
            {
                entryEmailValidation = true;
                await DisplayAlertAsync(
                    "Błąd",
                    "Proszę uzupełnić pole Email",
                    "OK");
            }
            else if (string.IsNullOrWhiteSpace(subjectEntry.Text))
            {
                subjectEntryValidation = true;
                await DisplayAlertAsync(
                    "Błąd",
                    "Proszę uzupełnić pole Temat",
                    "OK");
            }
            else if (string.IsNullOrWhiteSpace(messageEditor.Text))
            {
                messageEditorValidation = true;
                await DisplayAlertAsync(
                    "Błąd",
                    "Proszę uzupełnić pole Wiadomość",
                    "OK");
            }
            else
            {
                entryMessage = true;
            }
            if (buttonAlert != null && entryMessage == true)
            {
                await DisplayAlertAsync(
                    "Wysłano",
                    "Poprawnie uzupełniłeś formularz, został on wysłany",
                    "OK");
            }
        }

    }
}

//*****************************************************
//nazwa funkcji: formAlert
// opis funkcji: wyświetla alert po naciśnięciu przycisku
// parametry wejściowe: object sender, EventArgs e(standardowe parametry dla zdarzeń object sender odnosi sie do obiektu
// ktory wywołał zdarzenie, a EventsArgs e zawiera dane zdarzenia)
// zwracany typ : void(brak) 
//  autor: Kacper Z.
//***************************************************