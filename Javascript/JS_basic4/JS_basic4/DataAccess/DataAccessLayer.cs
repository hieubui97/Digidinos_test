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
            List<Articles> articlesList = null;
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
                articlesList = new List<Articles>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Articles articles = new Articles();
                    articles.Id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id"].ToString());
                    articles.Title = dataSet.Tables[0].Rows[i]["Title"].ToString();
                    articles.Des = dataSet.Tables[0].Rows[i]["Des"].ToString();
                    articles.Detail = dataSet.Tables[0].Rows[i]["Detail"].ToString();
                    articles.Category = dataSet.Tables[0].Rows[i]["Category"].ToString();
                    var date = dataSet.Tables[0].Rows[i]["DatePublic"].ToString();
                    if (!string.IsNullOrEmpty(date))
                    {
                        articles.DatePublic = Convert.ToDateTime(date);
                    }
                    articles.IsPublic = dataSet.Tables[0].Rows[i]["IsPublic"].ToString();
                    articles.Position = dataSet.Tables[0].Rows[i]["Position"].ToString();
                    articles.Thumbs = dataSet.Tables[0].Rows[i]["Thumbs"].ToString();

                    articlesList.Add(articles);
                }
                return articlesList;
            }
            catch
            {
                return articlesList;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Position> GetPosition()
        {
            DataSet dataSet = null;
            List<Position> positions = null;
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
                positions = new List<Position>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Position position = new Position();
                    position.Id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id"].ToString());
                    position.Name = dataSet.Tables[0].Rows[i]["Name"].ToString();

                    positions.Add(position);
                }
                return positions;
            }
            catch
            {
                return positions;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Category> GetCategory()
        {
            DataSet dataSet = null;
            List<Category> categories = null;
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
                categories = new List<Category>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id"].ToString());
                    category.Name = dataSet.Tables[0].Rows[i]["Name"].ToString();

                    categories.Add(category);
                }
                return categories;
            }
            catch
            {
                return categories;
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

                article.Id = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Id"].ToString());
                article.Title = dataSet.Tables[0].Rows[0]["Title"].ToString();
                article.Des = dataSet.Tables[0].Rows[0]["Des"].ToString();
                article.Detail = dataSet.Tables[0].Rows[0]["Detail"].ToString();
                article.CategoryId = Convert.ToInt32(dataSet.Tables[0].Rows[0]["CategoryId"].ToString());
                var date = dataSet.Tables[0].Rows[0]["DatePublic"].ToString();
                if (!string.IsNullOrEmpty(date))
                {
                    article.DatePublic = Convert.ToDateTime(date);
                }
                article.IsPublic = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["IsPublic"].ToString());
                //article.Position = dataSet.Tables[0].Rows[0]["Position"].ToString();
                article.Thumbs = dataSet.Tables[0].Rows[0]["Thumbs"].ToString();

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
            List<Position> positions = null;
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
                positions = new List<Position>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Position position = new Position();
                    position.Id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id"].ToString());
                    position.Name = dataSet.Tables[0].Rows[i]["Name"].ToString();

                    positions.Add(position);
                }
                return positions;
            }
            catch
            {
                return positions;
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
            List<Articles> articlesList = null;
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
                articlesList = new List<Articles>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Articles articles = new Articles();
                    articles.Id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id"].ToString());
                    articles.Title = dataSet.Tables[0].Rows[i]["Title"].ToString();
                    articles.Des = dataSet.Tables[0].Rows[i]["Des"].ToString();
                    articles.Detail = dataSet.Tables[0].Rows[i]["Detail"].ToString();
                    articles.Category = dataSet.Tables[0].Rows[i]["Category"].ToString();
                    var date = dataSet.Tables[0].Rows[i]["DatePublic"].ToString();
                    if (!string.IsNullOrEmpty(date))
                    {
                        articles.DatePublic = Convert.ToDateTime(date);
                    }
                    articles.IsPublic = dataSet.Tables[0].Rows[i]["IsPublic"].ToString();
                    articles.Position = dataSet.Tables[0].Rows[i]["Position"].ToString();
                    articles.Thumbs = dataSet.Tables[0].Rows[i]["Thumbs"].ToString();

                    articlesList.Add(articles);
                }
                return articlesList;
            }
            catch
            {
                return articlesList;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}