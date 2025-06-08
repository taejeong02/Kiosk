using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Azure.AI.Translation.Text;
using Newtonsoft.Json;

namespace KioskProject
{
    public class LangINFO
    {
        public static string CurrentLanguage { get; set; } = "ko";

        private static readonly string key = "6wURIOdYRniaF3tGRZ9m24bjkSqZlFe4NRlnrNoV2fLzXK4tQU9aJQQJ99BFACNns7RXJ3w3AAAbACOGpe1t";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";

        private static readonly string location = "koreacentral";

        /*static public async Task<string> transString(string textToTranslate, string targetLg)
        { //한국어를 {tagetLg} 언어로 번역하도록 하는 구문
            string route = $"/translate?api-version=3.0&from=ko&to={targetLg}";
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key);
                // location required if you're using a multi-service or regional (not global) resource.
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                string translatedText = jsonResponse[0].translations[0].text;

                return translatedText;
            }
        }*/
        public static async Task<string> TranslateStringAsync(string textToTranslate, string targetLanguage)
        {
            if (string.IsNullOrWhiteSpace(textToTranslate)) return "";

            string route = $"/translate?api-version=3.0&from=ko&to={targetLanguage}";
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                HttpResponseMessage response = await client.SendAsync(request);
                string result = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                string translatedText = jsonResponse[0].translations[0].text;
                return translatedText;
            }
        }

        /*internal static async Task<string> transString(object textToTranslate, object targetLanguage)
        {
            throw new NotImplementedException();
        }*/

        public static async Task TranslateControlsAsync(Control root, string targetLanguage)
        {
            foreach (Control control in root.Controls)
            {
                // 재귀 호출로 내부 컨트롤까지 모두 처리
                await TranslateControlsAsync(control, targetLanguage);

                if (!string.IsNullOrWhiteSpace(control.Text))
                {
                    string translated = await TranslateStringAsync(control.Text, targetLanguage);
                    control.Text = translated;
                }
            }
        }
    }
}