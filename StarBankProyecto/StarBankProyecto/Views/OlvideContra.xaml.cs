using System;
using System.ComponentModel.DataAnnotations;

using ProyectoFinal.Models;


using ProyectoFinal.Api;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Mail;

namespace StarBankProyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
public partial class OlvideContra : ContentPage
{
    public OlvideContra()
    {
        InitializeComponent();
    }

    private async void changeContra(Object sender, EventArgs e)
    {
        //Agregar metodo para enviar codigo al correo 
        //await Navigation.PushAsync(new Views.CambiarContra());
        if (txtEmail.Text == null || txtEmail.Text == "")
        {
            await DisplayAlert("Aviso", "Ingrese el correo electrónico ligado a su cunta para poder recuperarla", "OK"); return;
        }
        else if (!validateEmail(txtEmail.Text))
        {
            await DisplayAlert("Aviso", "El correo electrónico que ha ingresado no es válido", "OK"); return;
        }

            var usuario = await App.DBase.obtenerUsuario(3, txtEmail.Text);
            if (usuario != null)
            {
                if (usuario.CodigoVerificacion == "")
                {
                    usuario.ContraseñaTemporal = CodigoAleatorio();
                    await App.DBase.UsuarioSave(usuario);
                    await UsuarioApi.UpdateUsuario(usuario);
                    enviarcorreo(usuario);
                    await DisplayAlert("Envío exitoso", "Revisa tu bandeja de entrada y sigue las instrucciones para habilitar tu nueva contraseña.", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "Eres un usuario nuevo, debes iniciar sesión por lo menos una vez para cambiar tu contraseña.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Aviso", "El correo electrónico que ingresaste no está ligado a ninguna cuenta existente.", "OK");
            }


        }// fin de la funcion

        void enviarcorreo(Usuario user)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("wbordas.56@gmail.com");
                mail.To.Add(user.Email);
                mail.Subject = "STARBANK | Código de verificación";
                mail.Body = "<html><body><p>¡Hola <b>" + user.NombreCompleto + "!</b></p><br><br><p>Gracias por elegir STARBANK.</p><br><br><p>Esta es tu contraseña temporal: <b>" + user.ContraseñaTemporal + "<b></p><br><p>Con ella ingresarás a la aplicación STARBANK y se te solicitará que escribas una contraseña nueva la cual <b>será tu nueva contraseña.</b></p><br<br><p>Si tú no has solicitado este cambio de contraseña puedes ignorar este correo electrónico.</p></body></html>";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("starbankteam@gmail.com", "ptkyllujqfluvnls");

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje del Programador", ex.Message, "OK");
            }
        }

        string CodigoAleatorio()
        {
            Random rdn = new Random();
            //string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 8;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }

        static bool validateEmail(string email)
        {
        if (email == null)
        {
            return false;
        }
        if (new EmailAddressAttribute().IsValid(email))
        {
            return true;
        }
        else
        {

            return false;
        }
        }

        private void txtemail_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnEnviarCorreo.IsEnabled = true;
            if (txtEmail.Text == "")
            {
                btnEnviarCorreo.IsEnabled = false;
            }

        }

        private void makeToast(string mensaje, double duracion)
        {
         //   var ToastConfig = new ToastConfig(mensaje);
         //   ToastConfig.SetDuration(TimeSpan.FromSeconds(duracion));
         //   ToastConfig.SetPosition(ToastPosition.Bottom);
         //   UserDialogs.Instance.Toast(ToastConfig);
        }
    }
}