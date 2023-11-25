namespace Animations;

public partial class ScalePage : ContentPage
{
    public ScalePage()
    {
        InitializeComponent();
    }

    private async void OnClickedAsync(object sender, EventArgs e)
    {
        //await BotImg.ScaleTo(0, easing:Easing.SpringIn);
        //      await Task.Delay(1000);
        //      await BotImg.ScaleTo(1, easing: Easing.SpringOut);
        Animation animation = new Animation(v => BotImg.Scale = v, 1, 2);
        animation.Commit(this, "simp",rate:200, length:2000, easing:Easing.CubicInOut, finished:(v,r)=>
        {
            BotImg.Scale = 1;
        }, repeat: () => { return true; });

        this.AbortAnimation("simp");
    }
}

