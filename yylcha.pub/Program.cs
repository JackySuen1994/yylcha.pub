using yylcha.pub.common;
using yylcha.pub.views;

namespace yylcha.pub
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string redisConn = "redis://用户名:密码@地址:端口号/数据库";//如果没有用户名,则 用户名地址是空就行
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}