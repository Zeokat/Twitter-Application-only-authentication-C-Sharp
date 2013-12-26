using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace Twitter__App_only_auth____Vozidea.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            string consumer_key = textBox_consumer.Text;
            string consumer_secret = textBox_secret.Text;
            
            //Obtenemos el acess_token que es lo que nos autentifica
            string access_token = GetAccessToken(consumer_key, consumer_secret);
            
            //Obtenemos el código JSON de respuesta del Timeline (o muro de Twitter) de Vozidea
            string usuario = textBox_user.Text;
            string timeline_json = GetTimeline(access_token, usuario);

            textBox_json.Text = timeline_json;
        }

        // Función para obtener el acess-token
        private string GetAccessToken(string consumer_key, string consumer_secret)
        {
            //Tenemos que unir la consumer_key y la consumer_secret con el caracter ":"
            //Además ambas claves van codificadas con base64
            string auth_string = Convert.ToBase64String(Encoding.UTF8.GetBytes(
                 Uri.EscapeDataString(consumer_key)
                 + ":" +
                 Uri.EscapeDataString(consumer_secret)
                 ));

            //Hacemos una petición del tipo POST para autentificarnos con las llaves consumer
            var oauth_url = "https://api.twitter.com/oauth2/token";
            var post_data = "grant_type=client_credentials";
            ServicePointManager.Expect100Continue = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(oauth_url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            request.Headers.Add("Accept-Encoding", "gzip");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Headers.Add("Authorization", "Basic " + auth_string);
            using (Stream stream = request.GetRequestStream())
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(post_data);
                stream.Write(content, 0, content.Length);
            }

            //La respuesta a nuestra petición POST viene en formato JSON
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string respuesta_json = sr.ReadToEnd();
            sr.Close();
            response.Close();

            //Parseamos la respuesta JSON para obtener el access_token
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(respuesta_json);
            string access_token = item["access_token"];

            return access_token;
        }

        //Función para obtener el Timeline del suaurio Vozidea
        private string GetTimeline(string access_token, string usuario)
        {
            //Petición GET al timeline de Twitter
            ServicePointManager.Expect100Continue = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.twitter.com/1.1/statuses/user_timeline.json?count=3&screen_name=" + usuario);
            request.Method = "GET";
            request.Headers.Add("Authorization", "Bearer " + access_token);
            request.Headers.Add("Accept-Encoding", "gzip");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            //Obtenemos el código JSON de la respuesta
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string respuesta_json = sr.ReadToEnd();
            sr.Close();
            response.Close();

            return respuesta_json;
        }
    }
}
