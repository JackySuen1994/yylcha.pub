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
            //string redisConn = "redis://�û���:����@��ַ:�˿ں�/���ݿ�";//���û���û���,�� �û�����ַ�ǿվ���
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}