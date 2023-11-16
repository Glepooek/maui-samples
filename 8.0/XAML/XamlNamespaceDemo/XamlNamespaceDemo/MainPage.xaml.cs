namespace XamlNamespaceDemo;
using XamlNamespaceDemo.Controls;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		// 自定义命名空间架构后，必须要显示引用一下命名空间
		// 不优雅
		CustomButton customButton = new CustomButton();
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void CustomButton_Clicked(object sender, EventArgs e)
	{

	}
}

