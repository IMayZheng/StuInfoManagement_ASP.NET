using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.App_Code;

namespace DAL
{
    public class NewsDAL
    {
        DBOperation db = new DBOperation();
        ProOperation pr = new ProOperation();
        //发布新闻
        public bool InsertNews(Model.News news)
        {
            bool flag = false;
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@newstitle",SqlDbType.VarChar,50),
                                                            new SqlParameter("@newscontent",SqlDbType.VarChar,50),
                                                            new SqlParameter("@newsauthor",SqlDbType.VarChar,50),
                                                            new SqlParameter("@newshit",SqlDbType.Int,32)
                                     };
            parameter[0].Value =news.Title;
            parameter[1].Value = news.Content;
            parameter[2].Value = news.Author;
            parameter[3].Value = news.Hit;
            flag = pr.ExecuteProcedure("InsertNews", parameter);
            return flag;
        }

        //新闻数据的显示（数据表）
        public DataTable SearchNews(Model.News news)
        {
            string SQL = "select * from news";
            return db.SQLGetDataTable(SQL);
        }

        //新闻数据的删除（数据库）
        public void DeleteInformation(int id)
        {
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@ID",SqlDbType.Int,32)
                                     };
            parameter[0].Value = id;
            pr.ExcutePro("DeleteNewsInformation", parameter);
            //string SQL = "delete from news where id=" + id;
            //db.SQLExecute(SQL);
        }

        //新闻数据的查询（数据表）
        public DataTable SearchPointedNews(string date)
        {
            string SQL = "select * from News where Convert(varchar(200),subdate,111)='"+date+"'";
            return db.SQLGetDataTable(SQL);
        }

        //新闻数据定点查询
        public DataTable SearchIDNews(Model.News news)
        {
            string SQL = "select * from news where newstitle='"+news.Title+"'";
            return db.SQLGetDataTable(SQL);
        }

        //新闻数据的更新
        public bool UpdateNews(Model.News news)
        {
            bool flag = false;
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@newstitle",SqlDbType.VarChar,50),
                                                            new SqlParameter("@newscontent",SqlDbType.VarChar,50),
                                                            new SqlParameter("@newsauthor",SqlDbType.VarChar,50)
                                     };
            parameter[0].Value = news.Title;
            parameter[1].Value = news.Content;
            parameter[2].Value = news.Author;
            flag = pr.ExecuteProcedure("UpdateNews", parameter);
            //string SQL = "";
            //SQL = "update news set newscontent='" + news.Content + "',newsauthor='" + news.Author + "' where newstitle='" + news.Title + "'";
            //int count = db.SQLExecuteReturn(SQL);
            //if (count > 0)
            //    flag = true;
            return flag;
        }

        //新闻标题显示
        public DataTable ShowNewsTitle()
        {
            string SQL = "select * from news order by subdate desc ";
            return db.SQLGetDataTable(SQL);
        }

        //显示具体新闻内容
        public DataTable ShowNewsDetail(Model.News news)
        {
            string SQL = "select * from news where ID='"+news.ID+"'";
            return db.SQLGetDataTable(SQL);
        }

        //更新新闻点击率
        public void UpdateNewsHit(Model.News news)
        {
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@ID",SqlDbType.Int,32)
                                     };
            parameter[0].Value = news.ID;
            pr.ExcutePro("UpdateNewsHit", parameter);
            //string SQL = "update news set newshit=newshit+1 where id='"+news.ID+"'";
            //db.SQLExecute(SQL);
        }
    }
}
