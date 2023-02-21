using DocsvisionClientApp.ApiList;
using DocsvisionClientApp.Model;
using DocsvisionClientApp.Models;
using DocsvisionClientApp.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DocsvisionClientApp.UserControls
{
    public partial class UC_SendEmail : UserControl
    {
        public UC_SendEmail()
        {
            InitializeComponent();
            
            // {Timer для BGWUpdateProfileList_DoWork
            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = (1000*60); //60 секунд
            MyTimer.Tick += new EventHandler(BGWUpdateProfileList_DoWork);
            MyTimer.Start();
            // }
        }

        private async void SendEmail_Click(object sender, EventArgs e)
        {
            EmailModel NewEmail = new EmailModel()
            {
                emailSubject = EmailSubject.Text,
                emailFrom= EmailSender.Text,
                emailTo= EmailReceiverTextBox.Text,
                emailBody = EmailBody.Text,
            };
            var jsonToSend  =  await ConfigureEmailJson.ConfigureJson(NewEmail);
            var SendEmailPost = await API.ApiPost(ApiList.ApiList.postNewEmail, jsonToSend);

            //Формируем лог отправки писем
            StringBuilder sb = new StringBuilder($"{ErrorList.Text}");
            sb.Append($"{Environment.NewLine}{DateTime.Now}:{SendEmailPost}");
            ErrorList.Text = sb.ToString();
            MessageBox.Show(SendEmailPost);
        }

        //{ Получаем с помощью нашего API актуальный список пользователей.
        private async void BGWUpdateProfileList_DoWork(object sender, EventArgs e)
        {
            // Возвращаем с API json и конвертируем его в объект типа ProfileModel.
            // Можно ограничиться коллекцией строк, однако если нам потребуется динамически обновлять доп. поля:
            // через объекты будет медленне, но проще. 
            try
            {
                var profileListObject = await API.ApiGet(ApiList.ApiList.getProfileList);
                var a = profileListObject.GetValue("Data").ToString();
                List<ProfileModel> profileLists = JsonConvert.DeserializeObject<List<ProfileModel>>(a);
                autoCompleteEmailReceiver(profileLists);
            }
            catch (Exception ex)
            {
                ErrorList.Text = ErrorList.Text + $"{DateTime.Now} : Отсутствует соединение с сервером, обратитесь на горячую линию поддержки.\n Информация для технического специалиста: {ex}";
            } 
        }

        private void autoCompleteEmailReceiver(List<ProfileModel> profileModels)
        {
            var newArray = profileModels.Select(x => $"{x.lastName} {x.firstName}").ToArray();
            EmailReceiverTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EmailReceiverTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            EmailReceiverTextBox.AutoCompleteCustomSource.AddRange(newArray);
        }
        //}
    }
}
