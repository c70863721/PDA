using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Data;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Forms;
namespace Tsmt.Data
{
    class HttpHelp
    {
        public HttpHelp()
        {
        }
        public static string HttpPost(string url, string parameter)
        {
            string result = string.Empty;
            Stream stream;
            try
            {
                Encoding encoding = Encoding.GetEncoding("gb2312");
                byte[] bytes = encoding.GetBytes(parameter);
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Timeout = 5000;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST";
                request.ContentLength = bytes.Length;
                stream = request.GetRequestStream();
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));
                result = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;

        }
        public static string HttpGet(string url)
        {
            System.GC.Collect();
            string result = string.Empty;
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;
            try
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
                System.Net.ServicePointManager.DefaultConnectionLimit = 50;
                httpRequest.KeepAlive = false;
                httpRequest.Timeout = 8000;
                httpRequest.Method = "GET";
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                StreamReader sr = new StreamReader(httpResponse.GetResponseStream(), System.Text.Encoding.GetEncoding("gb2312"));
                result = sr.ReadToEnd();

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (httpResponse != null)
            {
                httpResponse.Close();
            }
            if (httpRequest != null)
            {
                httpRequest.Abort();
            }
            return result;
        }
    }
}
