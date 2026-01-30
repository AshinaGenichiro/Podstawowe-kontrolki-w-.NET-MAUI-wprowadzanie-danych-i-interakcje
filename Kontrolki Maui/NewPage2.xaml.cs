using Java.Lang;

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
			if(int.Parse(numberOfPeopleEntry.Text) >=2 && typeof(numberOfPeopleEntry.text) == typeof(Number) )
			{

			double tipProcentage = tipPercentageSlider.Value;
			double value = double.Parse(billEntry.Text);
			double tipValue = value * (tipProcentage / 100);
			double totalBill = value + tipValue;
			int numberOfPeople = int.Parse(numberOfPeopleEntry.Text);
			double amountPerPerson = totalBill / numberOfPeople;
			amountPerPersonLabel.Text = $"Kwota na osobê: {amountPerPerson:F2}";
            totalBillLabel.Text = $"Ca³kowity rachunek: {totalBill:F2}";
			}else
			{
                amountPerPersonLabel.Text = $"Nie mozesz rozdzieliæ kwoty na jedn¹ osobê";
            }
        }
		}

	}
