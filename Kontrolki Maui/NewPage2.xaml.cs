

namespace Kontrolki_Maui;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
	private void showTip10(object sender, EventArgs e)
	{
		tipPercentageSlider.Value = 10;
	}
	private void showTip15(object sender, EventArgs e)
	{
		tipPercentageSlider.Value = 15;
	}
	private void showTip20(object sender, EventArgs e)
	{
		tipPercentageSlider.Value = 20;
	}
	public void shareBill(object sender, EventArgs e)
	{
		if (shareBillSwitch.IsToggled == true)
		{
			amountPerPersonLabel.IsVisible = true;
			numberOfPeopleEntry.IsVisible = true;
		}
		else
		{
			amountPerPersonLabel.IsVisible = false;
			numberOfPeopleEntry.IsVisible = false;
		}
	}

	private void calculateTipEntry(object sender, TextChangedEventArgs e)
	{
		UpdateTip();
	}

	private void calculateTipSlider(object sender, ValueChangedEventArgs e)
	{
		UpdateTip();
	}
	private void UpdateTip()
	{
		if (!string.IsNullOrEmpty(billEntry.Text))
		{
			double tipProcentage = tipPercentageSlider.Value;
			double value = double.Parse(billEntry.Text);
			double result = value * (tipProcentage / 100);
            totalBillLabel.Text = $"Ca³kowity rachunek: {value+result:F2}";
            totalTipLabel.Text = $"Napiwek: {result:F2}";
		}

		if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(numberOfPeopleEntry.Text))
		{
			if(int.Parse(numberOfPeopleEntry.Text) >=2)
			{
			int numberOfPeople = int.Parse(numberOfPeopleEntry.Text);
			double tipProcentage = tipPercentageSlider.Value;
			double value = double.Parse(billEntry.Text);
			double tipValue = value * (tipProcentage / 100);
			double totalBill = value + tipValue;
			double amountPerPerson = totalBill / numberOfPeople;
			amountPerPersonLabel.Text = $"Kwota na osobê: {amountPerPerson:F2}";
            totalBillLabel.Text = $"Ca³kowity rachunek: {totalBill:F2}";
			}
			else
			{
                amountPerPersonLabel.Text = $"Nie mozesz rozdzieliæ kwoty na jedn¹ osobê";
            }
        }
		}

	}
/************************************************
 * Nazwa funkcji: ShowTip
 * Opis funkcji: funkcja zmienia wartosc napiwku w sliderze
 * parametry wejœciowe: object sender, EventArgs e(standardowe parametry dla zdarzeñ object sender odnosi sie do obiektu
 * ktory wywo³a³ zdarzenie, a EventsArgs e zawiera dane zdarzenia)
 *
 *zwracany typ: brak(void)
 *autor kacper
 * *********************************************
 * Nazwa funkcji:ShareBill
 * Opis funckji: po naciœniêciu na switcha funkcja umo¿liwa podzia³ rachunku na x osób
 * parametry wejœciowe: object sender, EventArgs e(standardowe parametry dla zdarzeñ object sender odnosi sie do obiektu
 * ktory wywo³a³ zdarzenie, a EventsArgs e zawiera dane zdarzenia * 
 * 
 * zwracany typ brak void
 * autor kacper 
 * ***********************************************
 * Nazwa funckji: UpdateTip
 * opis funkcji:funkcja olbicza napiwek oraz rozdziela go na x osób, je¿eli ktoœ sie zgodzi³ na 
 * podzia³ rachunku
 * parametry brak
 * autor kacper
 * ************************************************
 * nazwa funkcji: calculateTipEntry
 * opis funkcji funkcja aktualizuje wartosci dla dwóch akcji zmiany wartosci i zmiany tekstu
 * parametry ValueChangedEventArgs gdy zmieni sie wartosc slidera,TextChangedEventArgs gdy zmieni sie ilosc osob,b¹dŸ cena 
 * autor kacper 
 */