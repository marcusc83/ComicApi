using System;
using apidemo.Constants;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net.Http;

namespace apidemo
{
    public class ComicProcessor
    {
       
        
        public static async Task<ComicModel.Root> LoadComic(int comicNumber = 0)
        {
            Constant constant = new Constant();
            string url = "";
            try
            {
               
                if (comicNumber == 0)
                {
                    url = constant.GetCurrentURL();
                }
                else if(comicNumber > 0)
                {
                    url = String.Format(constant.GetSpecifiedURL(), comicNumber);
                }
                else
                {
                    MessageBox.Show("Site Not Found, Try again", "Error");
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    ComicModel.Root comic = await response.Content.ReadAsAsync<ComicModel.Root>();
                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);                
                }
            }
        }
    }
}
