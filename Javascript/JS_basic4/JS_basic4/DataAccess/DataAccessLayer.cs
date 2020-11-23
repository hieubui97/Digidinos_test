using JS_basic4.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace JS_basic4.DataAccess
{
    public class DataAccessLayer
    {
        SqlConnection conn = null;

        public List<Articles> ListArticle()
        {
            DataSet dataSet = null;
            List<Articles> articleList = null;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_ListArticle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                articleList = new List<Articles>();
                var table = dataSet.Tables[0];  
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Articles articles = new Articles();
                    articles.Id = Convert.ToInt32(table.Rows[i]["Id"].ToString());
                    articles.Title = table.Rows[i]["Title"].ToString();
                    articles.Des = table.Rows[i]["Des"].ToString();
                    articles.Detail = table.Rows[i]["Detail"].ToString();
                    articles.Category = table.Rows[i]["Category"].ToString();
                    var date = table.Rows[i]["DatePublic"].ToString();
                    if (!string.IsNullOrEmpty(date))
                    {
                        articles.DatePublic = Convert.ToDateTime(date);
                    }
                    articles.IsPublic = table.Rows[i]["IsPublic"].ToString();
                    articles.Position = table.Rows[i]["Position"].ToString();
                    articles.Thumbs = table.Rows[i]["Thumbs"].ToString();

                    articleList.Add(articles);
                }
                return articleList;
            }
            catch(Exception e)
            {
                return articleList;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Position> GetPosition()
        {
            DataSet dataSet = null;
            List<Position> positionList = null;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_GetPosition", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                positionList = new List<Position>();
                var table = dataSet.Tables[0];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Position position = new Position();
                    position.Id = Convert.ToInt32(table.Rows[i]["Id"].ToString());
                    position.Name = table.Rows[i]["Name"].ToString();

                    positionList.Add(position);
                }
                return positionList;
            }
            catch
            {
                return positionList;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Category> GetCategory()
        {
            DataSet dataSet = null;
            List<Category> categoryList = null;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_GetCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                categoryList = new List<Category>();
                var table = dataSet.Tables[0];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(table.Rows[i]["Id"].ToString());
                    category.Name = table.Rows[i]["Name"].ToString();

                    categoryList.Add(category);
                }
                return categoryList;
            }
            catch
            {
                return categoryList;
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertArticle(Article article)
        {
            int result;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_InsertArticle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", article.Title);
                cmd.Parameters.AddWithValue("@des", article.Des);
                cmd.Parameters.AddWithValue("@detail", article.Detail);
                cmd.Parameters.AddWithValue("@categoryid", article.CategoryId);
                cmd.Parameters.AddWithValue("@ispublic", article.IsPublic);
                cmd.Parameters.AddWithValue("@datepublic", article.DatePublic);
                cmd.Parameters.AddWithValue("@thumbs", article.Thumbs);
                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                return result;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public string InsertArticlePosition(int articleId, int positionId)
        {
            string result = "";
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_InsertArticlePosition", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@articleid", articleId);
                cmd.Parameters.AddWithValue("@positionid", positionId);
                conn.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteArticle(int id)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_DeleteArticle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteScalar();
            }
            catch
            {
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        public Article GetArticle(int id)
        {
            DataSet dataSet = null;
            Article article = new Article();
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_GetArticle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                var table = dataSet.Tables[0];
                article.Id = Convert.ToInt32(table.Rows[0]["Id"].ToString());
                article.Title = table.Rows[0]["Title"].ToString();
                article.Des = table.Rows[0]["Des"].ToString();
                article.Detail = table.Rows[0]["Detail"].ToString();
                article.CategoryId = Convert.ToInt32(table.Rows[0]["CategoryId"].ToString());
                var date = table.Rows[0]["DatePublic"].ToString();
                if (!string.IsNullOrEmpty(date))
                {
                    article.DatePublic = Convert.ToDateTime(date);
                }
                article.IsPublic = Convert.ToBoolean(table.Rows[0]["IsPublic"].ToString());
                //article.Position = table.Rows[0]["Position"].ToString();
                article.Thumbs = table.Rows[0]["Thumbs"].ToString();

                return article;
            }
            catch
            {
                return article;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Position> GetArticlePosition(int articleid)
        {
            DataSet dataSet = null;
            List<Position> positionList = null;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_GetArticlePosition", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@articleid", articleid);

                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                positionList = new List<Position>();
                var table = dataSet.Tables[0];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Position position = new Position();
                    position.Id = Convert.ToInt32(table.Rows[i]["Id"].ToString());
                    position.Name = table.Rows[i]["Name"].ToString();

                    positionList.Add(position);
                }
                return positionList;
            }
            catch
            {
                return positionList;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateArticle(Article article)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_UpdateArticle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", article.Id);
                cmd.Parameters.AddWithValue("@title", article.Title);
                cmd.Parameters.AddWithValue("@des", article.Des);
                cmd.Parameters.AddWithValue("@detail", article.Detail);
                cmd.Parameters.AddWithValue("@categoryid", article.CategoryId);
                cmd.Parameters.AddWithValue("@ispublic", article.IsPublic);
                cmd.Parameters.AddWithValue("@datepublic", article.DatePublic);
                cmd.Parameters.AddWithValue("@thumbs", article.Thumbs);
                conn.Open();
                cmd.ExecuteScalar();
            }
            catch
            {
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Articles> SearchArticle(string searchString)
        {
            DataSet dataSet = null;
            List<Articles> articleList = null;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("USP_SearchArticle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@searchString", searchString);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                articleList = new List<Articles>();
                var table = dataSet.Tables[0];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Articles articles = new Articles();
                    articles.Id = Convert.ToInt32(table.Rows[i]["Id"].ToString());
                    articles.Title = table.Rows[i]["Title"].ToString();
                    articles.Des = table.Rows[i]["Des"].ToString();
                    articles.Detail = table.Rows[i]["Detail"].ToString();
                    articles.Category = table.Rows[i]["Category"].ToString();
                    var date = table.Rows[i]["DatePublic"].ToString();
                    if (!string.IsNullOrEmpty(date))
                    {
                        articles.DatePublic = Convert.ToDateTime(date);
                    }
                    articles.IsPublic = table.Rows[i]["IsPublic"].ToString();
                    articles.Position = table.Rows[i]["Position"].ToString();
                    articles.Thumbs = table.Rows[i]["Thumbs"].ToString();

                    articleList.Add(articles);
                }
                return articleList;
            }
            catch
            {
                return articleList;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}