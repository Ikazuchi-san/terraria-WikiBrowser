using System.Net.Http;

namespace WikiBrowser{

    public class Fetch{
        
        private string queryContent = asddsa;
        private string targetUrl = "https://terraria.fandom.com/wiki/Special:Search?search=" + queryContent + "&go=Go";

        public async void main()
        {

            HttpClient httpClient = new HttpClient();
            string html = httpClient.getStringAsync(targetUrl);

            System.Console.WriteLine(html.result);

            console.readLine();

        }

    }

}