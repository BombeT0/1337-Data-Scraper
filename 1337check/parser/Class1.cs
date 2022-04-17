using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using _1337check;


namespace _1337check.parser
{
    public class check
    {
        const string xName = "/html/body/main/div/div/div[3]/div/table/tbody/tr[1]/td[1]/a[2]";
        const string xSize = "/html/body/main/div/div/div[3]/div/table/tbody/tr[1]/td[5]";
        const string xLeecher = "/html/body/main/div/div/div[3]/div/table/tbody/tr[1]/td[3]";
        const string xSeeder = "/html/body/main/div/div/div[3]/div/table/tbody/tr[1]/td[2]";
        const string xLink = "/html/body/main/div/div/div[3]/div/table/tbody/tr[1]/td[1]/a[2]";
        const string xMagnetic = "/html/body/main/div/div/div/div[2]/div[1]/ul[1]/li[1]/a";




        public static (string, string, string, string, string, string) game(){

        var web = new HtmlWeb();
        var doc = web.Load("https://www.1377x.to/popular-games");

            string name = doc.DocumentNode.SelectSingleNode(xName).InnerText;
            string size = doc.DocumentNode.SelectSingleNode(xSize).InnerText;
            string leecher = doc.DocumentNode.SelectSingleNode(xLeecher).InnerText;
            string seeder = doc.DocumentNode.SelectSingleNode(xSeeder).InnerText;
            string link = doc.DocumentNode.SelectSingleNode(xLink).Attributes["href"].Value;

            var magDoc = web.Load("https://www.1377x.to/" + link);
            string magnetic = magDoc.DocumentNode.SelectSingleNode(xMagnetic).Attributes["href"].Value;

            return (name, size, leecher, seeder, link, magnetic);
        }

        public static (string, string, string, string, string, string) app()
        {
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load("https://www.1377x.to/popular-apps");

            string name = doc.DocumentNode.SelectSingleNode(xName).InnerText;
            string size = doc.DocumentNode.SelectSingleNode(xSize).InnerText;
            string leecher = doc.DocumentNode.SelectSingleNode(xLeecher).InnerText;
            string seeder = doc.DocumentNode.SelectSingleNode(xSeeder).InnerText;
            string link = doc.DocumentNode.SelectSingleNode(xLink).Attributes["href"].Value;

            var magDoc = web.Load("https://www.1377x.to/" + link);
            string magnetic = magDoc.DocumentNode.SelectSingleNode(xMagnetic).Attributes["href"].Value;

            return (name, size, leecher, seeder, link, magnetic);

        }

        public static (string, string, string, string, string, string) movie()
        {
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load("https://www.1377x.to/popular-movies");

            string name = doc.DocumentNode.SelectSingleNode(xName).InnerText;
            string size = doc.DocumentNode.SelectSingleNode(xSize).InnerText;
            string leecher = doc.DocumentNode.SelectSingleNode(xLeecher).InnerText;
            string seeder = doc.DocumentNode.SelectSingleNode(xSeeder).InnerText;
            string link = doc.DocumentNode.SelectSingleNode(xLink).Attributes["href"].Value;

            var magDoc = web.Load("https://www.1377x.to/" + link);
            string magnetic = magDoc.DocumentNode.SelectSingleNode(xMagnetic).Attributes["href"].Value;

            return (name, size, leecher, seeder, link, magnetic);

        }

    }
}
