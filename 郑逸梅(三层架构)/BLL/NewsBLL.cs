using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NewsBLL
    {
        DAL.NewsDAL news = new DAL.NewsDAL();

        public bool InsertNews(Model.News n)
       {
           return news.InsertNews(n);
       }

        public DataTable SearchNews(Model.News n)
        {
            return news.SearchNews(n);
        }

        public void DeleteInformation(int ID)
        {
            news.DeleteInformation(ID);
        }

        public DataTable SearchPointedNews(string date)
        {
            return news.SearchPointedNews(date);
        }

        public DataTable SearchIDNews(Model.News n)
        {
            return news.SearchIDNews(n);
        }

        public bool UpdateNews(Model.News n)
        {
            return news.UpdateNews(n);
        }

        public DataTable ShowNewsTitle()
        {
            return news.ShowNewsTitle();
        }

        public DataTable ShowNewsDetail(Model.News n)
        {
            return news.ShowNewsDetail(n);
        }

        public void UpdateNewsHit(Model.News n)
        {
            news.UpdateNewsHit(n);
        }
    }
}
