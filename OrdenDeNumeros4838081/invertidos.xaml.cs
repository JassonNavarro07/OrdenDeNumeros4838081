namespace OrdenDeNumeros4838081;

///<Summary>
///<Createddate>29/05/2024</createddate>
///<company></company>
///<lastmodificationdate>02/06/2024</lastmodificationdate>
///<lastmodificationdescription>
///
///</lastmodificationdescription>
//////<lastmodifierautor>Jasson Navarro</lastmodifierautor>
///</Summary>


public partial class Invertidos : ContentPage
{
	public Invertidos()
	{
		InitializeComponent();
	}


    #region Evento del button
    
    private void Button_Clicked_1(object sender, EventArgs e)
    {
       if(!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text)
            && !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text))
       {
            //declarasion de variables
            string resultado, numero1,numero2,numero3,numero4;
            numero1 = Convert.ToString(entry1.Text);
            numero2 = Convert.ToString(entry2.Text);
            numero3 = Convert.ToString(entry3.Text);
            numero4 = Convert.ToString(entry4.Text);
            resultado = entry4.Text + entry3.Text + entry2.Text + entry1.Text ;
            entry5.Text = resultado.ToString();
       }
       else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "ok");
        }
    }
    #endregion
}