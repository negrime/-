using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace _6
{
    public class VK
    {
        private static string clientId = "6732115";
        private string tokenAddress = "https://oauth.vk.com/authorize?client_id=" + clientId + "&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.52";
        private static string token = "3741e694008e91ba2daa8261a368457af9922e6c41699e55a84c10d4faebb516cc24b80ef6a771e494d62";
        private string id = "360149026";

        public static List<string> GetFio()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string address = "https://api.vk.com/method/friends.get?fields="+ "nickname, domain, sex, bdate, city, country, timezone, photo_50, photo_100, photo_200_orig, has_mobile, contacts, education, online, relation, last_seen, status, can_write_private_message, can_see_all_posts, can_post, universities" + "&access_token=817363f17a294683bb497dc13432b0d6b27f19a6ef5d80c378ae0b0a8e406431c6246191872731862d5df" + "&v=5.52";
           // сlient.Encoding = Encoding.UTF8;
            string s = client.DownloadString(address);
            //string result = "huy";
            Friends i = JsonConvert.DeserializeObject<Friends>(s);
            List<string> Fio = new List<string>();
            try
            {
                foreach (var item in i.response.items)
                {
                    Fio.Add(item.first_name + " " + item.last_name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сгенерировать ФИО не удалось!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }   
            return Fio;
        }
    }
}
