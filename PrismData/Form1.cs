using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace PrismData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Authenticate_Click(object sender, EventArgs e)
        {
            String AuthURL = "/v1/rest/auth";
            Console.WriteLine(PrismServerName.Text);
            HttpWebRequest authRequest = (HttpWebRequest)WebRequest.Create("https://" + PrismServerName.Text + AuthURL);
            authRequest.Method = "Get";
            HttpWebResponse authResponse = (HttpWebResponse)authRequest.GetResponse();
            int authNonceValue = Convert.ToInt32(authResponse.Headers.Get("Auth-Nonce"));

            //Calculate Auth-Nonce-Response 
            int authNonceResponseValue = (int)((Math.Truncate((Decimal)(authNonceValue / 13))) % 99999) * 17;

            AuthNonce.Text = authNonceValue.ToString();
            AuthNonceResponse.Text = authNonceResponseValue.ToString();

            //Get Auth-Session
            String credentials = "?usr="+PrismUserName.Text+"&pwd="+PrismPassword.Text;
           // Console.WriteLine(url + credentials);
            HttpWebRequest sessionTokenRequest = (HttpWebRequest)WebRequest.Create("https://" + PrismServerName.Text + AuthURL + credentials);
            sessionTokenRequest.Headers.Add("Auth-Nonce", authNonceValue.ToString());
            sessionTokenRequest.Headers.Add("Auth-Nonce-Response", authNonceResponseValue.ToString());
            sessionTokenRequest.Method = "GET";
            HttpWebResponse sessionTokenResponse = (HttpWebResponse)sessionTokenRequest.GetResponse();
            String authSession = sessionTokenResponse.Headers.Get("Auth-Session");
            AuthSessionToken.Text = authSession;            
            
        }

        private void ExcuteRequest_Click(object sender, EventArgs e)
        {
            String requestURI = "https://" + PrismServerName.Text + RequestSource.Text + ResourceName.Text;
            //+  "?filter=" + ResourceFilter.Text + "&cols=" + ResourceColumns.Text;

            if (ResourceFilter.Text != null && ResourceFilter.Text != "")
            {
                requestURI += "?filter=" + ResourceFilter.Text;
                if (ResourceColumns.Text != null && ResourceColumns.Text != "")
                {
                    requestURI += "&cols=" + ResourceColumns.Text; 
                }
                else
                {
                    requestURI += "&cols=*";
                }
            }
            else
            {
                if (ResourceColumns.Text != null && ResourceColumns.Text != "")
                {
                    requestURI += "?cols=" + ResourceColumns.Text;
                }
                else
                {
                    requestURI += "?cols=*";                
                }
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestURI);
            request.ContentType = "application/json";
            request.Accept = "application/json, text/plain, version=2";
            request.ProtocolVersion = System.Net.HttpVersion.Version11;
            request.Headers.Add("Auth-Session", AuthSessionToken.Text);         
            request.Method = RequestMethod.Text;

            Console.WriteLine(request.RequestUri.ToString());

            ResponseLog.Text += "*****************************************************************\n";
            ResponseLog.Text += request.Method + " " + request.RequestUri.ToString() + "\n";
            ResponseLog.Text += request.Headers + "\n";

            if (RequestMethod.Text == "Post" || RequestMethod.Text == "Put")
            {
                string requestBody = RequestPayload.Text;
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(requestBody);

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(byte1, 0, byte1.Length);

                ResponseLog.Text += requestBody + "\n\n";

                // Close the Stream object.
                requestStream.Close();
            }
            
                HttpWebResponse response;
                try
                {
                     response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                     response = (HttpWebResponse)ex.Response;
                   //  ResponseLog.Text = ex.Response.ToString();
                }
          
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                String responseString = reader.ReadToEnd();

                String responseBody = JsonConvert.SerializeObject(responseString,Formatting.Indented);
                Console.WriteLine(responseBody);

                // JObject o = JObject.Parse(json);
                ResponsePayload.Text = responseBody;

            ResponseLog.Text += "RESPONSE \n";
            ResponseLog.Text += response.Headers + "\n" + responseBody +"\n\n";
        }               
    }
}
