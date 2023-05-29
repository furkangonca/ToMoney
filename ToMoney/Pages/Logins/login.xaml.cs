using System.Collections.Generic;


namespace ToMoney.Pages;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
		dilpaket();
	}

    public static int langID=0;
	
    public async void dilpaket()
	{


		cmb_lang.Items.Clear();
		cmb_lang.Items.Add("English");
		cmb_lang.Items.Add("Türkçe");


    }

	private void cmb_lang_action()
	{
		
		if(langID==0)
		{
            lbl_title.Text = "Welcome ToMoney";
            lbl_subtitle.Text = "Everything is very easy";
            ent_username.Placeholder = "Username";
            ent_password.Placeholder = "Password";
            btn_login.Text = "Login";
            btn_sign.Text = "Sign up";
        }

		if(langID == 1)
		{
			lbl_title.Text = "Hoşgeldiniz ToMoney";
			lbl_subtitle.Text = "Kolay Kullanım";
			ent_username.Placeholder = "Kullanıcı Adı";
			ent_password.Placeholder = "Parola";
			btn_login.Text = "Giriş";
			btn_sign.Text = "Üye Ol";
		}
	}

    private void cmb_lang_change(System.Object sender, System.EventArgs e)
    {
		
		int index = cmb_lang.SelectedIndex;
		if (index == 0)
		{
			langID = 0;
		}
		if(index == 1)
		{
			langID = 1;
		}

		cmb_lang_action();

    }

    private async void btn_signup_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new Pages.Logins.signup());
    }

   private async void btn_login_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PushAsync(new ToDoList());
    }
}
